using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruityMatch
{
    public class Player
    {
        public bool turn { get; set; }
        public LittlePlates littlePlates {get; set; }
        public NapkinCollection napkins { get; set; }
        public List<Fruit> combination;
        public Player (bool turn, int playerID, List<Fruit> combination)
        {
            this.combination = combination;
            this.turn = turn;

            littlePlates = new LittlePlates(playerID);
            napkins = new NapkinCollection(playerID);


        }

        public void Draw(Graphics g)
        {
            //if (turn)
            //{
                littlePlates.Draw(g, turn);
            //}
            napkins.Draw(g);
        }

        public LittlePlate getPlate(int x, int y)
        {
            return littlePlates.getIfCollision(x, y);
        }
        public void incrementActiveRow()
        {
            this.littlePlates.activeRow+=1;
            this.napkins.activeRow+=1;
           // MessageBox.Show(s);

        }
        public void changeCanBeDrawn()
        {
            littlePlates.changeCanBeDrawn();
        }

    }
}
