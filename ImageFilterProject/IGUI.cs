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
        Image LoadImage();
        void SaveNewImage();
        Image ApplyFilter(int SelectedFilter, Image image);
        List<string> getAllFilters();
    }
}
