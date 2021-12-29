using BLL;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace TestsImageEdgeDetectionFinal
{
    [TestClass]
    public class ImageManagerTest
    {
        IBusinessFileManager imageManager;

        [TestInitialize]
        public void Initialize()
        {
            imageManager = new ImageManager();
            imageManager.imageLoader = Substitute.For<IFileLoader>();
            imageManager.imageSaver = Substitute.For<IFileSaver>();
        }

        [TestMethod]
        public void TestLoadExistingImage()
        {
            string target = @"existingImage.png";
            imageManager.LoadImage(target).Returns(new Bitmap(10, 10));
            Bitmap tmp = imageManager.LoadImage(target);
            Assert.AreEqual(tmp.Width, 10);
            Assert.AreEqual(tmp.Height, 10);
        }

        [TestMethod]
        public void TestLoadEmptyImage()
        {
            string target = @"emptyImage.png";
            imageManager.LoadImage(target).Returns(x => { throw new FileNotFoundException(); });
            Assert.ThrowsException<FileNotFoundException>(() => imageManager.LoadImage(target));
        }

        [TestMethod]
        public void TestSaveImage()
        {
            string path = @"existingImage.png";
            Bitmap image = new Bitmap(10, 10);
            imageManager.SaveImage(image, path);
            imageManager.imageSaver.Received(1).SaveFile(Arg.Any<Bitmap>(), Arg.Any<string>());
        }

        [TestMethod]
        public void TestSaveImage_FileExtBmp()
        {
            string path = @"existingImage.bmp";
            Bitmap image = new Bitmap(10, 10);
            imageManager.SaveImage(image, path);
            imageManager.imageSaver.Received(1).SaveFile(Arg.Any<Bitmap>(), Arg.Any<string>());
        }

        [TestMethod]
        public void TestSaveImage_FileExtJpg()
        {
            string path = @"existingImage.jpg";
            Bitmap image = new Bitmap(10, 10);
            imageManager.SaveImage(image, path);
            imageManager.imageSaver.Received(1).SaveFile(Arg.Any<Bitmap>(), Arg.Any<string>());
        }
    }
}
