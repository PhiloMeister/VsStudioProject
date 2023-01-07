using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageEdgeDetection.Controllers
{
    interface IFilters
    {

        void openImageDialog(System.Windows.Forms.PictureBox picPreview);
        Bitmap ChooseWhichEdgeFilter(String selectedFilter);
        void BtnSaveNewImage_Click();
        void ApplyColorFilter(Bitmap applyFilter);
         Bitmap applyEdgeFilterv2(Bitmap input);
         void resetAll(System.Windows.Forms.PictureBox picPreview, ComboBox cmbEdgeDetection);

         void ConvertToXYCoord(Bitmap pictureBoxelem, System.Windows.Forms.PictureBox pictureBoxResult,
             System.Windows.Forms.TextBox textBoxData);

         void Filter(string xfilter, string yfilter, System.Windows.Forms.TrackBar trackBarThreshold,
             System.Windows.Forms.PictureBox pictureBoxResult, System.Windows.Forms.Label labelError);

         void ApplyXYFilters(System.Windows.Forms.ListBox listBoxXFilter,
             System.Windows.Forms.ListBox listBoxYFilter,
             System.Windows.Forms.PictureBox pictureBoxResult,
             System.Windows.Forms.TextBox textBoxData,
             System.Windows.Forms.Label labelError,
             System.Windows.Forms.TrackBar trackBarThreshold);
    }
}
