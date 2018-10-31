using Geo.Gps.Serialization;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracksHeatmap
{
    public partial class MainForm : Form
    {
        private List<GMapProvider> mapTypes = new List<GMapProvider>();
        private List<Geo.Gps.Track> Tracks;

        public MainForm()
        {
            InitializeComponent();
            
            mapTypes.Add(GMapProviders.ArcGIS_World_Topo_Map);
            mapTypes.Add(GMapProviders.ArcGIS_World_Street_Map);
            mapTypes.Add(GMapProviders.ArcGIS_StreetMap_World_2D_Map);
            mapTypes.Add(GMapProviders.BingMap);
            mapTypes.Add(GMapProviders.GoogleMap);
            mapTypes.Add(GMapProviders.GoogleHybridMap);
            mapTypes.Add(GMapProviders.GoogleTerrainMap);
            mapTypes.Add(GMapProviders.OpenCycleMap);
            mapTypes.Add(GMapProviders.OpenCycleTransportMap);
            mapTypes.Add(GMapProviders.OpenCycleLandscapeMap);
            mapTypes.Add(GMapProviders.OpenStreet4UMap);
            mapTypes.Add(GMapProviders.OpenStreetMap);
            mapTypes.Add(GMapProviders.YandexMap);
            mapTypes.Add(GMapProviders.WikiMapiaMap);

            foreach (GMapProvider mapType in mapTypes)
            {
                cmbMapType.Items.Add(mapType.ToString());
            }

            var tracksStyles = Enum.GetValues(typeof(TracksStyles)).Cast<TracksStyles>();
            foreach (var style in tracksStyles)
            {
                cmbPlotStyle.Items.Add(style.ToString().Replace("_", " "));
            }
            cmbPlotStyle.SelectedIndex = tracksStyles.Count() - 1;

            Version version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
            this.Text = "Tracks heatmap (" + version.Major + "." + version.Minor + ")";

            this.btnTrackColor.ForeColor = Color.FromArgb(255, 255, 3, 18);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkKeepAspectRatio.Checked = true;
            chkAsVisible.Checked = true;
            menuTrackName.Visible = false;

            gMap.DragButton = MouseButtons.Left;
            gMap.Position = new PointLatLng(50.059721, 22.4930113);
            gMap.Zoom = 12;

            cmbMapType.SelectedIndex = mapTypes.IndexOf(GMapProviders.OpenStreetMap);
        }

        private void gMap_OnMapZoomChanged()
        {
            zoomLabel.Text = "Zoom: " + gMap.Zoom.ToString("F1");
            LoadTracksToMap();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            gMap.Zoom += 1;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            gMap.Zoom -= 1;
        }

        private void cmbMapType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMap.MapProvider = mapTypes[cmbMapType.SelectedIndex];
            gMap.Refresh();
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            LoadTracksForm loadTracksForm = new LoadTracksForm();
            loadTracksForm.ViewArea = gMap.ViewArea;

            if (loadTracksForm.ShowDialog() == DialogResult.OK)
            {
                TimeSpan totalTime = loadTracksForm.TotalTime;
                lblTracks.Text = "Tracks: " + loadTracksForm.Tracks.Count + ";  " + (loadTracksForm.TotalDistance / 1000).ToString("F2") + "km;  " + totalTime.TotalHours.ToString("F1") + "h";
                this.Tracks = loadTracksForm.Tracks;
                txtInfo.Text = loadTracksForm.GetInfo();
                LoadTracksToMap();

                if (loadTracksForm.CenterTracks)
                {
                    // center tracks after loading
                    btnCenterTracks_Click(sender, e);
                }
            }
        }

        private void LoadTracksToMap()
        {
            if (Tracks == null) return;

            TracksOptimiser tracksOptimiser = UpdateTracksPlot();
            if (tracksOptimiser != null)
                lblMapPoints.Text = tracksOptimiser.Info;
        }

        private void gMap_SizeChanged(object sender, EventArgs e)
        {
            LoadTracksToMap();
            chkKeepAspectRatio_CheckedChanged(sender, e);
        }

        private void btnCenterTracks_Click(object sender, EventArgs e)
        {
            GMapOverlay tracksPolygonsOverlay = TracksOptimiser.FindOverlay(Constants.TracksPolygonsId, gMap);
            if (tracksPolygonsOverlay != null && tracksPolygonsOverlay.Routes.Count > 0)
            {
                gMap.ZoomAndCenterRoutes(tracksPolygonsOverlay.Id);
            }
        }

        private void chkKeepAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            numExportHeight.Enabled = !chkKeepAspectRatio.Checked;

            if (chkAsVisible.Checked)
            {
                numExportWidth.Value = gMap.Size.Width;
                numExportHeight.Value = gMap.Size.Height;
            }
            else if (chkKeepAspectRatio.Checked)
            {
                double ratio = (double)gMap.Size.Height / gMap.Size.Width;
                numExportHeight.Value = (int)(ratio * Convert.ToDouble(numExportWidth.Value));
            }
        }

        private void btnTrackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = btnTrackColor.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnTrackColor.ForeColor = colorDialog.Color;
                numTrackWidth_ValueChanged(sender, e);
            }
        }

        private void numTrackWidth_ValueChanged(object sender, EventArgs e)
        {
            UpdateTracksPlot();
        }

        private TracksOptimiser UpdateTracksPlot()
        {
            if (Tracks == null) return null;

            TracksOptimiser tracksOptimiser = new TracksOptimiser();
            tracksOptimiser.Run(this.gMap, this.Tracks, GetTrackOptions());

            return tracksOptimiser;
        }

        private TracksOptimiserOptions GetTrackOptions()
        {
            TracksOptimiserOptions options = new TracksOptimiserOptions();

            options.TrackColor = btnTrackColor.ForeColor;
            options.TrackWidth = (int)numTrackWidth.Value;
            options.TracksStyles = (TracksStyles)cmbPlotStyle.SelectedIndex;
            options.BackgroundColor = btnTrackBakground.BackColor;
            options.BackgroundColor2 = btnTrackBakground2.BackColor;
            options.TrackBackgroundWidth = Convert.ToDouble(numBakgroundWidth.Value);
            options.TrackBackground2Width = Convert.ToDouble(numBakground2Width.Value);
            options.DisconnectGapPoints = chkDisconnectGapPoints.Checked;
            options.DisconnectTrackGapsMultiple = Convert.ToDouble(numDisconnectTrackGaps.Value);

            return options;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            chkKeepAspectRatio_CheckedChanged(sender, e);

            if (chkAsVisible.Checked)
            {
                menuSaveAsImage_Click(sender, e);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Filter = "PNG|*.png|JPG|*.jpg";
                saveFileDialog.FilterIndex = 0;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportForm export = new ExportForm();
                    export.Tracks = this.Tracks;
                    export.gmap = this.gMap;
                    export.TracksOptimiserOptions = GetTrackOptions();
                    export.exportWidth = (int)numExportWidth.Value;
                    export.exportHeight = (int)numExportHeight.Value;
                    export.filename = saveFileDialog.FileName;
                    export.ShowDialog();
                }
            }
        }

        private void numExportWidth_ValueChanged(object sender, EventArgs e)
        {
            chkKeepAspectRatio_CheckedChanged(sender, e);
        }

        private void chkAsVisible_CheckedChanged(object sender, EventArgs e)
        {
            numExportWidth.Enabled = !chkAsVisible.Checked;
            chkKeepAspectRatio.Enabled = !chkAsVisible.Checked;
            chkKeepAspectRatio_CheckedChanged(sender, e);
        }

        private void menuSaveAsImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Filter = "PNG|*.png|JPG|*.jpg";
            saveFileDialog.FilterIndex = 0;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gMap.ToImage().Save(saveFileDialog.FileName);
            }
        }

        private void gMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PointLatLng coordinate = gMap.FromLocalToLatLng(e.X, e.Y);
                menuGPSposition.Text = coordinate.Lat.ToString("F4") + ", " + coordinate.Lng.ToString("F4");

                contextMenuStrip1.Show(gMap, e.Location);
            }
            else
            {
                menuTrackName.Visible = false;
                lblSelectedRoute.Text = String.Empty;
            }
        }

        private void menuGPSposition_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((ToolStripMenuItem)sender).Text);
        }

        private void btnTrackBakground_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = btnTrackBakground.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnTrackBakground.ForeColor = colorDialog.Color;
                numTrackWidth_ValueChanged(sender, e);
            }
        }

        private void btnTrackBakground2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = btnTrackBakground2.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnTrackBakground2.ForeColor = colorDialog.Color;
                numTrackWidth_ValueChanged(sender, e);
            }
        }

        private void gMap_OnRouteClick(GMapRoute item, MouseEventArgs e)
        {
            lblSelectedRoute.Text = item.Tag.ToString();
            menuTrackName.Text = item.Tag.ToString();
            menuTrackName.Visible = true;
        }

        private void cmbPlotStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateTracksPlot();
        }

        private void chkDisconnectGapPoints_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTracksPlot();
        }
    }
}
