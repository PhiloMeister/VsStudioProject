using System.Drawing;


namespace ImageEdgeDetection.Business
{
    public interface IFilters
    {
        Bitmap ChooseWhichEdgeFilter(IFilterName selectedFilter, Bitmap filteredColoredBitmap);
        Bitmap ApplyColorFilter(Bitmap applyFilter);
    }
}
