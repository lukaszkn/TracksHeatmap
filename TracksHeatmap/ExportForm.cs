using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracksHeatmap
{
    public partial class ExportForm : Form
    {
        public List<Geo.Gps.Track> Tracks;
        public GMapControl gmap;
        public int exportWidth;
        public int exportHeight;
        public string filename;
        public TracksOptimiserOptions TracksOptimiserOptions;

        private bool isMapReady = false;

        public ExportForm()
        {
            InitializeComponent();
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            double zoom = gmap.Zoom + (double)exportWidth / gmap.Size.Width;
            gMapExport.Zoom = (int)zoom;

            int ratio = Convert.ToInt32(Math.Pow(2, gMapExport.Zoom - gmap.Zoom));

            gMapExport.Size = new Size(gmap.Size.Width * ratio, gmap.Size.Height * ratio);

            TracksOptimiser tracksOptimiser = new TracksOptimiser();
            tracksOptimiser.ZoomRatio = Math.Round(zoom - gmap.Zoom, 1);
            tracksOptimiser.Run(gMapExport, this.Tracks, this.TracksOptimiserOptions);

            gMapExport.Position = gmap.Position;
            gMapExport.ScaleMode = ScaleModes.Integer;
            gMapExport.ShowCenter = false;

            gMapExport.MapProvider = gmap.MapProvider;

            gMapExport.OnTileLoadComplete += GMapExport_OnTileLoadComplete;
            timer1.Enabled = true;

            gMapExport.ReloadMap();
            gMapExport.Refresh();
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void GMapExport_OnTileLoadComplete(long ElapsedMilliseconds)
        {
            isMapReady = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMapReady)
            {
                isMapReady = false;
                ResizeImage(gMapExport.ToImage(), this.exportWidth, this.exportHeight).Save(this.filename);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
