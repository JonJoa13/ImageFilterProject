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
        public void ConstructorWithNoParametersTest()
        {

        }

        [TestMethod]
        public void LoadNewImageTest()
        {
            Bitmap imagetoload = Properties.Resources.image;
            Bitmap imageLoaded;

            var substitute = Substitute.For<IInputOutput>();
            BusinessLogic businessLogic = new BusinessLogic(substitute);
            substitute.LoadImage().Returns<Bitmap>(imagetoload);
            imageLoaded = businessLogic.LoadImage();

            Assert.AreEqual(imagetoload, imageLoaded);
        }

        [TestMethod]
        public void ApplyNoFilterTest()
        {
            Bitmap originalBitmap = Properties.Resources.image;
            Bitmap wantedBitmap = Properties.Resources.image;

            var substitute = Substitute.For<IInputOutput>();

            BusinessLogic businessLogic = new BusinessLogic(substitute);

            substitute.LoadImage().Returns<Bitmap>(originalBitmap);

            businessLogic.LoadImage();

            //Apply no filter
            Bitmap noFilter = businessLogic.applyFilter(originalBitmap, 0);

            for (int i = 0; i < noFilter.Width; i++)
            {
                for (int j = 0; j < noFilter.Height; j++)
                {
                    Color cNew = noFilter.GetPixel(i, j);
                    Color cWanted = wantedBitmap.GetPixel(i, j);
                    Assert.AreEqual(cNew, cWanted);
                }

            }
        }

        [TestMethod]
        public void ApplyBlackAndWhiteTest()
        {
            Bitmap originalBitmap = Properties.Resources.image;
            Bitmap wantedBitmap = Properties.Resources.imageBW;

            var substitute = Substitute.For<IInputOutput>();

            BusinessLogic businessLogic = new BusinessLogic(substitute);

            substitute.LoadImage().Returns<Bitmap>(originalBitmap);

            businessLogic.LoadImage();

            //Apply Black and White
            Bitmap blackAndWhite = businessLogic.applyFilter(originalBitmap, 2);

            for (int i = 0; i < blackAndWhite.Width; i++)
            {
                for (int j = 0; j < blackAndWhite.Height; j++)
                {
                    Color cNew = blackAndWhite.GetPixel(i, j);
                    Color cWanted = wantedBitmap.GetPixel(i, j);
                    Assert.AreEqual(cNew, cWanted);
                }

            }
        }

        [TestMethod]
        public void ApplyLaplacianTest()
        {
            Bitmap originalBitmap = Properties.Resources.image;
            Bitmap wantedBitmap = Properties.Resources.Laplacian3x3;

            var substitute = Substitute.For<IInputOutput>();

            BusinessLogic businessLogic = new BusinessLogic(substitute);

            substitute.LoadImage().Returns<Bitmap>(originalBitmap);

            businessLogic.LoadImage();

            //Apply Laplacian3x3
            Bitmap laplacian = businessLogic.applyFilter(originalBitmap, 1);

            for (int i = 0; i < laplacian.Width; i++)
            {
                for (int j = 0; j < laplacian.Height; j++)
                {
                    Color cNew = laplacian.GetPixel(i, j);
                    Color cWanted = wantedBitmap.GetPixel(i, j);
                    Assert.AreEqual(cNew, cWanted);
                }

            }
        }


        [TestMethod]
        public void ExceptionSaveImage()
        {
            var substitute = Substitute.For<IGUI>();
            Bitmap originalBitmap = Properties.Resources.image;
            BusinessLogic businessLogic = new BusinessLogic(substitute);

            substitute
                .When(x => x.ApplyFilter(Arg.Any<int>(), Arg.Any<Bitmap>()))
                .Do(x => { throw new Exception(); });

            try
            {
                businessLogic.applyFilter(originalBitmap, 8);
            }
            catch
            {
                Assert.Fail("hfdf");
            }
        }
    }
}
