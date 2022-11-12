/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
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
            cmbEdgeDetection.SelectedIndex = 0;
            cmbEdgeDetection.Enabled = false;
        }

        private void btnOpenOriginal_Click(object sender, EventArgs e)
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

               
                ApplyEdgeFilter();
            }
        }

        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            //testtadwda
            ApplyEdgeFilter();

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
            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

            selectedSource = filteredColoredBitmap;

            if (applyFilter != null)
            {

                filteredColoredBitmap = applyFilter;
                cmbEdgeDetection.Enabled = true;

            }

            
        }

        private void ApplyEdgeFilter()
        {
            // if no image
            if (untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;
            // the selected source is the bitmap image who has is coloFiltered
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

            ApplyEdgeFilter();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //filteredColoredBitmap = ImageFilters.ApplyFilter(new Bitmap(filteredColoredBitmap), 1, 10, 1, 1);
            ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filteredColoredBitmap), 1, 10, 1, 1));
            ApplyEdgeFilter();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filteredColoredBitmap), 1, 1, 10, 1));
            ApplyEdgeFilter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filteredColoredBitmap), 1, 1, 10, 15));
            ApplyEdgeFilter();
        }

        private void picPreview_Click(object sender, EventArgs e)
        {

        }
        //back button for filter
        //clear all filters on the picture box by giving the untouchedPreviewBitmap image
        private void button4_Click(object sender, EventArgs e)
        {
            picPreview.Image = untouchedPreviewBitmap;
            filteredColoredBitmap = untouchedPreviewBitmap;
            cmbEdgeDetection.SelectedIndex = cmbEdgeDetection.FindStringExact("None");
            cmbEdgeDetection.Enabled = false;


        }
    }
}
