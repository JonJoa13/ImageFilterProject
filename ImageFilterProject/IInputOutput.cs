using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterProject
{
    public interface IInputOutput
    {
        void LoadImage(object sender, EventArgs e);
        void SaveNewImage(object sender, EventArgs e);
    }
}
