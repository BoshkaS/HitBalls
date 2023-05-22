using HitBall.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBall
{
    public partial class AddNewPlayer : Form
    {
        public AddNewPlayer()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Player player = new Player(NewPlayer.Text);
            Form1 form = new Form1();
            Game game = new Game(form, player);
            form.Show();
            this.Close();
        }
    }
}
