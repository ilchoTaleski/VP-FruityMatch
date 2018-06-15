using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityMatch
{
    public class Game
    {
        public Fruit selectedFruit { get; set; }
        public FruitsDocument doc { get; set; }
        public Player player1 { get; set; }
        public Player player2 { get; set; }
        public Game()
        {
            doc = new FruitsDocument();
            List<Fruit> fruits = new List<Fruit>();
            fruits.Add(new Orange(5, 5, 5, 5));
            fruits.Add(new Plum(5, 5, 5, 5));
            fruits.Add(new Peach(5, 5, 5, 5));
            fruits.Add(new Watermelon(5, 5, 5, 5));
            selectedFruit = null;

            player1 = new Player(true, 0, fruits);
            player2 = new Player(false, 1, fruits);
        }

        public void Draw(Graphics g)
        {
            player1.Draw(g);
            player2.Draw(g);
            doc.Draw(g);
        }
        public void changeTurns()
        {
            player1.turn = !player1.turn;
            player2.turn = !player2.turn;
        }
        public LittlePlate getPlate(int x, int y)
        {
            if (player1.turn)
            {
                return player1.getPlate(x, y);
            }
            return player2.getPlate(x, y);
        }
        public int getActiveRow()
        {
            if(player1.turn)
            {
                return player1.littlePlates.activeRow;
            }
            return player2.littlePlates.activeRow;
        }
        public void incrementActiveRow()
        {
            if (player1.turn)
            {
                player1.incrementActiveRow();
                changeCanBeDrawn();
            }
            else if(player2.turn)
            {
                player2.incrementActiveRow();
                changeCanBeDrawn();
            }
        }
        public Napkin getNapkin(int x, int y)
        {
            if (player1.turn)
            {
                return player1.napkins.getNapkinCollision(x, y, player1.littlePlates.activeRow);
            }
            return player2.napkins.getNapkinCollision(x, y, player2.littlePlates.activeRow);
        }

        public String matchingCombination()
        {
            
            if (player1.turn)
            {
                if (!player1.littlePlates.checkAllMatch())
                {
                    return null;
                }
                else
                {
                    return player1.littlePlates.Match(player1.combination);
                }
            }
            else
            {
                if (!player2.littlePlates.checkAllMatch())
                {
                    return null;
                }
                else
                {
                    return player2.littlePlates.Match(player2.combination);
                }
            }
            
        }
        public void changeCanBeDrawn()
        {
            if (player1.turn) {
                player1.changeCanBeDrawn();

            }else
            {
                player2.changeCanBeDrawn();
            }
        }
    }
}
