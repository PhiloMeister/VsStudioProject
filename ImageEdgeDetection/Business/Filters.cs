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
            }
            if (bitmapResult != null)
            { 
                return bitmapResult;
            }
            return null;
        }
    }
}
