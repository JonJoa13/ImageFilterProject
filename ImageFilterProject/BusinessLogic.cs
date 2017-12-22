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
        
        public Image applyFilter(Image image, int name)
        {
            Image image2 = new Image(image.bitmap, image.name);
            switch (name)
            {
                case Laplacian3x3_Filter:
                    image2.bitmap = ExtBitmap.Laplacian3x3Filter(image2.bitmap, false);
                    break;
                case BlackAndWhite_Filter:
                    image2.bitmap = ExtBitmap.BlackWhiteFilter(image2.bitmap);
                    break;
            }
            return image2;
        }

        public Image LoadImage()
        {
            try
            {
               return inputOutput.LoadImage();
            }catch(Exception e)
            {
                throw e;
            }
        }

        public void SaveNewImage(Image image)
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
