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

        //The player chooses either Patriots or Seahawks, then the "team" is created.
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
        
        //The list of players on each team is displayed, first with number, then name, and then position.
        public void PrintRoster()
        {
            Console.WriteLine("Team Roster For the " + TeamName);
            foreach(Player p in myPlayers)
            {
                Console.WriteLine(p.JerseyNumber.ToString() + "   " + p.Name + "  -> " + p.position);
            }
        }

        //Choosing the play to attempt yard gain.
        public void ChoosePlay()
        {
            Console.WriteLine("Choose The Play");
            OffensePlays p = new OffensePlays();
            p.PrintPlays();
            PlayName = "";
            while (!p.IsPlayValid(PlayName))
            {
                Console.WriteLine("Enter the Play to run");
                PlayName = Console.ReadLine();
            }
        }
        
        //The computer player randomly chooses a play to counter the player's choice.
        public void RandomPlay()
        {
            Random r = new Random();
            int x = r.Next(0, 3);
            DefensePlays p = new DefensePlays();
            PlayName = p.GetPlay(x);
        }


    }
}
