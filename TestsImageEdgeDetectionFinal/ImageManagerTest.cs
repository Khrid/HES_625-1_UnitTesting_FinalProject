using BLL;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TestsImageEdgeDetectionFinal
{
    [TestClass]
    public class ImageManagerTest
    {
        [TestMethod]
        public void TestLoadImage()
        {
            IBusinessFileManager imageManager = new ImageManager();
            imageManager.imageLoader = Substitute.For<IFileLoader>();
            imageManager.LoadImage(@"C:\tmp\test.png").Returns(new Bitmap(10, 10));
            Bitmap tmp = imageManager.LoadImage(@"C:\tmp\test.png");
            Assert.AreEqual(tmp.Width, 10);
            Assert.AreEqual(tmp.Height, 10);
        }
    }
}
