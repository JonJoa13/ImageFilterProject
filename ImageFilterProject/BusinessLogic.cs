using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterProject
{
    public class BusinessLogic
    {
        Bitmap image = null;
        private readonly IInputOutput inputOutput;
        private readonly IGUI GUI;

        public BusinessLogic (IInputOutput inputOutput, IGUI GUI)
        {
            this.inputOutput = inputOutput;
            this.GUI = GUI;
        }

        public void LoadImage()
        {
            try
            {
                image = inputOutput.LoadImage();
            }catch(Exception e)
            {

            }
        }

        public void SaveNewImage()
        {

        }

        /* Methodes de la business logic à implémenter
         * 
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
        */
    }
}
