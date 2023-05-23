using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitBall.Components
{
    public class PlayersContainer
    {
        public List<Player> Players { get; set; }

        public int Length {
            get
            {
                return Players.Count;
            }
        }

        public PlayersContainer()
        {
            Players = new List<Player>();
        }

        public Player this[int index]
        {
            get
            {
                return Players[index];
            }
            set
            {
                Players[index] = value;
            }
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void SortPlayers()
        {
            Players = Players.OrderByDescending(p => p.Points).ToList();
        }

        public void ReadFromFile()
        {
            string file = @"Players.txt";
            string[] lines = File.ReadAllLines(file);
            foreach(var item in lines)
            {
                Player player = new Player();
                var line = item.Split(',');
                player.Name = line[0];
                player.Points = Int32.Parse(line[1]);
                player.Date = DateTime.Parse(line[2]);
                Players.Add(player);
            }
        }
    }
}
