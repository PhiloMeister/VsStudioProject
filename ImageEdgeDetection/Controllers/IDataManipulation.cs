using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Controllers
{
    interface IDataManipulation
    {
        Bitmap openImageDialog(int width);
        void BtnSaveNewImage_Click();
    }
}
