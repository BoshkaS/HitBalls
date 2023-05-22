using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBall.Components
{
    public class Ball
    {
        public BallUI BallUI { get; set; }

        public ColorsOfBall Color { get; set; }

        public Timer Timer { get; set; }

        public bool IsSelected { get; set; }

        public bool IsAlive { get; set; }

        public Ball(Panel container, int x, int y, int size, ColorsOfBall color, int interval)
        {
            Color = color;
            BallUI = new BallUI(container, x, y, size, color);
            BallUI.Panel.Click += Panel_Click;
            BallUI.Panel.Controls[0].Click += Panel_Click;
            IsSelected = false;
            IsAlive = true;

            Timer = new Timer();

            Timer.Interval = interval;
            
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            IsAlive = false;
            Timer.Stop();
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            BallUI.Panel.BackColor = System.Drawing.Color.Transparent;
            BallUI.Panel.Controls[0].ForeColor = System.Drawing.Color.Black;

            IsAlive = false;
            IsSelected = true;
        }
    }
}
