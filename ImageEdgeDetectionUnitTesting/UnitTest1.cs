using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection.Controllers;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace ImageEdgeDetectionUnitTesting
{



    [TestClass]
    public class UnitTest1
    {
        private ImageEdgeDetection.
        private System.Windows.Forms.PictureBox picPreview;



        [TestMethod]
        public void ApplyColorFilter_IfImageGivenIsnull()
        {
            Filters filters = new Filters();
            filters.ApplyColorFilter();
        }
    }
}