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
        private Image image;
        private Image originalImage;


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
            image = gui.LoadImage();

            if (image != null)
            {
                pictureOriginal.Image = image.bitmap;
                picturePreview.Image = image.bitmap;
                comboBoxFilter.Enabled = true;
                originalImage = new Image(image.bitmap, image.name);
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
            image = gui.ApplyFilter(comboBox.SelectedIndex, originalImage);
            picturePreview.Image = image.bitmap;
        }
    }
}
