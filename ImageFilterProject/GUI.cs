using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterProject
{
    class GUI : IGUI
    {
        private static Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap currentBitmap = null;

        public Bitmap ApplyFilter(int SelectedFilter, Bitmap image)
        {
            if(SelectedFilter == 0)
            {
                return image;
            }

            BusinessLogic bl = new BusinessLogic();
            currentBitmap = bl.applyFilter(image,SelectedFilter);
            return currentBitmap;
        }

        public List<string> getAllFilters()
        {
            List<string> listFilters = new List<string>();
            listFilters.Add("None");
            listFilters.Add("Laplacian3x3");
            listFilters.Add("Black and White");
            return listFilters;
        }

        public Bitmap LoadImage()
        {
            BusinessLogic businessLogic = new BusinessLogic();
            originalBitmap = businessLogic.LoadImage();

            return originalBitmap;
        }

        public void SaveNewImage()
        {
            if (currentBitmap == null) return;

            BusinessLogic businessLogic = new BusinessLogic();
            businessLogic.SaveNewImage(currentBitmap);
        }
    }
}
