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
            this.labelError = new System.Windows.Forms.Label();
            this.btnNoColorFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(263, 175);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Location = new System.Drawing.Point(12, 193);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(58, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.BtnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Location = new System.Drawing.Point(217, 193);
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
            this.cmbEdgeDetection.Location = new System.Drawing.Point(76, 199);
            this.cmbEdgeDetection.Name = "cmbEdgeDetection";
            this.cmbEdgeDetection.Size = new System.Drawing.Size(135, 24);
            this.cmbEdgeDetection.TabIndex = 20;
            this.cmbEdgeDetection.SelectedIndexChanged += new System.EventHandler(this.NeighbourCountValueChangedEventHandler);
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Location = new System.Drawing.Point(281, 15);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(46, 17);
            this.labelFilters.TabIndex = 21;
            this.labelFilters.Text = "Filters";
            // 
            // btnHellFilter
            // 
            this.btnHellFilter.Location = new System.Drawing.Point(284, 48);
            this.btnHellFilter.Name = "btnHellFilter";
            this.btnHellFilter.Size = new System.Drawing.Size(68, 44);
            this.btnHellFilter.TabIndex = 22;
            this.btnHellFilter.Text = "Hell Filter";
            this.btnHellFilter.UseVisualStyleBackColor = true;
            this.btnHellFilter.Click += new System.EventHandler(this.BtnHellFilter_Click);
            // 
            // btnMiamiFilter
            // 
            this.btnMiamiFilter.Location = new System.Drawing.Point(358, 48);
            this.btnMiamiFilter.Name = "btnMiamiFilter";
            this.btnMiamiFilter.Size = new System.Drawing.Size(68, 44);
            this.btnMiamiFilter.TabIndex = 23;
            this.btnMiamiFilter.Text = "Miami Filter";
            this.btnMiamiFilter.UseVisualStyleBackColor = true;
            this.btnMiamiFilter.Click += new System.EventHandler(this.BtnMiamiFilter_Click);
            // 
            // btnZenFilter
            // 
            this.btnZenFilter.Location = new System.Drawing.Point(432, 48);
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
            this.btnResetFilters.Location = new System.Drawing.Point(284, 98);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(216, 23);
            this.btnResetFilters.TabIndex = 25;
            this.btnResetFilters.Text = "reset all";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.BtnResetFilters_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Crimson;
            this.labelError.Location = new System.Drawing.Point(307, 129);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 39;
            // 
            // btnNoColorFilter
            // 
            this.btnNoColorFilter.Location = new System.Drawing.Point(358, 15);
            this.btnNoColorFilter.Name = "btnNoColorFilter";
            this.btnNoColorFilter.Size = new System.Drawing.Size(142, 27);
            this.btnNoColorFilter.TabIndex = 41;
            this.btnNoColorFilter.Text = "No filters";
            this.btnNoColorFilter.UseVisualStyleBackColor = true;
            this.btnNoColorFilter.Click += new System.EventHandler(this.btnNoColorFilter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(533, 253);
            this.Controls.Add(this.btnNoColorFilter);
            this.Controls.Add(this.labelError);
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
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnNoColorFilter;
    }
}

