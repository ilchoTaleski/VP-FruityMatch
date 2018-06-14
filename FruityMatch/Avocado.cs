using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityMatch
{
    public class Avocado:Fruit
    {
        public Image avocadoPicture { get; set; }
        public Avocado(int width, int height, int x, int y) :
            base(width, height, x, y)
        {
            avocadoPicture = Properties.Resources.avocado;
        }
        override
        public void Draw(Graphics g)
        {
            g.DrawImage(avocadoPicture, this.position.X, this.position.Y,
                this.Width, this.Height);
        }
    }
}
