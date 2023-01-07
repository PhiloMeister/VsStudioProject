namespace ImageEdgeDetection
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.cmbEdgeDetection = new System.Windows.Forms.ComboBox();
            this.labelFilters = new System.Windows.Forms.Label();
            this.btnHellFilter = new System.Windows.Forms.Button();
            this.btnMiamiFilter = new System.Windows.Forms.Button();
            this.btnZenFilter = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.labelXFilter = new System.Windows.Forms.Label();
            this.labelYFilter = new System.Windows.Forms.Label();
            this.listBoxXFilter = new System.Windows.Forms.ListBox();
            this.listBoxYFilter = new System.Windows.Forms.ListBox();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.labelPlotCoords = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.btnPlotCoords = new System.Windows.Forms.Button();
            this.labelResultImage = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnApplyXYFilters = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.chartarea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnNoColorFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartarea)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(77, 76);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(263, 175);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Location = new System.Drawing.Point(77, 257);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(58, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.BtnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Location = new System.Drawing.Point(282, 257);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(58, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.BtnSaveNewImage_Click);
            // 
            // cmbEdgeDetection
            // 
            this.cmbEdgeDetection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdgeDetection.FormattingEnabled = true;
            this.cmbEdgeDetection.Items.AddRange(new object[] {
            "None",
            "Laplacian 3x3",
            "Laplacian 3x3 Grayscale",
            "Laplacian 5x5",
            "Laplacian 5x5 Grayscale",
            "Laplacian of Gaussian",
            "Laplacian 3x3 of Gaussian 3x3",
            "Laplacian 3x3 of Gaussian 5x5 - 1",
            "Laplacian 3x3 of Gaussian 5x5 - 2",
            "Laplacian 5x5 of Gaussian 3x3",
            "Laplacian 5x5 of Gaussian 5x5 - 1",
            "Laplacian 5x5 of Gaussian 5x5 - 2",
            "Sobel 3x3",
            "Sobel 3x3 Grayscale",
            "Prewitt",
            "Prewitt Grayscale",
            "Kirsch",
            "Kirsch Grayscale"});
            this.cmbEdgeDetection.Location = new System.Drawing.Point(141, 263);
            this.cmbEdgeDetection.Name = "cmbEdgeDetection";
            this.cmbEdgeDetection.Size = new System.Drawing.Size(135, 24);
            this.cmbEdgeDetection.TabIndex = 20;
            this.cmbEdgeDetection.SelectedIndexChanged += new System.EventHandler(this.NeighbourCountValueChangedEventHandler);
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Location = new System.Drawing.Point(427, 15);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(46, 17);
            this.labelFilters.TabIndex = 21;
            this.labelFilters.Text = "Filters";
            // 
            // btnHellFilter
            // 
            this.btnHellFilter.Location = new System.Drawing.Point(430, 48);
            this.btnHellFilter.Name = "btnHellFilter";
            this.btnHellFilter.Size = new System.Drawing.Size(68, 44);
            this.btnHellFilter.TabIndex = 22;
            this.btnHellFilter.Text = "Hell Filter";
            this.btnHellFilter.UseVisualStyleBackColor = true;
            this.btnHellFilter.Click += new System.EventHandler(this.BtnHellFilter_Click);
            // 
            // btnMiamiFilter
            // 
            this.btnMiamiFilter.Location = new System.Drawing.Point(504, 48);
            this.btnMiamiFilter.Name = "btnMiamiFilter";
            this.btnMiamiFilter.Size = new System.Drawing.Size(68, 44);
            this.btnMiamiFilter.TabIndex = 23;
            this.btnMiamiFilter.Text = "Miami Filter";
            this.btnMiamiFilter.UseVisualStyleBackColor = true;
            this.btnMiamiFilter.Click += new System.EventHandler(this.BtnMiamiFilter_Click);
            // 
            // btnZenFilter
            // 
            this.btnZenFilter.Location = new System.Drawing.Point(578, 48);
            this.btnZenFilter.Name = "btnZenFilter";
            this.btnZenFilter.Size = new System.Drawing.Size(68, 44);
            this.btnZenFilter.TabIndex = 24;
            this.btnZenFilter.Text = "Zen Filter";
            this.btnZenFilter.UseVisualStyleBackColor = true;
            this.btnZenFilter.Click += new System.EventHandler(this.BtnZenFilter_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(430, 98);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(216, 23);
            this.btnResetFilters.TabIndex = 25;
            this.btnResetFilters.Text = "reset all";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.BtnResetFilters_Click);
            // 
            // labelXFilter
            // 
            this.labelXFilter.AutoSize = true;
            this.labelXFilter.Location = new System.Drawing.Point(414, 146);
            this.labelXFilter.Name = "labelXFilter";
            this.labelXFilter.Size = new System.Drawing.Size(52, 17);
            this.labelXFilter.TabIndex = 26;
            this.labelXFilter.Text = "X Filter";
            // 
            // labelYFilter
            // 
            this.labelYFilter.AutoSize = true;
            this.labelYFilter.Location = new System.Drawing.Point(562, 146);
            this.labelYFilter.Name = "labelYFilter";
            this.labelYFilter.Size = new System.Drawing.Size(52, 17);
            this.labelYFilter.TabIndex = 27;
            this.labelYFilter.Text = "Y Filter";
            // 
            // listBoxXFilter
            // 
            this.listBoxXFilter.FormattingEnabled = true;
            this.listBoxXFilter.ItemHeight = 16;
            this.listBoxXFilter.Items.AddRange(new object[] {
            "",
            "Laplacian3x3",
            "Laplacian5x5",
            "Sobel3x3Horizontal",
            "Sobel3x3Vertical",
            "Prewitt3x3Horizontal",
            "Prewitt3x3Vertical",
            "Kirsch3x3Horizontal",
            "Kirsch3x3Vertical"});
            this.listBoxXFilter.Location = new System.Drawing.Point(417, 177);
            this.listBoxXFilter.Name = "listBoxXFilter";
            this.listBoxXFilter.Size = new System.Drawing.Size(120, 84);
            this.listBoxXFilter.TabIndex = 28;
            // 
            // listBoxYFilter
            // 
            this.listBoxYFilter.FormattingEnabled = true;
            this.listBoxYFilter.ItemHeight = 16;
            this.listBoxYFilter.Items.AddRange(new object[] {
            "",
            "Laplacian3x3",
            "Laplacian5x5",
            "Sobel3x3Horizontal",
            "Sobel3x3Vertical",
            "Prewitt3x3Horizontal",
            "Prewitt3x3Vertical",
            "Kirsch3x3Horizontal",
            "Kirsch3x3Vertical"});
            this.listBoxYFilter.Location = new System.Drawing.Point(565, 177);
            this.listBoxYFilter.Name = "listBoxYFilter";
            this.listBoxYFilter.Size = new System.Drawing.Size(120, 84);
            this.listBoxYFilter.TabIndex = 29;
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Location = new System.Drawing.Point(414, 275);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(72, 17);
            this.labelThreshold.TabIndex = 30;
            this.labelThreshold.Text = "Threshold";
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.LargeChange = 10;
            this.trackBarThreshold.Location = new System.Drawing.Point(400, 295);
            this.trackBarThreshold.Maximum = 255;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(313, 56);
            this.trackBarThreshold.TabIndex = 31;
            this.trackBarThreshold.Value = 100;
            // 
            // labelPlotCoords
            // 
            this.labelPlotCoords.AutoSize = true;
            this.labelPlotCoords.Location = new System.Drawing.Point(729, 266);
            this.labelPlotCoords.Name = "labelPlotCoords";
            this.labelPlotCoords.Size = new System.Drawing.Size(167, 17);
            this.labelPlotCoords.TabIndex = 32;
            this.labelPlotCoords.Text = "Image Green Data Points";
            // 
            // textBoxData
            // 
            this.textBoxData.AcceptsReturn = true;
            this.textBoxData.AcceptsTab = true;
            this.textBoxData.Location = new System.Drawing.Point(732, 295);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(264, 82);
            this.textBoxData.TabIndex = 33;
            this.textBoxData.TabStop = false;
            // 
            // btnPlotCoords
            // 
            this.btnPlotCoords.Location = new System.Drawing.Point(732, 383);
            this.btnPlotCoords.Name = "btnPlotCoords";
            this.btnPlotCoords.Size = new System.Drawing.Size(264, 23);
            this.btnPlotCoords.TabIndex = 34;
            this.btnPlotCoords.Text = "Plot Coords";
            this.btnPlotCoords.UseVisualStyleBackColor = true;
            this.btnPlotCoords.Click += new System.EventHandler(this.BtnPlotCoords_Click);
            // 
            // labelResultImage
            // 
            this.labelResultImage.AutoSize = true;
            this.labelResultImage.Location = new System.Drawing.Point(729, 15);
            this.labelResultImage.Name = "labelResultImage";
            this.labelResultImage.Size = new System.Drawing.Size(90, 17);
            this.labelResultImage.TabIndex = 35;
            this.labelResultImage.Text = "Result Image";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(732, 39);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(264, 175);
            this.pictureBoxResult.TabIndex = 36;
            this.pictureBoxResult.TabStop = false;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(732, 229);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(264, 34);
            this.btnSaveAs.TabIndex = 37;
            this.btnSaveAs.Text = "Save the result";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Visible = false;
            // 
            // btnApplyXYFilters
            // 
            this.btnApplyXYFilters.Location = new System.Drawing.Point(471, 347);
            this.btnApplyXYFilters.Name = "btnApplyXYFilters";
            this.btnApplyXYFilters.Size = new System.Drawing.Size(172, 30);
            this.btnApplyXYFilters.TabIndex = 38;
            this.btnApplyXYFilters.Text = "Apply X / Y filters";
            this.btnApplyXYFilters.UseVisualStyleBackColor = true;
            this.btnApplyXYFilters.Click += new System.EventHandler(this.BtnApplyXYFilters_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Crimson;
            this.labelError.Location = new System.Drawing.Point(453, 129);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 39;
            // 
            // chartarea
            // 
            chartArea1.Name = "ChartArea1";
            this.chartarea.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartarea.Legends.Add(legend1);
            this.chartarea.Location = new System.Drawing.Point(30, 15);
            this.chartarea.Name = "chartarea";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartarea.Series.Add(series1);
            this.chartarea.Size = new System.Drawing.Size(378, 319);
            this.chartarea.TabIndex = 40;
            this.chartarea.Text = "chartarea";
            // 
            // btnNoColorFilter
            // 
            this.btnNoColorFilter.Location = new System.Drawing.Point(504, 15);
            this.btnNoColorFilter.Name = "No filters";
            this.btnNoColorFilter.Size = new System.Drawing.Size(142, 27);
            this.btnNoColorFilter.TabIndex = 41;
            this.btnNoColorFilter.Text = "No filters";
            this.btnNoColorFilter.UseVisualStyleBackColor = true;
            this.btnNoColorFilter.Click += new System.EventHandler(this.btnNoColorFilter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1042, 427);
            this.Controls.Add(this.btnNoColorFilter);
            this.Controls.Add(this.chartarea);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnApplyXYFilters);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.labelResultImage);
            this.Controls.Add(this.btnPlotCoords);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelPlotCoords);
            this.Controls.Add(this.trackBarThreshold);
            this.Controls.Add(this.labelThreshold);
            this.Controls.Add(this.listBoxYFilter);
            this.Controls.Add(this.listBoxXFilter);
            this.Controls.Add(this.labelYFilter);
            this.Controls.Add(this.labelXFilter);
            this.Controls.Add(this.btnResetFilters);
            this.Controls.Add(this.btnZenFilter);
            this.Controls.Add(this.btnMiamiFilter);
            this.Controls.Add(this.btnHellFilter);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.cmbEdgeDetection);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Edge Detection";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartarea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbEdgeDetection;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Button btnHellFilter;
        private System.Windows.Forms.Button btnMiamiFilter;
        private System.Windows.Forms.Button btnZenFilter;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnSaveAs;
        public System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label labelResultImage;
        private System.Windows.Forms.Button btnPlotCoords;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label labelPlotCoords;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.ListBox listBoxYFilter;
        private System.Windows.Forms.ListBox listBoxXFilter;
        private System.Windows.Forms.Label labelYFilter;
        private System.Windows.Forms.Label labelXFilter;
        private System.Windows.Forms.Button btnApplyXYFilters;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartarea;
        private System.Windows.Forms.Button btnNoColorFilter;
    }
}

