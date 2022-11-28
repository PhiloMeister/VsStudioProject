using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using ImageEdgeDetection;
using System.Reflection;
using PictureBox.Image.Testes;
//using PictureBox.Image.Testes;

namespace EdgeDriverTest1Framework
{
    [TestClass]
    public class EdgeDriverTest
    {
        [DllImport("msvcrt.dll")]
        private static extern int memcmp(IntPtr b1, IntPtr b2, long count);

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public void CompareBitmapPixels(Bitmap resultImage, Bitmap filteredImage)
        {
            Assert.AreEqual(resultImage.Size, filteredImage.Size);

            for (int y = 0; y < resultImage.Height; y++)
            {
                for (int x = 0; x < resultImage.Width; x++)
                {
                    Assert.AreEqual(resultImage.GetPixel(x, y), filteredImage.GetPixel(x, y));
                }
            }
        }


        [TestMethod]
        public void ApplyEdge_Laplacian3x3Filterfalse_TestIfDone()
        {
            var dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //Bitmap expectedResult = new Bitmap(Image.FromFile("C:\\Users\\Admin\\Source\\Repos\\VsStudioProjectFinal\\EdgeDriverTest1Framework\\laplacian3x3FilterfalseImage.png"));
            //Bitmap tested = new Bitmap(Image.FromFile("C:\\Users\\Admin\\Source\\Repos\\VsStudioProjectFinal\\EdgeDriverTest1Framework\\standard.png"));
            Bitmap expectedResult = new Bitmap(Image.FromFile(dirName+"\\TestingAssets\\laplacian3x3FilterfalseImage.png"));
            Bitmap tested = new Bitmap(Image.FromFile(dirName+ "\\TestingAssets\\standard.png"));

            Bitmap result =  tested.Laplacian3x3Filter(false);
            
            CompareBitmapPixels(expectedResult, result);


        }
        [TestMethod]
        public void ApplyEdge_Laplacian3x3FilterTrue_TestIfDone()
        {
            var dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //Bitmap expectedResult = new Bitmap(Image.FromFile("C:\\Users\\Admin\\Source\\Repos\\VsStudioProjectFinal\\EdgeDriverTest1Framework\\laplacian3x3FilterTrueImage.png"));
            //Bitmap tested = new Bitmap(Image.FromFile("C:\\Users\\Admin\\Source\\Repos\\VsStudioProjectFinal\\EdgeDriverTest1Framework\\standard.png"));

            Bitmap expectedResult = new Bitmap(Image.FromFile(dirName + "\\TestingAssets\\laplacian3x3FilterTrueImage.png"));
            Bitmap tested = new Bitmap(Image.FromFile(dirName+ "\\TestingAssets\\standard.png"));

            Bitmap result = tested.Laplacian3x3Filter(true);


            CompareBitmapPixels(expectedResult, result);


        }
        [TestMethod]
        public void ApplyEdge_Laplacian5x5FilterFalse_TestIfDone()
        {
            var dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //Bitmap expectedResult = new Bitmap(Image.FromFile("C:\\Users\\Admin\\Source\\Repos\\VsStudioProjectFinal\\EdgeDriverTest1Framework\\Laplacian5x5FilterFalse.png"));
            //Bitmap tested = new Bitmap(Image.FromFile("C:\\Users\\Admin\\Source\\Repos\\VsStudioProjectFinal\\EdgeDriverTest1Framework\\standard.png"));

            Bitmap expectedResult = new Bitmap(Image.FromFile(dirName+ "\\TestingAssets\\Laplacian5x5FilterFalse.png"));
            Bitmap tested = new Bitmap(Image.FromFile(dirName+ "\\TestingAssets\\standard.png"));


            Bitmap result = tested.Laplacian5x5Filter(false);


            CompareBitmapPixels(expectedResult, result);


        }
        [TestMethod]
        public void ApplyEdge_Laplacian5x5FilterTrue_TestIfDone()
        {
            var dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //Bitmap expectedResult = new Bitmap(Image.FromFile("C:\\Users\\Admin\\Source\\Repos\\VsStudioProjectFinal\\EdgeDriverTest1Framework\\Laplacian5x5FilterTrue.png"));
            //Bitmap tested = new Bitmap(Image.FromFile("C:\\Users\\Admin\\Source\\Repos\\VsStudioProjectFinal\\EdgeDriverTest1Framework\\standard.png"));

            Bitmap expectedResult = new Bitmap(Image.FromFile(dirName+ "\\TestingAssets\\Laplacian5x5FilterTrue.png"));
            Bitmap tested = new Bitmap(Image.FromFile(dirName+ "\\TestingAssets\\standard.png"));


            Bitmap result = tested.Laplacian5x5Filter(true);


            CompareBitmapPixels(expectedResult, result);

        }
        [TestMethod]
        public void ApplyEdge_LaplacianOfGaussianFilter_TestIfDone()
        {
            var dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //Bitmap expectedResult = new Bitmap(Image.FromFile("C:\\Users\\Admin\\Source\\Repos\\VsStudioProjectFinal\\EdgeDriverTest1Framework\\LaplacianOfGaussianFilter.png"));
            //Bitmap tested = new Bitmap(Image.FromFile("C:\\Users\\Admin\\Source\\Repos\\VsStudioProjectFinal\\EdgeDriverTest1Framework\\standard.png"));
            Bitmap expectedResult = new Bitmap(Image.FromFile(dirName+ "\\TestingAssets\\LaplacianOfGaussianFilter.png"));
            Bitmap tested = new Bitmap(Image.FromFile(dirName+ "\\TestingAssets\\standard.png"));

            Bitmap result = tested.LaplacianOfGaussianFilter();


            CompareBitmapPixels(expectedResult, result);


        }


        [TestMethod]
        public void ZenFilter_Test()
        {
            var dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Bitmap expectedResult = new Bitmap(Image.FromFile(dirName+ "\\TestingAssets\\ZenFilter_True.png"));
            Bitmap tested = new Bitmap(Image.FromFile(dirName + "\\TestingAssets\\original_Preview.png"));

            Bitmap result = ImageFilters.ApplyFilter(tested, 1, 10, 1, 1);

            CompareBitmapPixels(expectedResult, result);
        }

        [TestMethod]
        public void MiamiFilter_Test()
        {
            var dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Bitmap expectedResult = new Bitmap(Image.FromFile(dirName + "\\TestingAssets\\MiamiFilter_True.png"));
            Bitmap tested = new Bitmap(Image.FromFile(dirName + "\\TestingAssets\\original_Preview.png"));

            Bitmap result = ImageFilters.ApplyFilter(tested, 1, 1, 10, 1);

            CompareBitmapPixels(expectedResult, result);
        }

        [TestMethod]
        public void HellFilter_Test()
        {
            var dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Bitmap expectedResult = new Bitmap(Image.FromFile(dirName + "\\TestingAssets\\HellFilter_True.png"));
            Bitmap tested = new Bitmap(Image.FromFile(dirName + "\\TestingAssets\\original_Preview.png"));

            Bitmap result = ImageFilters.ApplyFilter(tested, 1, 1, 10, 15);

            CompareBitmapPixels(expectedResult, result);
        }

    }
}
