using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterProject
{
    class GUI : IGUI
    {
        public void applyFilter(bool preview)
        {
            throw new NotImplementedException();
        }

        public Bitmap BlackWhiteFilter(Bitmap initialBmp)
        {
            throw new NotImplementedException();
        }

        public bool CompareTwoImages(Bitmap img1, Bitmap img2)
        {
            throw new NotImplementedException();
        }

        public Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix, double factor = 1, int bias = 0, bool grayscale = false)
        {
            throw new NotImplementedException();
        }

        public Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] xFilterMatrix, double[,] yFilterMatrix, double factor = 1, int bias = 0, bool grayscale = false)
        {
            throw new NotImplementedException();
        }

        public Bitmap CopyToSquareCanvas(Bitmap sourceBitmap, int canvasWidthLenght)
        {
            throw new NotImplementedException();
        }

        public Bitmap Laplacian3x3Filter(Bitmap sourceBitmap, bool grayscale = true)
        {
            throw new NotImplementedException();
        }

        public void NeighbourCountValueChangedEventHandler(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OffsetsWithFilterBGR_X(Bitmap sourceBitmap, double[,] filterMatrix, BitmapData sourceData, byte[] pixelBuffer, byte[] resultBuffer, double factor = 1, int bias = 0)
        {
            throw new NotImplementedException();
        }

        public void OffsetsWithFilterBGR_XY(Bitmap sourceBitmap, double[,] xFilterMatrix, double[,] yFilterMatrix, BitmapData sourceData, byte[] pixelBuffer, byte[] resultBuffer, double factor = 1, int bias = 0)
        {
            throw new NotImplementedException();
        }

        public void RgbMethod(byte[] pixelBuffer)
        {
            throw new NotImplementedException();
        }
    }
}
