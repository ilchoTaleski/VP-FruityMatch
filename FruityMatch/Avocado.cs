using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityMatch
{
    public class Watermelon:Fruit
    {
        public Image watermelonPicture { get; set; }
        public Watermelon(int width, int height, int x, int y) :
            base(width, height, x, y)
        {
            watermelonPicture = Properties.Resources.watermelon;
        }
        override
        public void Draw(Graphics g)
        {
            g.DrawImage(watermelonPicture, this.position.X, this.position.Y,
                this.Width, this.Height);
        }
    }
}
