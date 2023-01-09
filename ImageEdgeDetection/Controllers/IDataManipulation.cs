using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Controllers
{
    interface IDataManipulation
    {
         Bitmap openImageDialog();
         void BtnSaveNewImage_Click(Bitmap ResultBitmap);
    }
}
