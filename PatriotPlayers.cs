using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connor
{
    public class PatriotPlayers
    {
        public List<Player> players { get; set; }

        public PatriotPlayers()
        {
            players = new List<Player>();

            /*Players are
           Tom Brady #12- Quarterback
           Julian Edelman #11 - Receiver
           James White #28 - Runningback
           Chris Long #95 - Defense
           */

            players.Add(new Player("Quarterback", "Tom Brady", 12));
            players.Add(new Player("Receiver", "Julian Edelman", 11));
            players.Add(new Player("Runningback", "James White", 28));
            players.Add(new Player("Defense", "Chris Long", 95));
        }
    }
}
