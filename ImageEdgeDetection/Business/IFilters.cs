using System.Drawing;


namespace ImageEdgeDetection.Business
{
    public interface IFilters
    {
        Bitmap ChooseWhichEdgeFilter(string selectedFilter, Bitmap filteredColoredBitmap);
        Bitmap ApplyColorFilter(Bitmap applyFilter);
    }
}
