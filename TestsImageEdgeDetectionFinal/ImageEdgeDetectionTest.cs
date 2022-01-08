using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Drawing;

namespace TestsImageEdgeDetectionFinal
{
    [TestClass]
    public class ImageEdgeDetectionTest
    {
        IBusinessImageEdgeDetection imageEdgeDetection;

        [TestInitialize]
        public void Initialize()
        {
            imageEdgeDetection = new ImageEdgeDetection();
            imageEdgeDetection.originalBmp = new Bitmap(@"..\\..\\..\\Resources\\mario_base.png");
        }

        [TestMethod]
        public void TestEdgeDetectionNotNull()
        {
            Assert.IsNotNull(imageEdgeDetection.originalBmp);
            Assert.IsNotNull(imageEdgeDetection.EdgeDetection(""));
            Assert.IsNotNull(imageEdgeDetection.EdgeDetection("Prewitt"));
            Assert.IsNotNull(imageEdgeDetection.EdgeDetection("Prewitt Grayscale"));
            Assert.IsNotNull(imageEdgeDetection.EdgeDetection("Kirsch"));
            Assert.IsNotNull(imageEdgeDetection.EdgeDetection("Kirsch Grayscale"));
        }

        [TestMethod]
        public void TestNoAlgo()
        {
            //Initialize variables
            string resultImageAfterEdgeDetection_REF;
            string resultImageSaved_REF;
            Bitmap resultImageAfterEdgeDetection = imageEdgeDetection.EdgeDetection("");
            Bitmap resultImageSaved = new Bitmap(@"..\\..\\..\\Resources\\mario_base.png");

            //Assert on width/height and pixels
            if (resultImageAfterEdgeDetection.Width == resultImageSaved.Width && resultImageAfterEdgeDetection.Height == resultImageSaved.Height)
            {
                for (int i = 0; i < resultImageAfterEdgeDetection.Width; i++)
                {
                    for (int j = 0; j < resultImageAfterEdgeDetection.Height; j++)
                    {
                        resultImageAfterEdgeDetection_REF = resultImageAfterEdgeDetection.GetPixel(i, j).ToString();
                        resultImageSaved_REF = resultImageSaved.GetPixel(i, j).ToString();


                        Assert.AreEqual(resultImageAfterEdgeDetection_REF, resultImageSaved_REF);
                    }
                }
            }
        }

        [TestMethod]
        public void TestPrewitt()
        {
            //Initialize variables
            string resultImageAfterEdgeDetection_REF;
            string resultImageSaved_REF;
            Bitmap resultImageAfterEdgeDetection = imageEdgeDetection.EdgeDetection("Prewitt");
            Bitmap resultImageSaved = new Bitmap(@"..\\..\\..\\Resources\\mario_prewitt.png");

            //Assert on width/height and pixels
            if (resultImageAfterEdgeDetection.Width == resultImageSaved.Width && resultImageAfterEdgeDetection.Height == resultImageSaved.Height)
            {
                for (int i = 0; i < resultImageAfterEdgeDetection.Width; i++)
                {
                    for (int j = 0; j < resultImageAfterEdgeDetection.Height; j++)
                    {
                        resultImageAfterEdgeDetection_REF = resultImageAfterEdgeDetection.GetPixel(i, j).ToString();
                        resultImageSaved_REF = resultImageSaved.GetPixel(i, j).ToString();


                        Assert.AreEqual(resultImageAfterEdgeDetection_REF, resultImageSaved_REF);
                    }
                }
            }
        }

        [TestMethod]
        public void TestPrewittGrayscale()
        {
            //Initialize variables
            string resultImageAfterEdgeDetection_REF;
            string resultImageSaved_REF;
            Bitmap resultImageAfterEdgeDetection = imageEdgeDetection.EdgeDetection("Prewitt Grayscale");
            Bitmap resultImageSaved = new Bitmap(@"..\\..\\..\\Resources\\mario_prewitt_grayscale.png");

            //Assert on width/height and pixels
            if (resultImageAfterEdgeDetection.Width == resultImageSaved.Width && resultImageAfterEdgeDetection.Height == resultImageSaved.Height)
            {
                for (int i = 0; i < resultImageAfterEdgeDetection.Width; i++)
                {
                    for (int j = 0; j < resultImageAfterEdgeDetection.Height; j++)
                    {
                        resultImageAfterEdgeDetection_REF = resultImageAfterEdgeDetection.GetPixel(i, j).ToString();
                        resultImageSaved_REF = resultImageSaved.GetPixel(i, j).ToString();


                        Assert.AreEqual(resultImageAfterEdgeDetection_REF, resultImageSaved_REF);
                    }
                }
            }
        }

        [TestMethod]
        public void TestKirsch()
        {
            //Initialize variables
            string resultImageAfterEdgeDetection_REF;
            string resultImageSaved_REF;
            Bitmap resultImageAfterEdgeDetection = imageEdgeDetection.EdgeDetection("Kirsch");
            Bitmap resultImageSaved = new Bitmap(@"..\\..\\..\\Resources\\mario_kirsch.png");

            //Assert on width/height and pixels
            if (resultImageAfterEdgeDetection.Width == resultImageSaved.Width && resultImageAfterEdgeDetection.Height == resultImageSaved.Height)
            {
                for (int i = 0; i < resultImageAfterEdgeDetection.Width; i++)
                {
                    for (int j = 0; j < resultImageAfterEdgeDetection.Height; j++)
                    {
                        resultImageAfterEdgeDetection_REF = resultImageAfterEdgeDetection.GetPixel(i, j).ToString();
                        resultImageSaved_REF = resultImageSaved.GetPixel(i, j).ToString();


                        Assert.AreEqual(resultImageAfterEdgeDetection_REF, resultImageSaved_REF);
                    }
                }
            }
        }

        [TestMethod]
        public void TestKirschGrayscale()
        {
            //Initialize variables
            string resultImageAfterEdgeDetection_REF;
            string resultImageSaved_REF;
            Bitmap resultImageAfterEdgeDetection = imageEdgeDetection.EdgeDetection("Kirsch Grayscale");
            Bitmap resultImageSaved = new Bitmap(@"..\\..\\..\\Resources\\mario_kirsch_grayscale.png");

            //Assert on width/height and pixels
            if (resultImageAfterEdgeDetection.Width == resultImageSaved.Width && resultImageAfterEdgeDetection.Height == resultImageSaved.Height)
            {
                for (int i = 0; i < resultImageAfterEdgeDetection.Width; i++)
                {
                    for (int j = 0; j < resultImageAfterEdgeDetection.Height; j++)
                    {
                        resultImageAfterEdgeDetection_REF = resultImageAfterEdgeDetection.GetPixel(i, j).ToString();
                        resultImageSaved_REF = resultImageSaved.GetPixel(i, j).ToString();


                        Assert.AreEqual(resultImageAfterEdgeDetection_REF, resultImageSaved_REF);
                    }
                }
            }
        }

    }
}
