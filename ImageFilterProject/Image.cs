using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterProject
{
    public class Image
    {
        public Bitmap bitmap { get; set; }
        public String name { get; set; }


        public Image(Bitmap bitmap, String name)
        {
            this.bitmap = bitmap;
            this.name = name;
        }
    }
}
