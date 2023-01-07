/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using ImageEdgeDetection.Controllers;
using PictureBox.Image.Testes;
using PictureBox = System.Windows.Forms.PictureBox;

namespace ImageEdgeDetection
{
    public partial class MainForm : Form
    {
        Filters filters = new Filters();

        public MainForm()
        {
            InitializeComponent();
            //combo box for the edge detection
            cmbEdgeDetection.SelectedIndex = 0;
            cmbEdgeDetection.Enabled = false;
            //list box for the X algo detection
         
            btnSaveNewImage.Enabled = false;
            btnHellFilter.Enabled = false;
            btnNoColorFilter.Enabled = false;
            btnMiamiFilter.Enabled = false;
            btnZenFilter.Enabled = false;
            btnResetFilters.Enabled = false;
        
        }

        private void BtnOpenOriginal_Click(object sender, EventArgs e)
        {
            filters.openImageDialog(picPreview);
            UpdateComponentImagechoosenSuccess();
        }
        private void BtnSaveNewImage_Click(object sender, EventArgs e)
        {
           filters.BtnSaveNewImage_Click();
        }

        public void UpdateComponentImagechoosenSuccess()
        {
            btnSaveNewImage.Enabled = true;
            btnHellFilter.Enabled = true;
            btnMiamiFilter.Enabled = true;
            btnZenFilter.Enabled = true;
            btnResetFilters.Enabled = true;
            btnNoColorFilter.Enabled = true;
        }


       

        // make image edge detection parameters available
        private void UpdateComponentFilterApplied()
        {
            cmbEdgeDetection.Enabled = true;
       
        }

       

        private void NeighbourCountValueChangedEventHandler(object sender, EventArgs e)
        {
            if (filters.untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                ChooseWhichEdgeFilter();
            }
        }

        private void BtnZenFilter_Click(object sender, EventArgs e)
        {

            if (filters.untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                filters.ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filters.filteredColoredBitmap), 1, 10, 1, 1));
                //ApplyEdgeFilter(filteredColoredBitmap);
                ChooseWhichEdgeFilter();
                UpdateComponentFilterApplied();
            }
           
        }

        

        private void BtnMiamiFilter_Click(object sender, EventArgs e)
        {
            if (filters.untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                filters.ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filters.filteredColoredBitmap), 1, 1, 10, 1));
                ChooseWhichEdgeFilter();
                UpdateComponentFilterApplied();
            }

         
        }

        private void BtnHellFilter_Click(object sender, EventArgs e)
        {
            if (filters.untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                filters.ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filters.filteredColoredBitmap), 1, 1, 10, 15));
                ChooseWhichEdgeFilter();
                UpdateComponentFilterApplied();
            }
            
        }
        //back button for filter
        //clear all filters on the picture box by giving the untouchedPreviewBitmap image
        private void BtnResetFilters_Click(object sender, EventArgs e)
        {
           
            ResetAll();


            cmbEdgeDetection.Enabled = false;
   

        }

        private void ResetAll()
        {
            picPreview.Image = filters.untouchedPreviewBitmap;
            filters.filteredColoredBitmap = filters.untouchedPreviewBitmap;
            cmbEdgeDetection.SelectedIndex = cmbEdgeDetection.FindStringExact("None");
        }

        //apply x y filters button
      


     



        private void ChooseWhichEdgeFilter()
        {
            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;
            // the selected source is the bitmap image that has is coloFiltered
            selectedSource = filters.filteredColoredBitmap;

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
                filters.ResultBitmap = bitmapResult;
            }
        }

        private void btnNoColorFilter_Click(object sender, EventArgs e)
        {
            ChooseWhichEdgeFilter();
            UpdateComponentFilterApplied();
        }
    }

}
