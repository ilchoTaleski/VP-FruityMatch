using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityMatch
{
    public class NapkinCollection
    {
        List<Napkin> napkins { get; set; }
        public NapkinCollection()
        {
            napkins = new List<Napkin>();
            InitializeNapkins();
        }
        public void InitializeNapkins()
        {
            int x = 420;
            int y = 170;
            int difference = 58;
            int player = 0;
            for (int i = 0; i<10; i++)
            {
                if (i == 10)
                {
                    player = 1;
                }
                Napkin napkin = new Napkin(player, i + 1, "00", x, y + difference * i, 60, 60);
                napkins.Add(napkin);
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Napkin n in napkins)
            {
                n.Draw(g);
            }
        }
    }
}
