using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connor
{
    public class SeahawkPlayers
    {
        public List<Player> players { get; set; }

        public SeahawkPlayers()
        {
            players = new List<Player>();

            /*Players are
           Russell Wilson #3 - Quarterback
           Doug Baldwin #89 - Receiver
           Thomas Rawls #34 - Runningback
           Richard Sherman #25 - Defense
           */
            players.Add(new Player("Quarterback", "Russell Wilson", 3));
            players.Add(new Player("Receiver", "Doug Baldwin", 89));
            players.Add(new Player("Runningback", "Thomas Rawls", 34));
            players.Add(new Player("Defense", "Richard Sherman", 25));
        }
    }
}
