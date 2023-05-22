using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBall.Components
{
    public class Field
    {
        private Panel fieldUI;

        public List<Ball> Balls { get; set; }

        public Timer Timer { get; set; }

        public Timer TimerClear { get; set; }

        public Action<ColorsOfBall> IncreasePoints { get; set; }

        public Action<ColorsOfBall> DecreasePoints { get; set; }

        public Func<bool> IsGameOver { get; set; }

        private int intervalForBall = 5000; 

        private void CreateNewBall(int size)
        {
            Random random = new Random();
            int x = random.Next() % (fieldUI.Size.Width - 2 * size + 1);
            int y = random.Next() % (fieldUI.Size.Height - 2 * size + 1);
            ColorsOfBall[] allColors = (ColorsOfBall[])Enum.GetValues(typeof(ColorsOfBall));
            ColorsOfBall randomColor = allColors[random.Next() % allColors.Length];
            var newSection = new Ball(fieldUI, x, y, size, randomColor, intervalForBall);
            Balls.Add(newSection);
        }

        public Field(Form1 form, Action<ColorsOfBall> increasePoints, Action<ColorsOfBall> decreasePoints, Func<bool> isGameOver)
        {
            fieldUI = new Panel();
            fieldUI.Size = new Size(500, 500);
            fieldUI.BackColor = Color.AliceBlue;

            Balls = new List<Ball>();

            IncreasePoints = increasePoints;
            DecreasePoints = decreasePoints;
            IsGameOver = isGameOver;

            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            Timer.Start();

            TimerClear = new Timer();
            TimerClear.Interval = 800;
            TimerClear.Tick += TimerClear_Tick;
            TimerClear.Start();

            form.Controls.Add(fieldUI);
        }

        private void TimerClear_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Balls.Count; ++i)
            {
                if (Balls[i].IsAlive == false)
                {
                    if(Balls[i].IsSelected == true)
                    {
                        IncreasePoints(Balls[i].Color);
                    }
                    else
                    {
                        DecreasePoints(Balls[i].Color);
                    }
                    fieldUI.Controls.Remove(Balls[i].BallUI.Panel);
                    Balls[i] = null;
                    
                }
            }
            Balls = Balls.Where(x => x != null).ToList();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(IsGameOver())
            {
                TimerClear.Stop();
                Timer.Stop();
                MessageBox.Show("Ви програли!");
                return;
            }
            int size = new Random().Next(30, 51);

            CreateNewBall(size);
            if (intervalForBall > 500) intervalForBall -= 200;
            if (Timer.Interval > 100)
            {
                Timer.Interval -= 10;
            }
        }
    }
}
