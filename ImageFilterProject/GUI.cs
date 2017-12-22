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
        private static Image originalBitmap = null;
        private Image previewBitmap = null;
        private Image currentBitmap = null;

        public Image ApplyFilter(int SelectedFilter, Image image)
        {
            if(SelectedFilter == 0)
            {
                return image;
            }

            BusinessLogic bl = new BusinessLogic();
            currentBitmap = bl.applyFilter(image, SelectedFilter);
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

        public Image LoadImage()
        {
            BusinessLogic bl = new BusinessLogic();
            originalBitmap = bl.LoadImage();
            Bitmap previewImage = originalBitmap.bitmap;
            Bitmap currentImage = originalBitmap.bitmap;
            currentBitmap = new Image(currentImage, "test");

            return currentBitmap;
        }

        public void SaveNewImage()
        {
            if (currentBitmap == null) return;

            BusinessLogic bl = new BusinessLogic();
            bl.SaveNewImage(currentBitmap);
        }
    }
}
