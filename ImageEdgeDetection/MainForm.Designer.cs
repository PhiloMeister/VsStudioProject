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
            this.label1 = new System.Windows.Forms.Label();
            this.hellFilterButton = new System.Windows.Forms.Button();
            this.miamiFilterButton = new System.Windows.Forms.Button();
            this.zenFilterButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.resetButton = new System.Windows.Forms.Button();
            this.xFilterLabel = new System.Windows.Forms.Label();
            this.yFilterLabel = new System.Windows.Forms.Label();
            this.listBoxXFilter = new System.Windows.Forms.ListBox();
            this.listBoxYFilter = new System.Windows.Forms.ListBox();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.plotCoordsLabel = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonPlotCoords = new System.Windows.Forms.Button();
            this.resultImageLabel = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.applyXYFiltersButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.chartarea = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(77, 76);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(263, 175);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            this.picPreview.Click += new System.EventHandler(this.picPreview_Click);
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Location = new System.Drawing.Point(77, 257);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(58, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Location = new System.Drawing.Point(282, 257);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(58, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hellFilterButton
            // 
            this.hellFilterButton.Location = new System.Drawing.Point(430, 48);
            this.hellFilterButton.Name = "hellFilterButton";
            this.hellFilterButton.Size = new System.Drawing.Size(68, 44);
            this.hellFilterButton.TabIndex = 22;
            this.hellFilterButton.Text = "Hell Filter";
            this.hellFilterButton.UseVisualStyleBackColor = true;
            this.hellFilterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // miamiFilterButton
            // 
            this.miamiFilterButton.Location = new System.Drawing.Point(504, 48);
            this.miamiFilterButton.Name = "miamiFilterButton";
            this.miamiFilterButton.Size = new System.Drawing.Size(68, 44);
            this.miamiFilterButton.TabIndex = 23;
            this.miamiFilterButton.Text = "Miami Filter";
            this.miamiFilterButton.UseVisualStyleBackColor = true;
            this.miamiFilterButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // zenFilterButton
            // 
            this.zenFilterButton.Location = new System.Drawing.Point(578, 48);
            this.zenFilterButton.Name = "zenFilterButton";
            this.zenFilterButton.Size = new System.Drawing.Size(68, 44);
            this.zenFilterButton.TabIndex = 24;
            this.zenFilterButton.Text = "Zen Filter";
            this.zenFilterButton.UseVisualStyleBackColor = true;
            this.zenFilterButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(430, 98);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(216, 23);
            this.resetButton.TabIndex = 25;
            this.resetButton.Text = "reset all";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // xFilterLabel
            // 
            this.xFilterLabel.AutoSize = true;
            this.xFilterLabel.Location = new System.Drawing.Point(414, 146);
            this.xFilterLabel.Name = "xFilterLabel";
            this.xFilterLabel.Size = new System.Drawing.Size(52, 17);
            this.xFilterLabel.TabIndex = 26;
            this.xFilterLabel.Text = "X Filter";
            // 
            // yFilterLabel
            // 
            this.yFilterLabel.AutoSize = true;
            this.yFilterLabel.Location = new System.Drawing.Point(562, 146);
            this.yFilterLabel.Name = "yFilterLabel";
            this.yFilterLabel.Size = new System.Drawing.Size(52, 17);
            this.yFilterLabel.TabIndex = 27;
            this.yFilterLabel.Text = "Y Filter";
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
            this.listBoxXFilter.SelectedIndexChanged += new System.EventHandler(this.listBoxXFilter_SelectedIndexChanged);
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
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(414, 275);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(72, 17);
            this.thresholdLabel.TabIndex = 30;
            this.thresholdLabel.Text = "Threshold";
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
            // plotCoordsLabel
            // 
            this.plotCoordsLabel.AutoSize = true;
            this.plotCoordsLabel.Location = new System.Drawing.Point(729, 266);
            this.plotCoordsLabel.Name = "plotCoordsLabel";
            this.plotCoordsLabel.Size = new System.Drawing.Size(167, 17);
            this.plotCoordsLabel.TabIndex = 32;
            this.plotCoordsLabel.Text = "Image Green Data Points";
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
            this.textBoxData.TextChanged += new System.EventHandler(this.textBoxData_TextChanged);
            // 
            // buttonPlotCoords
            // 
            this.buttonPlotCoords.Location = new System.Drawing.Point(732, 383);
            this.buttonPlotCoords.Name = "buttonPlotCoords";
            this.buttonPlotCoords.Size = new System.Drawing.Size(264, 23);
            this.buttonPlotCoords.TabIndex = 34;
            this.buttonPlotCoords.Text = "Plot Coords";
            this.buttonPlotCoords.UseVisualStyleBackColor = true;
            this.buttonPlotCoords.Click += new System.EventHandler(this.buttonPlotCoords_Click);
            // 
            // resultImageLabel
            // 
            this.resultImageLabel.AutoSize = true;
            this.resultImageLabel.Location = new System.Drawing.Point(729, 15);
            this.resultImageLabel.Name = "resultImageLabel";
            this.resultImageLabel.Size = new System.Drawing.Size(90, 17);
            this.resultImageLabel.TabIndex = 35;
            this.resultImageLabel.Text = "Result Image";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(732, 39);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(264, 175);
            this.pictureBoxResult.TabIndex = 36;
            this.pictureBoxResult.TabStop = false;
            this.pictureBoxResult.Click += new System.EventHandler(this.pictureBoxResult_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(732, 229);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(264, 34);
            this.buttonSaveAs.TabIndex = 37;
            this.buttonSaveAs.Text = "Save the result";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Visible = false;
            // 
            // applyXYFiltersButton
            // 
            this.applyXYFiltersButton.Location = new System.Drawing.Point(471, 347);
            this.applyXYFiltersButton.Name = "applyXYFiltersButton";
            this.applyXYFiltersButton.Size = new System.Drawing.Size(172, 30);
            this.applyXYFiltersButton.TabIndex = 38;
            this.applyXYFiltersButton.Text = "Apply X / Y filters";
            this.applyXYFiltersButton.UseVisualStyleBackColor = true;
            this.applyXYFiltersButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.errorLabel.Location = new System.Drawing.Point(453, 129);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 39;
            this.errorLabel.Click += new System.EventHandler(this.label7_Click);
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
            this.chartarea.Click += new System.EventHandler(this.chartarea_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1042, 427);
            this.Controls.Add(this.chartarea);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.applyXYFiltersButton);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.resultImageLabel);
            this.Controls.Add(this.buttonPlotCoords);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.plotCoordsLabel);
            this.Controls.Add(this.trackBarThreshold);
            this.Controls.Add(this.thresholdLabel);
            this.Controls.Add(this.listBoxYFilter);
            this.Controls.Add(this.listBoxXFilter);
            this.Controls.Add(this.yFilterLabel);
            this.Controls.Add(this.xFilterLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.zenFilterButton);
            this.Controls.Add(this.miamiFilterButton);
            this.Controls.Add(this.hellFilterButton);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hellFilterButton;
        private System.Windows.Forms.Button miamiFilterButton;
        private System.Windows.Forms.Button zenFilterButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button buttonSaveAs;
        public System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label resultImageLabel;
        private System.Windows.Forms.Button buttonPlotCoords;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label plotCoordsLabel;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.ListBox listBoxYFilter;
        private System.Windows.Forms.ListBox listBoxXFilter;
        private System.Windows.Forms.Label yFilterLabel;
        private System.Windows.Forms.Label xFilterLabel;
        private System.Windows.Forms.Button applyXYFiltersButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartarea;
    }
}

