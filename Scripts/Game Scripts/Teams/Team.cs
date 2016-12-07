using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connor
{
    public class Team
    {
        public List<Player> myPlayers { get; set; }
        public string TeamName { get; set; }
        public string PlayName { get; set; }

        public Team( string teamName)
        {
            if (teamName.Equals("Patriots"))
            {
                PatriotPlayers players = new PatriotPlayers();
                myPlayers = players.players;
            } else
            {
                SeahawkPlayers players = new SeahawkPlayers();
                myPlayers = players.players;
            }
            TeamName = teamName;
        }

        public void PrintRoster()
        {
            Console.WriteLine("Team Roster For the " + TeamName);
            foreach(Player p in myPlayers)
            {
                Console.WriteLine(p.JersyNumber.ToString() + "   " + p.Name + "  -> " + p.position);
            }
        }

        public void ChoosPlay()
        {
            Console.WriteLine("Choose The Play");
            OffensePlays p = new OffensePlays();
            p.PrinPays();
            PlayName = "";
            while (!p.IsPlayValid(PlayName))
            {
                Console.WriteLine("Enter the Play to run");
                PlayName = Console.ReadLine();
            }
        }

        public void RandomPlay()
        {
            Random r = new Random();
            int x = r.Next(0, 3);
            DefensePlays p = new DefensePlays();
            PlayName = p.GetPlay(x);
        }


    }
}
