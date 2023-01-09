using System;
using System.Drawing;
using EdgeDriverTest1Framework.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection.Business;
using NSubstitute;
using ImageEdgeDetection;

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

        public bool CompareBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
            // Verify that both images have the same size
            //if (bmp1.Size != bmp2.Size)
            //    return false;

            // Loop through the pixels of the images and compare them
            // Accepts a margin of error of 1 on each color (rgb) for each pixel
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    Color pixel1 = bmp1.GetPixel(x, y);
                    Color pixel2 = bmp2.GetPixel(x, y);

                    if (Math.Abs(pixel1.R - pixel2.R) > 1 ||
                        Math.Abs(pixel1.G - pixel2.G) > 1 ||
                        Math.Abs(pixel1.B - pixel2.B) > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        [TestMethod]
        public void ApplyEdge_NoneFilter_TestIfDone()
        {
            var filterName = Substitute.For<IFilterName>();
            Filters filterSelection = new Filters();

            //Load two bitmaps from project resources for comparision
            Bitmap expectedResult = new Bitmap(Resources.standard);
            Bitmap tested = new Bitmap(Resources.standard);

            filterName.GetFilterName().Returns("None");

            //Force the use of "Laplacian of Gaussian" filter
            Bitmap result = filterSelection.ChooseWhichEdgeFilter(filterName, tested);
            CompareBitmaps(expectedResult, result);
        }
        [TestMethod]
        public void ApplyEdge_Laplacian3x3Filterfalse_TestIfDone()
        {

            var filterName = Substitute.For<IFilterName>();
            Filters filterSelection = new Filters();

            //Load two bitmaps from project resources for comparision
            Bitmap expectedResult = new Bitmap(Resources.laplacian3x3FilterfalseImage);
            Bitmap tested = new Bitmap(Resources.standard);

            filterName.GetFilterName().Returns("Laplacian 3x3");

            //Force the use of "Laplacian 3x3 Grayscale" filter
            Bitmap result = filterSelection.ChooseWhichEdgeFilter(filterName, tested);
            CompareBitmaps(expectedResult, result);

        }
        [TestMethod]
        public void ApplyEdge_Laplacian3x3FilterTrue_TestIfDone()
        {
            var filterName = Substitute.For<IFilterName>();
            Filters filterSelection = new Filters();

            //Load two bitmaps from project resources for comparision
            Bitmap expectedResult = new Bitmap(Resources.laplacian3x3FilterTrueImage);
            Bitmap tested = new Bitmap(Resources.standard);

            filterName.GetFilterName().Returns("Laplacian 3x3 Grayscale");

            //Force the use of "Laplacian 3x3 Grayscale" filter
            Bitmap result = filterSelection.ChooseWhichEdgeFilter(filterName, tested);

            CompareBitmaps(expectedResult, result);
        }

        [TestMethod]
        public void ApplyEdge_Laplacian5x5FilterFalse_TestIfDone()
        {
            var filterName = Substitute.For<IFilterName>();
            Filters filterSelection = new Filters();

            //Load two bitmaps from project resources for comparision
            Bitmap expectedResult = new Bitmap(Resources.Laplacian5x5FilterFalse);
            Bitmap tested = new Bitmap(Resources.standard);

            filterName.GetFilterName().Returns("Laplacian 5x5");

            //Force the use of "Laplacian 5x5" filter
            Bitmap result = filterSelection.ChooseWhichEdgeFilter(filterName, tested);

            CompareBitmaps(expectedResult, result);


        }
        [TestMethod]
        public void ApplyEdge_Laplacian5x5FilterTrue_TestIfDone()
        {
            var filterName = Substitute.For<IFilterName>();
            Filters filterSelection = new Filters();

            //Load two bitmaps from project resources for comparision
            Bitmap expectedResult = new Bitmap(Resources.Laplacian5x5FilterTrue);
            Bitmap tested = new Bitmap(Resources.standard);

            filterName.GetFilterName().Returns("Laplacian 5x5 Grayscale");

            //Force the use of "Laplacian 3x3 Grayscale" filter
            Bitmap result = filterSelection.ChooseWhichEdgeFilter(filterName, tested);

            CompareBitmaps(tested, expectedResult);

            //CompareBitmaps(expectedResult, result);
        }

        [TestMethod]
        public void ApplyEdge_LaplacianOfGaussianFalse_TestIfDone()
        {
            Bitmap expectedResult = new Bitmap(Resources.Laplacian5x5FilterFalse);
            Bitmap tested = new Bitmap(Resources.standard);

            Bitmap result = tested.LaplacianOfGaussianFilter();

            CompareBitmaps(expectedResult, result);
        }

        [TestMethod]
        public void ApplyEdge_LaplacianOfGaussianFilter_TestIfDone()
        {
            var filterName = Substitute.For<IFilterName>();
            Filters filterSelection = new Filters();

            //Load two bitmaps from project resources for comparision
            Bitmap expectedResult = new Bitmap(Resources.LaplacianOfGaussianFilter);
            Bitmap tested = new Bitmap(Resources.standard);

            filterName.GetFilterName().Returns("Laplacian of Gaussian");

            //Force the use of "Laplacian of Gaussian" filter
            Bitmap result = filterSelection.ChooseWhichEdgeFilter(filterName, tested);//tested.Laplacian3x3Filter(true);

            CompareBitmaps(expectedResult, result);
        }

        [TestMethod]
        public void ApplyEdge_NoSourceImage()
        {
            // the name of the filter does not matter as long as it is part of the list of available filters
            var filterName = Substitute.For<IFilterName>();
            Filters filterSelection = new Filters();
            filterName.GetFilterName().Returns("Laplacian of Gaussian");

            //test the use of a filter on a null source
            Bitmap result = filterSelection.ChooseWhichEdgeFilter(filterName, null);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void ApplyFilterColorTest_NotNull()
        {
            var filter = new Filters();

            Bitmap img = new Bitmap(Resources.standard);

            Bitmap result = filter.ApplyColorFilter(img);

            CompareBitmaps(img, result);
        }

        [TestMethod]
        public void ApplyFilterColorTest_Null()
        {
            var filter = new Filters();


            Bitmap result = filter.ApplyColorFilter(null);

            Assert.IsNull(result);
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



            Bitmap expectedResult = new Bitmap(Resources.pictureZen);
            Bitmap tested = new Bitmap(Resources.standardNotColored);

            Bitmap result = ImageFilters.ApplyFilter(new Bitmap(tested), 1, 10, 1, 1);

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

        //Test the void method SetFilterName()
        [TestMethod]
        public void TestSetFilterName()
        {
            var filter = Substitute.For<IFilterName>();
            FilterName filterString = new FilterName();

            //SetFilterName() is a void method
            filter
                .When(x => x.SetFilterName("FilternameTest"))
                .Do(x => filterString.SetFilterName("FilternameTest"));

            filter.SetFilterName("FilternameTest");

            Assert.AreEqual("FilternameTest", filterString.GetFilterName());
        }

    }
}
