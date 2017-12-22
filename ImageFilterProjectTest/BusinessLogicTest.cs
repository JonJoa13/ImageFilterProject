using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ImageFilterProject;
using System.Drawing;

namespace ImageFilterProjectTest
{
    [TestClass]
    public class BusinessLogicTest
    {
        [TestMethod]
        public void LoadNewImageTest()
        {
            Bitmap imagetoload = Properties.Resources.image;
            Bitmap imageLoaded;

            var subBitmap = Substitute.For<IInputOutput>();
            BusinessLogic businessLogic = new BusinessLogic(subBitmap);
            //change image to Bitmap
            subBitmap.LoadImage().Returns<Bitmap>(imagetoload);
            imageLoaded = businessLogic.LoadImage();

            Assert.AreEqual(imagetoload, imageLoaded);

            // IEdgeFilter = IScreen
            //IBitmap = IIOfile
        }

    }
}
