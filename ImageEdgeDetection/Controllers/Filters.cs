using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ImageEdgeDetection.Controllers
{
    public class Filters : IFilters
    {
        public Bitmap ApplyColorFilter(Bitmap applyFilter)
        {

            // if a filter is applied, make the image edge detection parameters available
            if (applyFilter != null)
            {
                return applyFilter;
            }
            return null;

        }

        public Bitmap ChooseWhichEdgeFilter(string selectedFilter,Bitmap filteredColoredBitmap)
        {
            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;
            // the selected source is the bitmap image that has is coloFiltered
            selectedSource = filteredColoredBitmap;

            if (selectedSource != null)
            {
                if (selectedFilter == "None")
                {
                    bitmapResult = selectedSource;
                }
                else if (selectedFilter == "Laplacian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian3x3Filter(false);
                }
                else if (selectedFilter == "Laplacian 3x3 Grayscale")
                {
                    bitmapResult = selectedSource.Laplacian3x3Filter(true);
                }
                else if (selectedFilter == "Laplacian 5x5")
                {
                    bitmapResult = selectedSource.Laplacian5x5Filter(false);
                }
                else if (selectedFilter == "Laplacian 5x5 Grayscale")
                {
                    bitmapResult = selectedSource.Laplacian5x5Filter(true);
                }
                else if (selectedFilter == "Laplacian of Gaussian")
                {
                    bitmapResult = selectedSource.LaplacianOfGaussianFilter();
                }
                else if (selectedFilter == "Laplacian 3x3 of Gaussian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian3x3Filter();
                }
                else if (selectedFilter == "Laplacian 3x3 of Gaussian 5x5 - 1")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian5x5Filter1();
                }
                else if (selectedFilter == "Laplacian 3x3 of Gaussian 5x5 - 2")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian5x5Filter2();
                }
                else if (selectedFilter == "Laplacian 5x5 of Gaussian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian3x3Filter();
                }
                else if (selectedFilter == "Laplacian 5x5 of Gaussian 5x5 - 1")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian5x5Filter1();
                }
                else if (selectedFilter == "Laplacian 5x5 of Gaussian 5x5 - 2")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian5x5Filter2();
                }
                else if (selectedFilter == "Sobel 3x3")
                {
                    bitmapResult = selectedSource.Sobel3x3Filter(false);
                }
                else if (selectedFilter == "Sobel 3x3 Grayscale")
                {
                    bitmapResult = selectedSource.Sobel3x3Filter();
                }
                else if (selectedFilter == "Prewitt")
                {
                    bitmapResult = selectedSource.PrewittFilter(false);
                }
                else if (selectedFilter == "Prewitt Grayscale")
                {
                    bitmapResult = selectedSource.PrewittFilter();
                }
                else if (selectedFilter == "Kirsch")
                {
                    bitmapResult = selectedSource.KirschFilter(false);
                }
                else if (selectedFilter == "Kirsch Grayscale")
                {
                    bitmapResult = selectedSource.KirschFilter();
                }
            }
            if (bitmapResult != null)
            { 
                return bitmapResult;
            }
            return null;
        }
    }
}
