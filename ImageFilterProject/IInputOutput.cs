using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterProject
{
    interface IInputOutput
    {
        void btnOpenOriginalImage(object sender, EventArgs e);
        void btnSaveNewImage(object sender, EventArgs e);
        void applyFilter(bool preview);
        void NeighbourCountValueChangedEventHandler(object sender, EventArgs e);
    }
}
