using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageEdgeDetection.Controllers
{
    interface FiltersManager
    {
        void defaultMethod();
        void openImageDialog(System.Windows.Forms.PictureBox picPreview);
    }
}
