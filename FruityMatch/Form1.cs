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
        Image playButton;
        public Form1()
        {
             InitializeComponent();            
            this.Width = 1280;
            this.Height = 720;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
