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
        void LoadImage(object sender, EventArgs e);
        void SaveNewImage(object sender, EventArgs e);
        void ApplyFilter(bool preview);
        void NeighbourCountValueChangedEventHandler(object sender, EventArgs e);
    }
}
