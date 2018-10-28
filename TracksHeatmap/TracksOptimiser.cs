﻿using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracksHeatmap
{
    public enum TracksStyles { Simple, With_background, With_2_backgrounds }

    public class TracksOptimiser
    {
        public string Info;
        public int ZoomRatio = 1;
        public Color BackgroundColor;
        public Color BackgroundColor2 = Color.FromArgb(3, 124, 34);

        public void Run(GMapControl gMap, List<Geo.Gps.Track> tracks, Color trackColor, int trackWidth, TracksStyles tracksStyles)
        {
            if (tracks == null) return;

            int minPixels = 12;
            switch (tracksStyles)
            {
                case TracksStyles.Simple: minPixels = 3; break;
                case TracksStyles.With_background: minPixels = 7; break;
                default: break;
            }

            double minimimDistance = minPixels /* at least 3 pixels */ * gMap.ViewArea.WidthLng / gMap.Size.Width;
            int oldCount = 0, newCount = 0;
            GMapOverlay tracksPolygonsOverlay = FindOverlay(Constants.TracksPolygonsId, gMap);
            GMapOverlay tracksPolygons2Overlay = FindOverlay(Constants.TracksPolygons2Id, gMap);
            GMapOverlay tracksPolygons3Overlay = FindOverlay(Constants.TracksPolygons3Id, gMap);
            if (tracksPolygonsOverlay == null)
            {
                tracksPolygonsOverlay = new GMapOverlay(Constants.TracksPolygonsId);
                tracksPolygons2Overlay = new GMapOverlay(Constants.TracksPolygons2Id);
                tracksPolygons3Overlay = new GMapOverlay(Constants.TracksPolygons3Id);

                gMap.Overlays.Add(tracksPolygons3Overlay);
                gMap.Overlays.Add(tracksPolygons2Overlay);
                gMap.Overlays.Add(tracksPolygonsOverlay);
            }

            tracksPolygonsOverlay.Routes.Clear();
            tracksPolygons2Overlay.Routes.Clear();
            tracksPolygons3Overlay.Routes.Clear();

            foreach (var track in tracks)
            {
                Geo.Gps.Fix lastPoint = track.GetFirstFix();
                string tagName = lastPoint.TimeUtc.ToShortDateString() + " " + lastPoint.TimeUtc.ToShortTimeString();
                if (track.Metadata.ContainsKey("name"))
                {
                    tagName += "; " + track.Metadata["name"].ToString();
                }
                if (track.Metadata.ContainsKey("filename"))
                {
                    tagName += "; " + track.Metadata["filename"].ToString();
                }

                List<PointLatLng> mapPoints = new List<PointLatLng>();
                mapPoints.Add(new PointLatLng(lastPoint.Coordinate.Latitude, lastPoint.Coordinate.Longitude));

                foreach (var segment in track.Segments)
                {
                    foreach (var point in segment.Fixes)
                    {
                        double distance = GetDistance(lastPoint.Coordinate.Latitude, lastPoint.Coordinate.Longitude, point.Coordinate.Latitude, point.Coordinate.Longitude);
                        if (distance > minimimDistance)
                        {
                            lastPoint = point;
                            mapPoints.Add(new PointLatLng(point.Coordinate.Latitude, point.Coordinate.Longitude));
                            newCount++;
                        }

                        oldCount++;
                    }
                }

                if (mapPoints.Count > 0)
                {
                    GMapRoute route = new GMapRoute(mapPoints, "track" + tracksPolygonsOverlay.Routes.Count);
                    route.Stroke = new Pen(Color.FromArgb(255, trackColor), trackWidth * this.ZoomRatio);
                    route.Tag = tagName;
                    route.IsHitTestVisible = true;
                    tracksPolygonsOverlay.Routes.Add(route);

                    if (tracksStyles == TracksStyles.With_background || tracksStyles == TracksStyles.With_2_backgrounds)
                    {
                        GMapRoute route2 = new GMapRoute(mapPoints, "track2_" + tracksPolygons2Overlay.Routes.Count);
                        route2.Stroke = new Pen(Color.FromArgb(200, BackgroundColor), 4 * trackWidth * this.ZoomRatio);
                        route2.Tag = tagName;
                        route2.IsHitTestVisible = true;
                        tracksPolygons2Overlay.Routes.Add(route2);
                    }

                    if (tracksStyles == TracksStyles.With_2_backgrounds)
                    {
                        GMapRoute route3 = new GMapRoute(mapPoints, "track3_" + tracksPolygons2Overlay.Routes.Count);
                        route3.Stroke = new Pen(Color.FromArgb(100, BackgroundColor2), 7 * trackWidth * this.ZoomRatio);
                        route3.Tag = tagName;
                        route3.IsHitTestVisible = true;
                        tracksPolygons3Overlay.Routes.Add(route3);
                    }
                }
            }

            double ratio = (double)newCount / oldCount * 100;
            Info = "Map points: " + newCount + " (" + ratio.ToString("F0") + "%)";

            gMap.Refresh();
        }

        public static GMapOverlay FindOverlay(string overlayId, GMapControl gMap)
        {
            foreach (var overlay in gMap.Overlays)
                if (overlay.Id == overlayId)
                    return overlay;

            return null;
        }

        private double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

    }
}