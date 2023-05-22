using System;
using System.Collections.Generic;
using System.IO;
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

        public DateTime Date { get; set; }

        public int PenaltyPointy { get; set; }
        public Player(string name = "")
        {
            Name = name;
            Points = 0;
            Date = DateTime.Now;
        }

        public void ChooseBall(ColorsOfBall color)
        {
            if(color == ColorsOfBall.Red)
            {
                PenaltyPointy += (int)color;
                return;
            }
            Points += (int)color;
        }

        public void SkipBall(ColorsOfBall color)
        {
            PenaltyPointy -= ((int)color < 0)? 0 : (int)color;
        }

        
        public bool IsOver()
        {
            if (PenaltyPointy <= -100)
            {
                return true;
            }
            return false;
        }

        public void AddToFile()
        {
            string file = @"C:\Users\bozen\Documents\2 курс, прога, 2 семестр\HitBall\HitBall\Components\Players.txt";

            using (StreamWriter sw = File.AppendText(file))
            {
                sw.WriteLine($"{Name},{Points},{Date}");
            }
        }
    }
}
