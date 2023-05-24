using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment_System_Ptoject
{
    [Serializable]
    public class ImageWithTag //new Image class that consist Image type and Tag type;
    {
        public Image Image { get; set; }
        public object Tag { get; set; }

        // Constructor
        public ImageWithTag(Image image = null, object tag = null)
        {
            Image = image;
            Tag = tag;
        }
    }
}
