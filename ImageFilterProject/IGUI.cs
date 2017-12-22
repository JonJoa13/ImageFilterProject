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
        Bitmap LoadImage();
        void SaveNewImage();
        Bitmap ApplyFilter(int SelectedFilter, Bitmap image);
        List<string> getAllFilters();
    }
}
