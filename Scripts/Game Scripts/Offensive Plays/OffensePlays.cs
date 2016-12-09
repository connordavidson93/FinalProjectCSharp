using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connor
{
    public class OffensePlays
    {
        //The plays that the player chooses to gain 50 yards.
        public List<string> plays;
        public OffensePlays()
        {
            plays = new List<string>();
            //Run gains 10 yards if successful.
            plays.Add("Run");
            //Pass gains 15 yards if successful.
            plays.Add("Pass");
            //Trick gains 30 yards if successful.
            plays.Add("Trick");
        }

        //Displays the list of available plays.
        public void PrintPlays()
        {
            foreach(string s in plays)
            {
                Console.WriteLine(s);
            }
        }
        
        //The player must choose one of the plays available. If not, it keeps prompting them to choose a play.
        public bool IsPlayValid( string p)
        {
            return(plays.Contains(p));
        }
    }
}