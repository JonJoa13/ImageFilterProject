using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilterProject
{
    public partial class GUI : Form , IGUI
    {
        public GUI()
        {
            InitializeComponent();
        }

        public void ApplyFilter(bool preview)
        {
            throw new NotImplementedException();
        }

        public void LoadImage(object sender, EventArgs e)
        {
            BusinessLogic BLL = new BusinessLogic();
            BLL.LoadImage();
        }

        public void NeighbourCountValueChangedEventHandler(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }

        public void SaveNewImage(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
