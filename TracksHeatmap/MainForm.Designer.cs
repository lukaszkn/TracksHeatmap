namespace TracksHeatmap
{
    partial class MainForm
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
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuGPSposition = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSaveAsImage = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMapPoints = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbPlotStyle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCenterTracks = new System.Windows.Forms.Button();
            this.cmbMapType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxLoad = new System.Windows.Forms.GroupBox();
            this.lblTracks = new System.Windows.Forms.Label();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAsVisible = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numExportHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkKeepAspectRatio = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numExportWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPagePlotOptions = new System.Windows.Forms.TabPage();
            this.btnTrackBakground = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numTrackWidth = new System.Windows.Forms.NumericUpDown();
            this.btnTrackColor = new System.Windows.Forms.Button();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnTrackBakground2 = new System.Windows.Forms.Button();
            this.menuTrackName = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelectedRoute = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxLoad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExportHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExportWidth)).BeginInit();
            this.tabPagePlotOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackWidth)).BeginInit();
            this.tabPageInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.Margin = new System.Windows.Forms.Padding(0);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 18;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(922, 598);
            this.gMap.TabIndex = 1;
            this.gMap.Zoom = 0D;
            this.gMap.OnRouteClick += new GMap.NET.WindowsForms.RouteClick(this.gMap_OnRouteClick);
            this.gMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMap_OnMapZoomChanged);
            this.gMap.SizeChanged += new System.EventHandler(this.gMap_SizeChanged);
            this.gMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrackName,
            this.menuGPSposition,
            this.toolStripMenuItem1,
            this.menuSaveAsImage});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 76);
            // 
            // menuGPSposition
            // 
            this.menuGPSposition.Name = "menuGPSposition";
            this.menuGPSposition.Size = new System.Drawing.Size(148, 22);
            this.menuGPSposition.Text = "GPS position";
            this.menuGPSposition.Click += new System.EventHandler(this.menuGPSposition_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuSaveAsImage
            // 
            this.menuSaveAsImage.Name = "menuSaveAsImage";
            this.menuSaveAsImage.Size = new System.Drawing.Size(148, 22);
            this.menuSaveAsImage.Text = "Save as image";
            this.menuSaveAsImage.Click += new System.EventHandler(this.menuSaveAsImage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomLabel,
            this.lblMapPoints,
            this.lblSelectedRoute});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1152, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // zoomLabel
            // 
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.zoomLabel.Size = new System.Drawing.Size(77, 17);
            this.zoomLabel.Text = "Zoom: 18";
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMapPoints
            // 
            this.lblMapPoints.Name = "lblMapPoints";
            this.lblMapPoints.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblMapPoints.Size = new System.Drawing.Size(99, 17);
            this.lblMapPoints.Text = "Map points: 0";
            this.lblMapPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.Location = new System.Drawing.Point(5, 536);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(30, 30);
            this.btnZoomIn.TabIndex = 0;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(41, 536);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(30, 30);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gMap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1152, 598);
            this.splitContainer1.SplitterDistance = 922;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPagePlotOptions);
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(226, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBoxLoad);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnZoomOut);
            this.tabPage1.Controls.Add(this.btnZoomIn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(218, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Actions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPlotStyle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plot options";
            // 
            // cmbPlotStyle
            // 
            this.cmbPlotStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlotStyle.FormattingEnabled = true;
            this.cmbPlotStyle.Location = new System.Drawing.Point(38, 22);
            this.cmbPlotStyle.Name = "cmbPlotStyle";
            this.cmbPlotStyle.Size = new System.Drawing.Size(162, 21);
            this.cmbPlotStyle.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Style:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCenterTracks);
            this.groupBox2.Controls.Add(this.cmbMapType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 99);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // btnCenterTracks
            // 
            this.btnCenterTracks.Location = new System.Drawing.Point(9, 56);
            this.btnCenterTracks.Name = "btnCenterTracks";
            this.btnCenterTracks.Size = new System.Drawing.Size(191, 23);
            this.btnCenterTracks.TabIndex = 6;
            this.btnCenterTracks.Text = "Center tracks on map";
            this.btnCenterTracks.UseVisualStyleBackColor = true;
            this.btnCenterTracks.Click += new System.EventHandler(this.btnCenterTracks_Click);
            // 
            // cmbMapType
            // 
            this.cmbMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMapType.FormattingEnabled = true;
            this.cmbMapType.Location = new System.Drawing.Point(43, 19);
            this.cmbMapType.Name = "cmbMapType";
            this.cmbMapType.Size = new System.Drawing.Size(157, 21);
            this.cmbMapType.TabIndex = 5;
            this.cmbMapType.SelectedIndexChanged += new System.EventHandler(this.cmbMapType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Map:";
            // 
            // groupBoxLoad
            // 
            this.groupBoxLoad.Controls.Add(this.lblTracks);
            this.groupBoxLoad.Controls.Add(this.btnLoadFiles);
            this.groupBoxLoad.Location = new System.Drawing.Point(6, 111);
            this.groupBoxLoad.Name = "groupBoxLoad";
            this.groupBoxLoad.Size = new System.Drawing.Size(206, 78);
            this.groupBoxLoad.TabIndex = 6;
            this.groupBoxLoad.TabStop = false;
            this.groupBoxLoad.Text = "Load tracks";
            // 
            // lblTracks
            // 
            this.lblTracks.AutoSize = true;
            this.lblTracks.Location = new System.Drawing.Point(6, 55);
            this.lblTracks.Name = "lblTracks";
            this.lblTracks.Size = new System.Drawing.Size(52, 13);
            this.lblTracks.TabIndex = 1;
            this.lblTracks.Text = "Tracks: 0";
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Location = new System.Drawing.Point(9, 19);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(191, 23);
            this.btnLoadFiles.TabIndex = 0;
            this.btnLoadFiles.Text = "Load gpx files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAsVisible);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numExportHeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkKeepAspectRatio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numExportWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // chkAsVisible
            // 
            this.chkAsVisible.AutoSize = true;
            this.chkAsVisible.Location = new System.Drawing.Point(50, 18);
            this.chkAsVisible.Name = "chkAsVisible";
            this.chkAsVisible.Size = new System.Drawing.Size(98, 17);
            this.chkAsVisible.TabIndex = 10;
            this.chkAsVisible.Text = "as current view";
            this.chkAsVisible.UseVisualStyleBackColor = true;
            this.chkAsVisible.CheckedChanged += new System.EventHandler(this.chkAsVisible_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(9, 122);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(191, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export as image";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "pixels";
            // 
            // numExportHeight
            // 
            this.numExportHeight.Location = new System.Drawing.Point(50, 87);
            this.numExportHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numExportHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numExportHeight.Name = "numExportHeight";
            this.numExportHeight.Size = new System.Drawing.Size(62, 20);
            this.numExportHeight.TabIndex = 5;
            this.numExportHeight.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Height:";
            // 
            // chkKeepAspectRatio
            // 
            this.chkKeepAspectRatio.AutoSize = true;
            this.chkKeepAspectRatio.Location = new System.Drawing.Point(50, 67);
            this.chkKeepAspectRatio.Name = "chkKeepAspectRatio";
            this.chkKeepAspectRatio.Size = new System.Drawing.Size(109, 17);
            this.chkKeepAspectRatio.TabIndex = 3;
            this.chkKeepAspectRatio.Text = "Keep aspect ratio";
            this.chkKeepAspectRatio.UseVisualStyleBackColor = true;
            this.chkKeepAspectRatio.CheckedChanged += new System.EventHandler(this.chkKeepAspectRatio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "pixels";
            // 
            // numExportWidth
            // 
            this.numExportWidth.Location = new System.Drawing.Point(50, 41);
            this.numExportWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numExportWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numExportWidth.Name = "numExportWidth";
            this.numExportWidth.Size = new System.Drawing.Size(62, 20);
            this.numExportWidth.TabIndex = 1;
            this.numExportWidth.Value = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.numExportWidth.ValueChanged += new System.EventHandler(this.numExportWidth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // tabPagePlotOptions
            // 
            this.tabPagePlotOptions.Controls.Add(this.btnTrackBakground2);
            this.tabPagePlotOptions.Controls.Add(this.btnTrackBakground);
            this.tabPagePlotOptions.Controls.Add(this.label6);
            this.tabPagePlotOptions.Controls.Add(this.numTrackWidth);
            this.tabPagePlotOptions.Controls.Add(this.btnTrackColor);
            this.tabPagePlotOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlotOptions.Name = "tabPagePlotOptions";
            this.tabPagePlotOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPagePlotOptions.Size = new System.Drawing.Size(218, 572);
            this.tabPagePlotOptions.TabIndex = 2;
            this.tabPagePlotOptions.Text = "Plot options";
            this.tabPagePlotOptions.UseVisualStyleBackColor = true;
            // 
            // btnTrackBakground
            // 
            this.btnTrackBakground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(63)))));
            this.btnTrackBakground.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackBakground.ForeColor = System.Drawing.Color.Black;
            this.btnTrackBakground.Location = new System.Drawing.Point(8, 50);
            this.btnTrackBakground.Name = "btnTrackBakground";
            this.btnTrackBakground.Size = new System.Drawing.Size(197, 23);
            this.btnTrackBakground.TabIndex = 6;
            this.btnTrackBakground.Text = "Track background color";
            this.btnTrackBakground.UseVisualStyleBackColor = false;
            this.btnTrackBakground.Click += new System.EventHandler(this.btnTrackBakground_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 16);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "width:";
            // 
            // numTrackWidth
            // 
            this.numTrackWidth.Location = new System.Drawing.Point(164, 14);
            this.numTrackWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTrackWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrackWidth.Name = "numTrackWidth";
            this.numTrackWidth.Size = new System.Drawing.Size(41, 20);
            this.numTrackWidth.TabIndex = 4;
            this.numTrackWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrackWidth.ValueChanged += new System.EventHandler(this.numTrackWidth_ValueChanged);
            // 
            // btnTrackColor
            // 
            this.btnTrackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackColor.ForeColor = System.Drawing.Color.Red;
            this.btnTrackColor.Location = new System.Drawing.Point(8, 11);
            this.btnTrackColor.Name = "btnTrackColor";
            this.btnTrackColor.Size = new System.Drawing.Size(99, 23);
            this.btnTrackColor.TabIndex = 3;
            this.btnTrackColor.Text = "Track color";
            this.btnTrackColor.UseVisualStyleBackColor = true;
            this.btnTrackColor.Click += new System.EventHandler(this.btnTrackColor_Click);
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.txtInfo);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(218, 572);
            this.tabPageInfo.TabIndex = 1;
            this.tabPageInfo.Text = "Info";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Location = new System.Drawing.Point(3, 3);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(212, 566);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "Load tracks first...";
            // 
            // btnTrackBakground2
            // 
            this.btnTrackBakground2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(124)))), ((int)(((byte)(34)))));
            this.btnTrackBakground2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackBakground2.ForeColor = System.Drawing.Color.Black;
            this.btnTrackBakground2.Location = new System.Drawing.Point(8, 79);
            this.btnTrackBakground2.Name = "btnTrackBakground2";
            this.btnTrackBakground2.Size = new System.Drawing.Size(197, 23);
            this.btnTrackBakground2.TabIndex = 7;
            this.btnTrackBakground2.Text = "Track background color";
            this.btnTrackBakground2.UseVisualStyleBackColor = false;
            this.btnTrackBakground2.Click += new System.EventHandler(this.btnTrackBakground2_Click);
            // 
            // menuTrackName
            // 
            this.menuTrackName.Name = "menuTrackName";
            this.menuTrackName.Size = new System.Drawing.Size(148, 22);
            this.menuTrackName.Text = "Track name";
            // 
            // lblSelectedRoute
            // 
            this.lblSelectedRoute.Name = "lblSelectedRoute";
            this.lblSelectedRoute.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblSelectedRoute.Size = new System.Drawing.Size(20, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 620);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Tracks heatmap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxLoad.ResumeLayout(false);
            this.groupBoxLoad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExportHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExportWidth)).EndInit();
            this.tabPagePlotOptions.ResumeLayout(false);
            this.tabPagePlotOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackWidth)).EndInit();
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel zoomLabel;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numExportHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkKeepAspectRatio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numExportWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMapType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxLoad;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTracks;
        private System.Windows.Forms.ToolStripStatusLabel lblMapPoints;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCenterTracks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbPlotStyle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAsVisible;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAsImage;
        private System.Windows.Forms.TabPage tabPagePlotOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTrackWidth;
        private System.Windows.Forms.Button btnTrackColor;
        private System.Windows.Forms.ToolStripMenuItem menuGPSposition;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button btnTrackBakground;
        private System.Windows.Forms.Button btnTrackBakground2;
        private System.Windows.Forms.ToolStripMenuItem menuTrackName;
        private System.Windows.Forms.ToolStripStatusLabel lblSelectedRoute;
    }
}

