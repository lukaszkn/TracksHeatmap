namespace TracksHeatmap
{
    partial class ExportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gMapExport = new GMap.NET.WindowsForms.GMapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapExport
            // 
            this.gMapExport.Bearing = 0F;
            this.gMapExport.CanDragMap = true;
            this.gMapExport.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapExport.GrayScaleMode = false;
            this.gMapExport.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapExport.LevelsKeepInMemmory = 5;
            this.gMapExport.Location = new System.Drawing.Point(0, 0);
            this.gMapExport.MarkersEnabled = true;
            this.gMapExport.MaxZoom = 30;
            this.gMapExport.MinZoom = 2;
            this.gMapExport.MouseWheelZoomEnabled = true;
            this.gMapExport.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapExport.Name = "gMapExport";
            this.gMapExport.NegativeMode = false;
            this.gMapExport.PolygonsEnabled = true;
            this.gMapExport.RetryLoadTile = 0;
            this.gMapExport.RoutesEnabled = true;
            this.gMapExport.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapExport.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapExport.ShowTileGridLines = false;
            this.gMapExport.Size = new System.Drawing.Size(150, 150);
            this.gMapExport.TabIndex = 0;
            this.gMapExport.Zoom = 0D;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 123);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 123);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exporting...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 124);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExportForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ExportForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapExport;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}