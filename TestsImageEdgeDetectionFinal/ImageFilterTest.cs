using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Drawing;

namespace TestsImageEdgeDetectionFinal
{
    [TestClass]
    public class ImageFilterTest
    {
        IBusinessImageFilter imageFilter;

        [TestInitialize]
        public void Initialize()
        {
            imageFilter = new ImageFilter();
            imageFilter.originalBmp = new Bitmap(@"..\\..\\..\\Resources\\mario_nb_base.jpg");
        }

        [TestMethod]
        public void TestFilterNotNull()
        {
            Assert.IsNotNull(imageFilter.NoFilter());
            Assert.IsNotNull(imageFilter.HellFilter());
            Assert.IsNotNull(imageFilter.MiamiFilter());
            Assert.IsNotNull(imageFilter.NightFilter());
        }

        [TestMethod]
        public void TestNoFilter()
        {
            //Initialize variables
            string resultImageAfterFilter_REF;
            string resultImageSaved_REF;
            Bitmap resultImageAfterFilter = imageFilter.NoFilter();
            Bitmap resultImageSaved = new Bitmap(@"..\\..\\..\\Resources\\mario_nb_base.jpg");

            //Assert on width/height and pixels
            if (resultImageAfterFilter.Width == resultImageSaved.Width && resultImageAfterFilter.Height == resultImageSaved.Height)
            {
                for (int i = 0; i < resultImageAfterFilter.Width; i++)
                {
                    for (int j = 0; j < resultImageAfterFilter.Height; j++)
                    {
                        resultImageAfterFilter_REF = resultImageAfterFilter.GetPixel(i, j).ToString();
                        resultImageSaved_REF = resultImageSaved.GetPixel(i, j).ToString();


                        Assert.AreEqual(resultImageAfterFilter_REF, resultImageSaved_REF);
                    }
                }
            }
        }

        [TestMethod]
        public void TestHellFilter()
        {
            //Initialize variables
            string resultImageAfterFilter_REF;
            string resultImageSaved_REF;
            Bitmap resultImageAfterFilter = imageFilter.HellFilter();
            Bitmap resultImageSaved = new Bitmap(@"..\\..\\..\\Resources\\mario_nb_hell.jpg");

            //Assert on width/height and pixels
            if (resultImageAfterFilter.Width == resultImageSaved.Width && resultImageAfterFilter.Height == resultImageSaved.Height)
            {
                for (int i = 0; i < resultImageAfterFilter.Width; i++)
                {
                    for (int j = 0; j < resultImageAfterFilter.Height; j++)
                    {
                        resultImageAfterFilter_REF = resultImageAfterFilter.GetPixel(i, j).ToString();
                        resultImageSaved_REF = resultImageSaved.GetPixel(i, j).ToString();


                        Assert.AreEqual(resultImageAfterFilter_REF, resultImageSaved_REF);
                    }
                }
            }
        }

        [TestMethod]
        public void TestMiamiFilter()
        {
            //Initialize variables
            string resultImageAfterFilter_REF;
            string resultImageSaved_REF;
            Bitmap resultImageAfterFilter = imageFilter.MiamiFilter();
            Bitmap resultImageSaved = new Bitmap(@"..\\..\\..\\Resources\\mario_nb_miami.jpg");

            //Assert on width/height and pixels
            if (resultImageAfterFilter.Width == resultImageSaved.Width && resultImageAfterFilter.Height == resultImageSaved.Height)
            {
                for (int i = 0; i < resultImageAfterFilter.Width; i++)
                {
                    for (int j = 0; j < resultImageAfterFilter.Height; j++)
                    {
                        resultImageAfterFilter_REF = resultImageAfterFilter.GetPixel(i, j).ToString();
                        resultImageSaved_REF = resultImageSaved.GetPixel(i, j).ToString();


                        Assert.AreEqual(resultImageAfterFilter_REF, resultImageSaved_REF);
                    }
                }
            }
        }

        [TestMethod]
        public void TestNightFilter()
        {
            //Initialize variables
            string resultImageAfterFilter_REF;
            string resultImageSaved_REF;
            Bitmap resultImageAfterFilter = imageFilter.NightFilter();
            Bitmap resultImageSaved = new Bitmap(@"..\\..\\..\\Resources\\mario_nb_night.jpg");

            //Assert on width/height and pixels
            if (resultImageAfterFilter.Width == resultImageSaved.Width && resultImageAfterFilter.Height == resultImageSaved.Height)
            {
                for (int i = 0; i < resultImageAfterFilter.Width; i++)
                {
                    for (int j = 0; j < resultImageAfterFilter.Height; j++)
                    {
                        resultImageAfterFilter_REF = resultImageAfterFilter.GetPixel(i, j).ToString();
                        resultImageSaved_REF = resultImageSaved.GetPixel(i, j).ToString();


                        Assert.AreEqual(resultImageAfterFilter_REF, resultImageSaved_REF);
                    }
                }
            }
        }

    }
}
