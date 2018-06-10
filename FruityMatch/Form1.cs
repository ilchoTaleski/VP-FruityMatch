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
            playButton = Properties.Resources.play;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(playButton, 0, 0);
            g.DrawImageUnscaled(playButton, 100, 100);
        }

    }
}
