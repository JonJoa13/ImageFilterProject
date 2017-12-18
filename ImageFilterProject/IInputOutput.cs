using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterProject
{
    public interface IInputOutput
    {
        Bitmap LoadImage();
        void SaveNewImage(Bitmap image);
    }
}
