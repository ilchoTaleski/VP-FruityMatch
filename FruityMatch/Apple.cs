using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityMatch
{
    public class Apple : Fruit
    {
        public Image applePicture { get; set; }
        public Apple(int width, int height, int x, int y) :
            base(width, height, x, y)
        {
            this.applePicture = Properties.Resources.apple;
        }
        override
        public void Draw(Graphics g)
        {
            g.DrawImage(applePicture, this.position.X, this.position.Y, this.Width, this.Height);
        }
    }
}
