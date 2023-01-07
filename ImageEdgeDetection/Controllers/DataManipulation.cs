using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageEdgeDetection.Controllers
{
    class DataManipulation : IDataManipulation
    {
        public Bitmap openImageDialog(System.Windows.Forms.PictureBox picPreview)
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
                Bitmap originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();
                //PreviewBitmap is like the original one but redimensioned for our square
                //PicPreview is the PICTUREBOX
                 Bitmap untouchedPreviewBitmap = originalBitmap.CopyToSquareCanvas(picPreview.Width);
                //We give the redimensioned image to the square
                return untouchedPreviewBitmap;
            }

            return null;
        }
        public void BtnSaveNewImage_Click(Bitmap ResultBitmap)
        {
            if (ResultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    ResultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    // clean and close the streamWriter
                    streamWriter.Flush();
                    streamWriter.Close();

                  
                }
            }

   
        }
    }
}
