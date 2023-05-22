using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HitBall.Components;

namespace HitBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load += Form1_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewPlayer newForm = new AddNewPlayer();
            newForm.Show();
            this.Hide();
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            Rules rulesForm = new Rules();
            rulesForm.Show();
        }

        private void Top10_Click(object sender, EventArgs e)
        {
            PlayersContainer container = new PlayersContainer();
            container.ReadFromFile();
            container.SortPlayers();
            Top10Players top10 = new Top10Players(container);
            top10.Show();
        }
    }
}
