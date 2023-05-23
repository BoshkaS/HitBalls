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
            var all_path = Path.Combine(Directory.GetCurrentDirectory());
            string delete_path = all_path.Substring(all_path.Length - 10);
            string path = all_path.Replace(delete_path, "");

            string file = path + "\\Players.txt";
            string[] lines = File.ReadAllLines(file);

            using (StreamWriter sw = File.AppendText(file))
            {
                sw.WriteLine($"{Name},{Points},{Date}");
            }
        }
    }
}
