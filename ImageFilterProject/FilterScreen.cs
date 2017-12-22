using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilterProject
{
    public partial class FilterScreen : Form
    { 

        
        private IGUI gui = new GUI();
        private BusinessLogic bl = new BusinessLogic();
        private Bitmap originalBitmap;
        private Bitmap resultBitmap;


        public FilterScreen()
        {
            InitializeComponent();

            set_comBoxFilter();

        }

        private void set_comBoxFilter()
        {
            comboBoxFilter.Items.Clear();
            List<string> filters = gui.getAllFilters();
            foreach(string filter in filters)
            {
                comboBoxFilter.Items.Add(filter);
            }
            comboBoxFilter.SelectedIndex = 0;
        }

        private void buttonOpenOriginal_Click(object sender, EventArgs e)
        {
            originalBitmap = gui.LoadImage();

            if (originalBitmap != null)
            {
                pictureOriginal.Image = originalBitmap;
                comboBoxFilter.Enabled = true;
                picturePreview.Image = originalBitmap;
                comboBoxFilter.SelectedIndex = 0;
            }
        }


        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            gui.SaveNewImage();
        }


        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (picturePreview.Image == null) return;
            ComboBox comboBox = (ComboBox)sender;
            resultBitmap = gui.ApplyFilter(comboBox.SelectedIndex, originalBitmap);
            picturePreview.Image = resultBitmap;
        }
    }
}
