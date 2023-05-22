using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBall.Components
{
    public class Player
    {
        public string Name { get; set; }

        public int Points { get; set; }
        public Player(string name)
        {
            Name = name;
            Points = 0;
        }

        public void ChooseBall(ColorsOfBall color)
        {
            Points += (int)color;
        }

        public void SkipBall(ColorsOfBall color)
        {
            Points -= ((int)color < 0)? 0 : (int)color;
        }
        
        public bool IsOver()
        {
            if (Points <= 100)
            {
                return true;
            }
            return false;
        }
    }
}
