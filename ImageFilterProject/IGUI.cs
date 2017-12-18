using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterProject
{
    public interface IGUI
    {
        Bitmap CopyToSquareCanvas(Bitmap sourceBitmap, int canvasWidthLenght);
        Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix, double factor = 1, int bias = 0, bool grayscale = false);
        Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] xFilterMatrix, double[,] yFilterMatrix, double factor = 1, int bias = 0, bool grayscale = false);
        void RgbMethod(byte[] pixelBuffer);
        void OffsetsWithFilterBGR_X(Bitmap sourceBitmap, double[,] filterMatrix, BitmapData sourceData, byte[] pixelBuffer, byte[] resultBuffer, double factor = 1, int bias = 0);
        void OffsetsWithFilterBGR_XY(Bitmap sourceBitmap, double[,] xFilterMatrix, double[,] yFilterMatrix, BitmapData sourceData, byte[] pixelBuffer, byte[] resultBuffer, double factor = 1, int bias = 0);
        Bitmap Laplacian3x3Filter(Bitmap sourceBitmap, bool grayscale = true);
        Bitmap BlackWhiteFilter(Bitmap initialBmp);
        bool CompareTwoImages(Bitmap img1, Bitmap img2);
        void applyFilter(bool preview);
        void NeighbourCountValueChangedEventHandler(object sender, EventArgs e);
    }
}
