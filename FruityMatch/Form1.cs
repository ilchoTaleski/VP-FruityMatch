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
                        
           
           // this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
           Orange orange = new Orange(75, 75, 30, 30);
            
           
        }

            this.BackgroundImage = Properties.Resources.background_resized;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
            orange = new Orange(150, 150, 100, 100);
            

            InitializeComponent();
        }

       

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            orange.Draw(e.Graphics);
            MessageBox.Show("da");
        }
    }
}
