using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Controllers
{
    interface IFilters
    {
         void defaultMethod();
        void BtnSaveNewImage_Click();
        void ApplyColorFilter(Bitmap applyFilter);
        Bitmap Filter(string xfilter, string yfilter, int trackBarThresholdValue);
        String ConvertToXYCoord(Bitmap pictureBoxelem, Image pictureBoxResultImage);

        String ApplyXYFilters(String listBoxXFilter, String listBoxYFilter, Image pictureBoxResultImage, int trackBarThresholdValue);
    }
}
