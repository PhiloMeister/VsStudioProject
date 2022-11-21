/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using PictureBox.Image.Testes;

namespace ImageEdgeDetection
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap untouchedPreviewBitmap = null;
        private Bitmap resultBitmap = null;
        private Bitmap filteredColoredBitmap = null;
      

        public MainForm()
        {
            InitializeComponent();
            //combo box for the edge detection
            cmbEdgeDetection.SelectedIndex = 0;
            cmbEdgeDetection.Enabled = false;
            //list box for the X algo detection
            listBoxXFilter.SelectedIndex = 0;
            //list box for the Y algo detection
            listBoxYFilter.SelectedIndex = 0;
            btnSaveNewImage.Enabled = false;
            btnHellFilter.Enabled = false;
            btnMiamiFilter.Enabled = false;
            btnZenFilter.Enabled = false;
            btnResetFilters.Enabled = false;
            listBoxXFilter.Enabled = false;
            listBoxYFilter.Enabled = false;
            trackBarThreshold.Enabled = false;
            btnApplyXYFilters.Enabled = false;
            btnPlotCoords.Enabled = false;
        }

        private void BtnOpenOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Get the image into the original bitmap
                //The original bitmap is not dimensioned for our square
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();
                //PreviewBitmap is like the original one but redimensioned for our square
                //PicPreview is the PICTUREBOX
                untouchedPreviewBitmap = originalBitmap.CopyToSquareCanvas(picPreview.Width);
                //We give the redimensioned image to the square
                filteredColoredBitmap = untouchedPreviewBitmap;
                picPreview.Image = filteredColoredBitmap;
                UpdateComponentImagechoosenSuccess();
            }
        }

        private void UpdateComponentImagechoosenSuccess()
        {
            btnSaveNewImage.Enabled = true;
            btnHellFilter.Enabled = true;
            btnMiamiFilter.Enabled = true;
            btnZenFilter.Enabled = true;
            btnResetFilters.Enabled = true;
        }

        private void BtnSaveNewImage_Click(object sender, EventArgs e)
        {
           
            //ApplyEdgeFilter();

            if (resultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    // clean and close the streamWriter
                    streamWriter.Flush();
                    streamWriter.Close();

                    resultBitmap = null;
                }
            }
        }
        private void ApplyColorFilter(Bitmap applyFilter)
        {
          
            // if no image
            if (untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }
          
            // if a filter is applied, make the image edge detection parameters available
            if (applyFilter != null)
            {
                filteredColoredBitmap = applyFilter;

                UpdateComponentFilterApplied();
            }

            
        }

        // make image edge detection parameters available
        private void UpdateComponentFilterApplied()
        {
            cmbEdgeDetection.Enabled = true;
            listBoxXFilter.Enabled = true;
            listBoxYFilter.Enabled = true;
            trackBarThreshold.Enabled = true;
            btnApplyXYFilters.Enabled = true;
            btnPlotCoords.Enabled = true;
        }

        private void ApplyEdgeFilter(Bitmap untouchedPreviewBitmap)
        {
            // if no image
            if (untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;
            // the selected source is the bitmap image that has is coloFiltered
            selectedSource = filteredColoredBitmap;
                
            
            if (selectedSource != null)
            {
                if (cmbEdgeDetection.SelectedItem.ToString() == "None")
                {
                    bitmapResult = selectedSource;
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian3x3Filter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 Grayscale")
                {
                    bitmapResult = selectedSource.Laplacian3x3Filter(true);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5")
                {
                    bitmapResult = selectedSource.Laplacian5x5Filter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 Grayscale")
                {
                    bitmapResult = selectedSource.Laplacian5x5Filter(true);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian of Gaussian")
                {
                    bitmapResult = selectedSource.LaplacianOfGaussianFilter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 5x5 - 1")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian5x5Filter1();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 5x5 - 2")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian5x5Filter2();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 5x5 - 1")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian5x5Filter1();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 5x5 - 2")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian5x5Filter2();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Sobel 3x3")
                {
                    bitmapResult = selectedSource.Sobel3x3Filter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Sobel 3x3 Grayscale")
                {
                    bitmapResult = selectedSource.Sobel3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Prewitt")
                {
                    bitmapResult = selectedSource.PrewittFilter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Prewitt Grayscale")
                {
                    bitmapResult = selectedSource.PrewittFilter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Kirsch")
                {
                    bitmapResult = selectedSource.KirschFilter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Kirsch Grayscale")
                {
                    bitmapResult = selectedSource.KirschFilter();
                }
            }

            if (bitmapResult != null)
            {
                picPreview.Image = bitmapResult;
                    resultBitmap = bitmapResult;
            }
        }

        private void NeighbourCountValueChangedEventHandler(object sender, EventArgs e)
        {
            ApplyEdgeFilter(filteredColoredBitmap);
        }

        private void BtnZenFilter_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filteredColoredBitmap), 1, 10, 1, 1));
            ApplyEdgeFilter(filteredColoredBitmap);
        }

        

        private void BtnMiamiFilter_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filteredColoredBitmap), 1, 1, 10, 1));
            ApplyEdgeFilter(filteredColoredBitmap);
        }

        private void BtnHellFilter_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filteredColoredBitmap), 1, 1, 10, 15));
            ApplyEdgeFilter(filteredColoredBitmap);
        }

        //back button for filter
        //clear all filters on the picture box by giving the untouchedPreviewBitmap image
        private void BtnResetFilters_Click(object sender, EventArgs e)
        {
            picPreview.Image = untouchedPreviewBitmap;
            filteredColoredBitmap = untouchedPreviewBitmap;
            cmbEdgeDetection.SelectedIndex = cmbEdgeDetection.FindStringExact("None");
            cmbEdgeDetection.Enabled = false;
            listBoxXFilter.Enabled = false;
            listBoxYFilter.Enabled = false;
            trackBarThreshold.Enabled = false;
            btnApplyXYFilters.Enabled = false;
            btnPlotCoords.Enabled = false;

            pictureBoxResult.Image = null;
            textBoxData.Text = "";

        }
        //apply x y filters button
        private void BtnApplyXYFilters_Click(object sender, EventArgs e)
        {   
            // Both X and Y filters must be selected
            if (listBoxXFilter.SelectedItem.ToString().Length > 0 && listBoxYFilter.SelectedItem.ToString().Length > 0)
            {
                Filter(listBoxXFilter.SelectedItem.ToString(), listBoxYFilter.SelectedItem.ToString());
                // pic preview took the filteredcoloredBitmap
                ConvertToXYCoord(filteredColoredBitmap);
                labelError.Text = "";
            }
            else //if the 2 filters are not selected
            {
                labelError.Text = "2 filters must be selected";
            }
        }


        public void ConvertToXYCoord(Bitmap pictureBoxelem)
        {
            string coord = "";
            int width = pictureBoxelem.Width;
            int height = pictureBoxelem.Height;
            Size size = new Size(width, height);
            Bitmap bitmapIMG = new Bitmap(pictureBoxResult.Image, width, height);

            List<Coord> coorArray = new List<Coord>();

            int x = 0;
            int y = 0;
            double newX;
            double newY;

            for (x = 0; x < width; x++)
            {
                for (y = 0; y < height; y++)
                {
                    Color pixelColor = Color.FromArgb(bitmapIMG.GetPixel(x, y).ToArgb());
                    if (pixelColor.Name != "ff000000" && pixelColor.Name != "0")
                    {

                        newX = Convert.ToDouble(x);
                        newY = Convert.ToDouble(y);
                        int angle = 110;

                        //Rotate
                        newX = newX * Math.Cos(angle) - newY * Math.Sin(angle);
                        newY = newX * Math.Sin(angle) + newY * Math.Cos(angle);

                        coord = coord + newX.ToString() + "," + newY.ToString() + "|";
                    }
                }
            }
            textBoxData.Text = coord;


        }

        //Convert the image by applying the selected X and Y filters
        public void Filter(string xfilter, string yfilter)
        {
            double[,] xFilterMatrix;
            double[,] yFilterMatrix;
            switch (xfilter)
            {
                case "Laplacian3x3":
                    xFilterMatrix = FilterMatrix.Laplacian3x3;
                    break;
                case "Laplacian5x5":
                    xFilterMatrix = FilterMatrix.Laplacian5x5;
                    break;
                case "LaplacianOfGaussian":
                    xFilterMatrix = FilterMatrix.LaplacianOfGaussian;
                    break;
                case "Gaussian3x3":
                    xFilterMatrix = FilterMatrix.Gaussian3x3;
                    break;
                case "Gaussian5x5Type1":
                    xFilterMatrix = FilterMatrix.Gaussian5x5Type1;
                    break;
                case "Gaussian5x5Type2":
                    xFilterMatrix = FilterMatrix.Gaussian5x5Type2;
                    break;
                case "Sobel3x3Horizontal":
                    xFilterMatrix = FilterMatrix.Sobel3x3Horizontal;
                    break;
                case "Sobel3x3Vertical":
                    xFilterMatrix = FilterMatrix.Sobel3x3Vertical;
                    break;
                case "Prewitt3x3Horizontal":
                    xFilterMatrix = FilterMatrix.Prewitt3x3Horizontal;
                    break;
                case "Prewitt3x3Vertical":
                    xFilterMatrix = FilterMatrix.Prewitt3x3Vertical;
                    break;
                case "Kirsch3x3Horizontal":
                    xFilterMatrix = FilterMatrix.Kirsch3x3Horizontal;
                    break;
                case "Kirsch3x3Vertical":
                    xFilterMatrix = FilterMatrix.Kirsch3x3Vertical;
                    break;
                default:
                    xFilterMatrix = FilterMatrix.Laplacian3x3;
                    break;
            }

            switch (yfilter)
            {
                case "Laplacian3x3":
                    yFilterMatrix = FilterMatrix.Laplacian3x3;
                    break;
                case "Laplacian5x5":
                    yFilterMatrix = FilterMatrix.Laplacian5x5;
                    break;
                case "LaplacianOfGaussian":
                    yFilterMatrix = FilterMatrix.LaplacianOfGaussian;
                    break;
                case "Gaussian3x3":
                    yFilterMatrix = FilterMatrix.Gaussian3x3;
                    break;
                case "Gaussian5x5Type1":
                    yFilterMatrix = FilterMatrix.Gaussian5x5Type1;
                    break;
                case "Gaussian5x5Type2":
                    yFilterMatrix = FilterMatrix.Gaussian5x5Type2;
                    break;
                case "Sobel3x3Horizontal":
                    yFilterMatrix = FilterMatrix.Sobel3x3Horizontal;
                    break;
                case "Sobel3x3Vertical":
                    yFilterMatrix = FilterMatrix.Sobel3x3Vertical;
                    break;
                case "Prewitt3x3Horizontal":
                    yFilterMatrix = FilterMatrix.Prewitt3x3Horizontal;
                    break;
                case "Prewitt3x3Vertical":
                    yFilterMatrix = FilterMatrix.Prewitt3x3Vertical;
                    break;
                case "Kirsch3x3Horizontal":
                    yFilterMatrix = FilterMatrix.Kirsch3x3Horizontal;
                    break;
                case "Kirsch3x3Vertical":
                    yFilterMatrix = FilterMatrix.Kirsch3x3Vertical;
                    break;
                default:
                    yFilterMatrix = FilterMatrix.Laplacian3x3;
                    break;
            }



            if (filteredColoredBitmap.Size.Height > 0)
            {
                Bitmap newbitmap = new Bitmap(filteredColoredBitmap);
                BitmapData newbitmapData = new BitmapData();
                newbitmapData = newbitmap.LockBits(new Rectangle(0, 0, newbitmap.Width, newbitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);

                byte[] pixelbuff = new byte[newbitmapData.Stride * newbitmapData.Height];
                byte[] resultbuff = new byte[newbitmapData.Stride * newbitmapData.Height];

                Marshal.Copy(newbitmapData.Scan0, pixelbuff, 0, pixelbuff.Length);
                newbitmap.UnlockBits(newbitmapData);

                double blueX = 0.0;
                double greenX = 0.0;
                double redX = 0.0;

                double blueY = 0.0;
                double greenY = 0.0;
                double redY = 0.0;

                double blueTotal = 0.0;
                double greenTotal = 0.0;
                double redTotal = 0.0;

                int filterOffset = 1;
                int calcOffset = 0;

                int byteOffset = 0;

                for (int offsetY = filterOffset; offsetY <
                    newbitmap.Height - filterOffset; offsetY++)
                {
                    for (int offsetX = filterOffset; offsetX <
                        newbitmap.Width - filterOffset; offsetX++)
                    {
                        blueX = greenX = redX = 0.0;
                        blueY = greenY = redY = 0.0;

                        blueTotal = greenTotal = redTotal = 0.0;

                        byteOffset = offsetY *
                                     newbitmapData.Stride +
                                     offsetX * 4;

                        for (int filterY = -filterOffset;
                            filterY <= filterOffset; filterY++)
                        {
                            for (int filterX = -filterOffset;
                                filterX <= filterOffset; filterX++)
                            {
                                calcOffset = byteOffset +
                                             (filterX * 4) +
                                             (filterY * newbitmapData.Stride);

                                blueX += (double)(pixelbuff[calcOffset]) *
                                          xFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                greenX += (double)(pixelbuff[calcOffset + 1]) *
                                          xFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                redX += (double)(pixelbuff[calcOffset + 2]) *
                                          xFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                blueY += (double)(pixelbuff[calcOffset]) *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                greenY += (double)(pixelbuff[calcOffset + 1]) *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                redY += (double)(pixelbuff[calcOffset + 2]) *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];
                            }
                        }

                        blueTotal = 0.0;
                        greenTotal = Math.Sqrt((greenX * greenX) + (greenY * greenY));
                        redTotal = 0.0;

                        if (blueTotal > 255)
                        { blueTotal = 255; }
                        else if (blueTotal < 0)
                        { blueTotal = 0; }

                        if (greenTotal > 255)
                        { greenTotal = 255; }
                        else if (greenTotal < 0)
                        { greenTotal = 0; }

                        try
                        {
                            if (greenTotal < Convert.ToInt32(trackBarThreshold.Value))
                            {
                                greenTotal = 0.0;
                            }
                            else
                            {
                                greenTotal = 255;
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }


                        if (redTotal > 255)
                        { redTotal = 255; }
                        else if (redTotal < 0)
                        { redTotal = 0.0; }

                        resultbuff[byteOffset] = (byte)(blueTotal);
                        resultbuff[byteOffset + 1] = (byte)(greenTotal);
                        resultbuff[byteOffset + 2] = (byte)(redTotal);
                        resultbuff[byteOffset + 3] = 255;
                    }
                }

                Bitmap resultbitmap = new Bitmap(newbitmap.Width, newbitmap.Height);

                BitmapData resultData = resultbitmap.LockBits(new Rectangle(0, 0,
                                         resultbitmap.Width, resultbitmap.Height),
                                                          ImageLockMode.WriteOnly,
                                                      PixelFormat.Format32bppArgb);

                Marshal.Copy(resultbuff, 0, resultData.Scan0, resultbuff.Length);
                resultbitmap.UnlockBits(resultData);
                pictureBoxResult.Image = resultbitmap;
            }
            else
            {
                labelError.Text = "You must load an image";              
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chartarea.Series.Add("plot");
            chartarea.Series["plot"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chartarea.Visible = false;

        }

        private void BtnPlotCoords_Click(object sender, EventArgs e)
        
        {
                chartarea.Series["plot"].Points.Clear();
                
                if (textBoxData.Text.Length > 1)
                {
                    chartarea.Visible = true;
                    chartarea.Width = 500;
                    chartarea.Height = 400;

                    Button Close = new Button();
                    Close.Click += new System.EventHandler(Close_Click);
                    Close.BackColor = System.Drawing.Color.LightGray;
                    Close.Text = "Close";
                    chartarea.Controls.Add(Close);

                    string[] coords = textBoxData.Text.Split('|');
                    for (int i = 0; i < coords.Length; i++)
                    {
                        if (coords[i] != "")
                        {
                            double newX = Convert.ToDouble(coords[i].Split(',')[0]);
                            double newY = Convert.ToDouble(coords[i].Split(',')[1]);

                            chartarea.Series["plot"].Points.AddXY(newX, newY);
                        }
                    }
                }         
        }

        private void Close_Click(object sender, EventArgs e)
        {
            chartarea.Visible = false;
        }

    }
}
