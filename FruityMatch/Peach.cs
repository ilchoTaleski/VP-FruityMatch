using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityMatch
{
    public class Peach : Fruit
    {
        public Image peachPicture { get; set; }
        public Peach(int width, int height, int x, int y) :
            base(width, height, x, y)
        {
            this.peachPicture = Properties.Resources.peach;
        }
        override
        public void Draw(Graphics g)
        {
            g.DrawImage(peachPicture, this.position.X, this.position.Y, this.Width, this.Height);
        }
    }
}
