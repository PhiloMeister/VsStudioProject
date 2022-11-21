using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection;
using System.Drawing;

namespace ImageEdgeDetectionUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNonNullImage_ApplyEdgeFilter()
        {
            //fill out needed variables


            //format image into Bitmap
            var imgTest = Image.FromFile("UnitTestExample2.jpg");

            //ApplyEdgeFilter(imgTest);

        }
    }
}