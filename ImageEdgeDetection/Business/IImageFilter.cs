using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Business
{
    public interface IImageFilter
    {
        Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green);
    }
}
