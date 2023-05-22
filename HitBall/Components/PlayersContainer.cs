using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitBall.Components
{
    public class PlayersContainer
    {
        public List<Player> Players { get; set; }

        public PlayersContainer()
        {
            Players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void SortPlayers()
        {
            Players = Players.OrderBy(p => p.Points).ToList();
        }
    }
}
