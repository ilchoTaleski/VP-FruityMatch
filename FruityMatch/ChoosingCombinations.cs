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
    public partial class ChoosingCombinations : Form
    {
        public ChoosingCombinations()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.choose;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
        }
    }
}
