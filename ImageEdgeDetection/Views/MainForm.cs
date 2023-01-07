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
              picPreview.Image =  filters.ChooseWhichEdgeFilter(cmbEdgeDetection.SelectedItem.ToString());
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
                filters.ChooseWhichEdgeFilter(cmbEdgeDetection.SelectedItem.ToString());
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
                picPreview.Image = filters.ChooseWhichEdgeFilter(cmbEdgeDetection.SelectedItem.ToString());
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
                picPreview.Image = filters.ChooseWhichEdgeFilter(cmbEdgeDetection.SelectedItem.ToString());
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

 
        private void btnNoColorFilter_Click(object sender, EventArgs e)
        {
            picPreview.Image = filters.ChooseWhichEdgeFilter(cmbEdgeDetection.SelectedItem.ToString());
            UpdateComponentFilterApplied();
        }
    }

}
