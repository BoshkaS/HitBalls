using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBall.Components
{
    public class BallUI
    {
        public Panel Panel { get; set; }


        public BallUI(Panel panel, int x, int y, int size, ColorsOfBall color)
        {
            Panel = new Panel();

            Panel.Size = new Size(size, size);

            ChangeBallColor(color);

            Panel.Controls.Add(new Label() { Text = ((int)color).ToString(), ForeColor = Panel.BackColor, BackColor = Color.Transparent,  Location = new Point(size/2, size/2)}); 

            Panel.Location = new Point(x, y);

            Panel.Region = CreateCircularRegion(size, size);

            panel.Controls.Add(Panel);
        }

        public void ChangeBallColor(ColorsOfBall color)
        {
            switch (color)
            {
                case ColorsOfBall.Red:
                    Panel.BackColor = Color.Red;
                    break;
                case ColorsOfBall.Green:
                    Panel.BackColor = Color.Green;
                    break;
                case ColorsOfBall.Blue:
                    Panel.BackColor = Color.Blue;
                    break;
                case ColorsOfBall.Yellow:
                    Panel.BackColor = Color.Yellow;
                    break;
            }
        }
        private Region CreateCircularRegion(int width, int height)
        {
            int radius = Math.Min(width, height) / 2;

            int x = (width - 2 * radius) / 2;
            int y = (height - 2 * radius) / 2;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(x, y, 2 * radius, 2 * radius);

            Region region = new Region(path);

            return region;
        }
    }
}
