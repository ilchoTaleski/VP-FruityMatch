using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruityMatch
{
    public class Orange:Fruit
    {
        public Image orangePicture { get; set; }
        public Orange(int width, int height, int x, int y):
            base(width,height,x,y)
        {
            orangePicture = Properties.Resources.orange;
          

        }
        override
        public void Draw(Graphics g)
        {
            g.DrawImage(orangePicture, this.position.X, this.position.Y,
                this.Width, this.Height);
           
        }


    }
}
