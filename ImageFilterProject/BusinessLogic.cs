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
        public const int No_Filter = 0;
        public const int Laplacian3x3_Filter = 1;
        public const int BlackAndWhite_Filter = 2;

        private IInputOutput inputOutput = new InputOutput();
        private IGUI gui = new GUI();

        public BusinessLogic()
        {

        }

        public BusinessLogic(IInputOutput inputOutput)
        {
            this.inputOutput = inputOutput;
        }

        public BusinessLogic(IGUI GUI)
        {
            this.gui = GUI;
        }

        public Bitmap applyFilter(Bitmap image, int filterName)
        {
            try
            {
                switch (filterName)
                {
                    case Laplacian3x3_Filter:
                        image = ExtBitmap.Laplacian3x3Filter(image, false);
                        break;
                    case BlackAndWhite_Filter:
                        image = ExtBitmap.BlackWhiteFilter(image);
                        break;
                }
                return image;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Bitmap LoadImage()
        {
            try
            {
               return inputOutput.LoadImage();
            }catch(Exception e)
            {
                throw e;
            }
        }

        public void SaveNewImage(Bitmap image)
        {
            try
            {
                inputOutput.SaveNewImage(image);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
    }
}
