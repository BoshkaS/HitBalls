﻿using HitBall.Components;
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
    public partial class AllPlayers : Form
    {
        public AllPlayers(PlayersContainer container)
        {
            InitializeComponent();
            string str = "";
            for (int i = 0; i < container.Length; ++i)
            {
                str += $"{i + 1}. Гравець {container[i].Name} набрав(-ла) {container[i].Points} о {container[i].Date}\n";
            }
            Top10pl.Text = str;
        }

        private void AllPlayers_Load(object sender, EventArgs e)
        {

        }
    }
}
