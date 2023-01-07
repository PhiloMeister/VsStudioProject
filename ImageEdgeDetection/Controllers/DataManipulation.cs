using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageEdgeDetection.Controllers
{
    class DataManipulation
    {
        public Bitmap openImageDialog(int width)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Get the image into the original bitmap
                //The original bitmap is not dimensioned for our square
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();
                //PreviewBitmap is like the original one but redimensioned for our square
                //PicPreview is the PICTUREBOX
                untouchedPreviewBitmap = originalBitmap.CopyToSquareCanvas(width);
                //We give the redimensioned image to the square
                filteredColoredBitmap = untouchedPreviewBitmap;
                //picPreview.Image = filteredColoredBitmap;
                return filteredColoredBitmap;
            }

            return null;
        }

    }
}
