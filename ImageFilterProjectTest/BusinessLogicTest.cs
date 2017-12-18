using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ImageFilterProject;

namespace ImageFilterProjectTest
{
    [TestClass]
    public class BusinessLogicTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void LoadImageTest()
        {
            var InputOutput = Substitute.For<IInputOutput>();
            var GUI = Substitute.For<IGUI>();
        }

        public void SaveImageTest()
        {
            var InputOutput = Substitute.For<IInputOutput>();
            var GUI = Substitute.For<IGUI>();
        }

        public void ApplyBlackAndWhiteFilterTest()
        {
            var InputOutput = Substitute.For<IInputOutput>();
            var GUI = Substitute.For<IGUI>();
        }

        public void ApplyLaplacian3x3FilterTest()
        {
            var InputOutput = Substitute.For<IInputOutput>();
            var GUI = Substitute.For<IGUI>();
        }
    }
}
