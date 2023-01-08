using System;
using System.Drawing;


namespace ImageEdgeDetection.Business
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

        public Bitmap ChooseWhichEdgeFilter(IFilterName selectedFilter,Bitmap filteredColoredBitmap)
        {
            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;
            // the selected source is the bitmap image that has is coloFiltered
            selectedSource = filteredColoredBitmap;

            string filterName = selectedFilter.GetFilterName();

            try {

                switch (filterName)
                {
                    case "None":
                        bitmapResult = selectedSource;
                        break;
                    case "Laplacian 3x3":
                        bitmapResult = selectedSource.Laplacian3x3Filter(false);
                        break;
                    case "Laplacian 3x3 Grayscale":
                        bitmapResult = selectedSource.Laplacian3x3Filter(true);
                        break;
                    case "Laplacian 5x5":
                        bitmapResult = selectedSource.Laplacian5x5Filter(false);
                        break;
                    case "Laplacian 5x5 Grayscale":
                        bitmapResult = selectedSource.Laplacian5x5Filter(true);
                        break;
                    case "Laplacian of Gaussian":
                        bitmapResult = selectedSource.LaplacianOfGaussianFilter();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            return bitmapResult;

        }
    }
}
