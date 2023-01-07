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
        public Bitmap OriginalBitmap { get; set; } = null;
        public Bitmap untouchedPreviewBitmap { get; set; } = null;
        public Bitmap ResultBitmap { get; set; } = null;
        public Bitmap filteredColoredBitmap { get; set; } = null;

        IFilters filters = new Filters();
        IDataManipulation dataManipulation = new DataManipulation();
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
            untouchedPreviewBitmap =  dataManipulation.openImageDialog(picPreview);
            filteredColoredBitmap = untouchedPreviewBitmap;
            picPreview.Image = filteredColoredBitmap;
            UpdateComponentImagechoosenSuccess();
        }

        private void BtnSaveNewImage_Click(object sender, EventArgs e)
        {
           ResultBitmap = (Bitmap) picPreview.Image;
           dataManipulation.BtnSaveNewImage_Click(ResultBitmap);
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

        private void UpdateComponentFilterApplied()
        {
            cmbEdgeDetection.Enabled = true;
        }

        private void NeighbourCountValueChangedEventHandler(object sender, EventArgs e)
        {
            if (untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                filteredColoredBitmap = filters.ChooseWhichEdgeFilter(cmbEdgeDetection.SelectedItem.ToString(), filteredColoredBitmap);
                picPreview.Image = filteredColoredBitmap;
            }
        }

        private void BtnZenFilter_Click(object sender, EventArgs e)
        {

            if (untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }
            else
            {
              
                picPreview.Image = filters.ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filteredColoredBitmap), 1, 10, 1, 1));

                UpdateComponentFilterApplied();
            }
           
        }

        private void BtnMiamiFilter_Click(object sender, EventArgs e)
        {
            if (untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }
            else
            {
               
                picPreview.Image = filters.ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filteredColoredBitmap), 1, 1, 10, 1));
                //picPreview.Image = filters.ChooseWhichEdgeFilter(cmbEdgeDetection.SelectedItem.ToString(), filteredColoredBitmap);
                UpdateComponentFilterApplied();
            }
        }

        private void BtnHellFilter_Click(object sender, EventArgs e)
        {
            if (untouchedPreviewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                picPreview.Image = filters.ApplyColorFilter(ImageFilters.ApplyFilter(new Bitmap(filteredColoredBitmap), 1, 1, 10, 15));
                // picPreview.Image = filters.ChooseWhichEdgeFilter(cmbEdgeDetection.SelectedItem.ToString(), filteredColoredBitmap);
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
            picPreview.Image = untouchedPreviewBitmap;
           filteredColoredBitmap = untouchedPreviewBitmap;
            cmbEdgeDetection.SelectedIndex = cmbEdgeDetection.FindStringExact("None");
        }

 
        private void btnNoColorFilter_Click(object sender, EventArgs e)
        {
            picPreview.Image = filters.ChooseWhichEdgeFilter(cmbEdgeDetection.SelectedItem.ToString(), filteredColoredBitmap);
            UpdateComponentFilterApplied();
        }
    }

}
