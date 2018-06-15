using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruityMatch
{
    public partial class Form1 : Form
    {
        public Game game;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
           
            this.BackgroundImage = Properties.Resources.interface_bg;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height + 40;
            
            this.DoubleBuffered = true;

            game = new Game();
            ChoosingCombinations from = new ChoosingCombinations();
            from.Show();
        }

       

        private void Form1_Resize(object sender, EventArgs e)
        {
            
            Invalidate(true);
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // MessageBox.Show(e.X + " " + e.Y);
            
            if(MouseButtons.Right == e.Button)
            {
                LittlePlate plate = game.getPlate(e.X, e.Y);
                if(plate != null)
                {
                    if(plate.row == game.getActiveRow())
                    {
                        plate.fruitOn = null;
                    }
                    
                }
            }
            if(MouseButtons.Left == e.Button)
            {
                Napkin napkin = game.getNapkin(e.X, e.Y);
                if (napkin.isCollision(e.X, e.Y))
                {
                    String s = game.matchingCombination();
                    if (s == null)
                    {
                        
                        MessageBox.Show("decko, bidi seriozen");
                    }
                    else
                    {
                        game.incrementActiveRow();
                        game.changeTurns();
                        napkin.changeNapkin(s);
                    }
                }
            }
            Invalidate(true);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                if (game.selectedFruit == null)
                {
                    game.selectedFruit = game.doc.fruitIfHit(e.X, e.Y);
                    
                }
                if (game.selectedFruit != null)
                    game.selectedFruit.MoveTo(e.X, e.Y);
            }
            else
            {
                /*if (game.selectedFruit != null)
                {
                    FruitCollection fCol = game.doc.getFruitCollection(game.selectedFruit.type);
                    fCol.AddFruitLast();
                    fCol.fruits.Remove(game.selectedFruit);
                }

                game.selectedFruit = null;*/
            }
            Napkin napkin = game.getNapkin(e.X, e.Y);
            if(napkin != null)
            {
             //   MessageBox.Show("hehey");
                if(napkin.isCollision(e.X, e.Y) ){
                    napkin.changeNapkin("hover");
                } else
                {
                    napkin.changeNapkin("00");
                }
            }
            Invalidate(true);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (game.selectedFruit != null)
            {
                LittlePlate plate = game.getPlate(e.X, e.Y);
                if (plate != null)
                {
                    game.selectedFruit.MoveTo(plate.position.X, plate.position.Y);
                    plate.fruitOn = game.selectedFruit;
                }

                FruitCollection fCol = game.doc.getFruitCollection(game.selectedFruit.type);
                fCol.AddFruitLast();
                fCol.fruits.Remove(game.selectedFruit);
            }

            game.selectedFruit = null;
            Invalidate(true);
   
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
