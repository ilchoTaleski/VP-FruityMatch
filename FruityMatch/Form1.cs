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
        Orange orange;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            this.BackgroundImage = Properties.Resources.background_resized;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
            orange = new Orange(35, 35, 100, 100);
            
        }

       

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X + " " + e.Y);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            orange.Draw(e.Graphics);
            MessageBox.Show("ye");
        }
    }
}
