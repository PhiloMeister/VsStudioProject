using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using EdgeDriverTest1Framework.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using ImageEdgeDetection;
using PictureBox.Image.Testes;

namespace EdgeDriverTest1Framework
{
    [TestClass]
    public class EdgeDriverTest
    {
        
        public void CompareBitmapPixels(Bitmap res, Bitmap testimg)
        {
            Assert.AreEqual(res.Size, testimg.Size);

            for (int y = 0; y < res.Height - 1; y++)
            {
                for (int x = 0; x < res.Width - 1; x++)
                {
                    Assert.AreEqual(res.GetPixel(x, y), testimg.GetPixel(x, y));
                }
            }
        }
        public void CompareBitmapPixelsNotEqual(Bitmap res, Bitmap testimg)
        {
            Assert.AreNotEqual(res.Size, testimg.Size);

            for (int y = 0; y < res.Height - 1; y++)
            {
                for (int x = 0; x < res.Width - 1; x++)
                {
                    Assert.AreNotEqual(res.GetPixel(x, y), testimg.GetPixel(x, y));
                }
            }
        }


        [TestMethod]
        public void ApplyEdge_Laplacian3x3Filterfalse_TestIfDone()
        {
            Bitmap expectedResult = new Bitmap(Resources.laplacian3x3FilterfalseImage);
            Bitmap tested = new Bitmap(Resources.standard);

            Bitmap result =  tested.Laplacian3x3Filter(false);
            
            CompareBitmapPixels(expectedResult, result);

        }
        [TestMethod]
        public void ApplyEdge_Laplacian3x3FilterTrue_TestIfDone()
        {
            Bitmap expectedResult = new Bitmap(Resources.laplacian3x3FilterTrueImage);
            Bitmap tested = new Bitmap(Resources.standard);

            Bitmap result = tested.Laplacian3x3Filter(true);

            CompareBitmapPixels(expectedResult, result);


        }
        [TestMethod]
        public void ApplyEdge_Laplacian5x5FilterFalse_TestIfDone()
        {
            Bitmap expectedResult = new Bitmap(Resources.Laplacian5x5FilterFalse);
            Bitmap tested = new Bitmap(Resources.standard);

            Bitmap result = tested.Laplacian5x5Filter(false);

            CompareBitmapPixels(expectedResult, result);


        }
        [TestMethod]
        public void ApplyEdge_Laplacian5x5FilterTrue_TestIfDone()
        {
            Bitmap expectedResult = new Bitmap(Resources.Laplacian5x5FilterTrue);
            Bitmap tested = new Bitmap(Resources.standard);

            Bitmap result = tested.Laplacian5x5Filter(true);

            CompareBitmapPixels(expectedResult, result);

        }
        [TestMethod]
        public void ApplyEdge_LaplacianOfGaussianFilter_TestIfDone()
        {
            Bitmap expectedResult = new Bitmap(Resources.LaplacianOfGaussianFilter);
            Bitmap tested = new Bitmap(Resources.standard);

            Bitmap result = tested.LaplacianOfGaussianFilter();

            CompareBitmapPixels(expectedResult, result);


        }
        [TestMethod]
        public void ApplyZenFilter_TestIfDone()
        {
            Bitmap expectedResult = new Bitmap(Resources.pictureZen);
            Bitmap tested = new Bitmap(Resources.standardNotColored);

            Bitmap result = ImageFilters.ApplyFilter(new Bitmap(tested), 1, 10, 1, 1);

            CompareBitmapPixels(expectedResult, result);

        }
        [TestMethod]
        public void ApplyHellFilter_TestIfDone()
        {
            Bitmap expectedResult = new Bitmap(Resources.pictureHell);
            Bitmap tested = new Bitmap(Resources.standardNotColored);

            Bitmap result = ImageFilters.ApplyFilter(new Bitmap(tested), 1, 1, 10, 15);

            CompareBitmapPixels(expectedResult, result);

        }
        [TestMethod]
        public void ApplyMiamiFilter_TestIfDone()
        {
            Bitmap expectedResult = new Bitmap(Resources.pictureMiami);
            Bitmap tested = new Bitmap(Resources.standardNotColored);

            Bitmap result = ImageFilters.ApplyFilter(tested, 1, 1, 10, 1);

            CompareBitmapPixels(expectedResult, result);

        }
        
    }
}
