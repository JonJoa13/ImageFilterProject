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
    }
}
