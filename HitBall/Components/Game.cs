using HitBall.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBall
{
    public class Game
    {
        public Player Player { get; set; }

        public Field Field { get; set; }

        public Label PointLabel { get; set; }

        public List<Player> Players { get; set; }

        public Game(Form1 form, Player player)
        {
            Player = player;

            form.Controls.Add(PointLabel);
            Field = new Field(form, Player.ChooseBall, Player.SkipBall, Player.IsOver);
        }
    }
}
