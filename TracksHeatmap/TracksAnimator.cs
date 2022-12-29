using Geo.Geodesy;
using Geo.Gps;
using Geo.Gps.Serialization;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracksHeatmap
{
    public class TracksAnimator
    {
        private TracksOptimiserOptions tracksOptimiserOptions;
        private Geo.Gps.Track track;
        private string outImagesFolder;
        private int imageStep = 0;
        private Geo.Gps.Fix lastPoint = null;
        private int upDownAnimationStep = 200;
        private GMapOverlay tracksMarkersOverlay;
        private bool drawMarkers = true;

        public int Progress;

        public TracksAnimator(TracksOptimiserOptions tracksOptimiserOptions)
        {
            this.tracksOptimiserOptions = tracksOptimiserOptions;
        }

        public List<Fix> InitAnimation(GMapControl gMap, List<Geo.Gps.Track> tracks, int upDownAnimationStep, bool drawMarkers)
        {
            outImagesFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TracksAnimator";
            if (!Directory.Exists(outImagesFolder))
                Directory.CreateDirectory(outImagesFolder);
            imageStep = 0;
            lastPoint = null;

            tracksMarkersOverlay = FindOverlay(Constants.TracksMarkers, gMap);
            if (tracksMarkersOverlay == null)
            {
                tracksMarkersOverlay = new GMapOverlay(Constants.TracksMarkers);
                gMap.Overlays.Add(tracksMarkersOverlay);
            }

            List<Fix> fixes = new List<Fix>();

            track = tracks[0];
            fixes.Add(track.GetFirstFix());
            fixes.Add(track.GetLastFix());

            if (drawMarkers)
            {
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(fixes[0].Coordinate.Latitude, fixes[0].Coordinate.Longitude), GMarkerGoogleType.green_big_go);
                tracksMarkersOverlay.Markers.Add(marker);

                GMapMarker markerCurrent = new GMarkerGoogle(new PointLatLng(fixes[1].Coordinate.Latitude, fixes[1].Coordinate.Longitude), GMarkerGoogleType.orange_dot);
                markerCurrent.IsVisible = false;
                tracksMarkersOverlay.Markers.Add(markerCurrent);

                GMapMarker markerEnd = new GMarkerGoogle(new PointLatLng(fixes[1].Coordinate.Latitude, fixes[1].Coordinate.Longitude), GMarkerGoogleType.red_big_stop);
                tracksMarkersOverlay.Markers.Add(markerEnd);

                gMap.Refresh();
                
                // save 3 end frames
                for (int i = 0; i < 3; i++)
                {
                    SaveFrame(gMap);
                }

                markerCurrent.IsVisible = true;
                tracksMarkersOverlay.Markers.RemoveAt(2);
                //markerEnd.IsVisible = false;
            }

            return fixes;
        }

        private void SaveFrame(GMapControl gMap)
        {
            //gMap.ToImage().Save(outImagesFolder + "\\tmp" + imageStep + ".png");
            gMap.ToImage().Save(outImagesFolder + "\\tmp" + imageStep + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            imageStep++;
        }

        public bool AnimationStep(GMapControl gMap)
        {
            if (TruncateTrack())
            { 
                TracksOptimiser tracksOptimiser = new TracksOptimiser();
                tracksOptimiser.Run(gMap, new List<Geo.Gps.Track> { track }, tracksOptimiserOptions);

                if (drawMarkers)
                {
                    tracksMarkersOverlay.Markers[1].Position = new PointLatLng(track.GetLastFix().Coordinate.Latitude, track.GetLastFix().Coordinate.Longitude);
                }

                Progress = track.GetAllFixes().Count();
                gMap.Refresh();

                SaveFrame(gMap);

                return true;
            }
            else
            {
                for (int i = 0; i < imageStep; i++) {
                    File.Move(outImagesFolder + "\\tmp" + i + ".jpg", outImagesFolder + "\\" + (imageStep - i).ToString("D6") + ".jpg");
                }

                return false;
            }
        }

        private bool TruncateTrack()
        {
            SpheroidCalculator spheroidCalculator = new SpheroidCalculator();
            for (int segmentIndex = track.Segments.Count - 1; segmentIndex >= 0; segmentIndex--)
            {
                var segment = track.Segments[segmentIndex];
                for (int pointIndex = segment.Fixes.Count - 1; pointIndex >= 0; pointIndex--)
                {
                    var point = segment.Fixes[pointIndex];
                    if (lastPoint != null && Math.Abs(spheroidCalculator.CalculateLength(new Geo.CoordinateSequence(lastPoint.Coordinate, point.Coordinate)).SiValue) < upDownAnimationStep)
                    {
                        segment.Fixes.RemoveAt(pointIndex);
                        continue;
                    }

                    lastPoint = point;
                    return true;
                }
            }

            return false;
        }

        public static GMapOverlay FindOverlay(string overlayId, GMapControl gMap)
        {
            foreach (var overlay in gMap.Overlays)
                if (overlay.Id == overlayId)
                    return overlay;

            return null;
        }
    }
}
