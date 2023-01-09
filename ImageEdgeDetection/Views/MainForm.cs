﻿/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using ImageEdgeDetection.Business;
using ImageEdgeDetection.Controllers;

namespace ImageEdgeDetection
{
    public partial class MainForm : Form
    {
        public Bitmap OriginalBitmap { get; set; } = null;
        public Bitmap untouchedPreviewBitmap { get; set; } = null;
        public Bitmap ResultBitmap { get; set; } = null;
        public Bitmap filteredColoredBitmap { get; set; } = null;

        IFilterName filterName = new FilterName();
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
            untouchedPreviewBitmap = dataManipulation.openImageDialog();
            filteredColoredBitmap = untouchedPreviewBitmap;
            picPreview.Image = filteredColoredBitmap;
            UpdateComponentImagechoosenSuccess();
        }

        private void BtnSaveNewImage_Click(object sender, EventArgs e)
        {
            ResultBitmap = (Bitmap)picPreview.Image;
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
                filterName.SetFilterName(cmbEdgeDetection.SelectedItem.ToString());
                filteredColoredBitmap = filters.ChooseWhichEdgeFilter(filterName, filteredColoredBitmap);
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
            filterName.SetFilterName(cmbEdgeDetection.SelectedItem.ToString());
            picPreview.Image = filters.ChooseWhichEdgeFilter(filterName, filteredColoredBitmap);
            UpdateComponentFilterApplied();
        }
    }

}
