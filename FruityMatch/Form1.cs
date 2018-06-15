﻿using System;
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
       
        OrangeCollection collection;
        NapkinCollection napCollection;
        WatermelonCollection watermelonCollection;
        Fruit selectedFruit;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            selectedFruit = null;
            this.BackgroundImage = Properties.Resources.background_resized;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height + 40;

            Rectangle rec1 = new Rectangle(70, 70, 70, 70);
            Rectangle rec2 = new Rectangle(70, 310, 70, 70);
            napCollection = new NapkinCollection();
            collection = new OrangeCollection(rec1);
            watermelonCollection = new WatermelonCollection(rec2);
            this.DoubleBuffered = true;
            
        }

       

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(e.X + " " + e.Y);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            napCollection.Draw(e.Graphics);
            collection.Draw(e.Graphics);
            watermelonCollection.Draw(e.Graphics);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                if (selectedFruit == null)
                {
                    selectedFruit = collection.fruitIfHit(e.X, e.Y);
                    
                }
                if (selectedFruit != null)
                    selectedFruit.MoveTo(e.X, e.Y);
            }
            else
            {
                if (selectedFruit != null)
                {
                    collection.fruits.Remove(selectedFruit);
                }
                
                selectedFruit = null;
            }
            Invalidate(true);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedFruit != null)
            {
                collection.AddFruitFirst();
                collection.fruits.Remove(selectedFruit);
            }

            selectedFruit = null;
            Invalidate(true);
        }
    }
}
