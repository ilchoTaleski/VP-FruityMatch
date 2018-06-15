using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityMatch
{
    public abstract class FruitCollection
    {
        public List<Fruit> fruits { get; set; }
        public Rectangle rectangle { get; set; }
        public FruitCollection (Rectangle rectangle)
        {
            fruits = new List<Fruit>();
            this.rectangle = rectangle;
        }
        public abstract void InitializeFruits();
        public abstract void Draw(Graphics g);
        public abstract Fruit fruitIfHit(int x, int y);

    }
}
