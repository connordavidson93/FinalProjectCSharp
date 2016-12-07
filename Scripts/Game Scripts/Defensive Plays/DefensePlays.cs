using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connor
{
    //Plays that the computer chooses at random to counter player's choice plays.
    public class DefensePlays
    {
        public List<string> plays;
        public DefensePlays()
        {
            plays = new List<string>();
            //Hold beats Run
            plays.Add("Hold");
            //Zone beats Pass
            plays.Add("Zone");
            //Blitz beats Trick
            plays.Add("Blitz");
        }

        public void PrintPlays()
        {
            foreach (string s in plays)
            {
                Console.WriteLine(s);
            }
        }

        public string GetPlay(int index)
        {
            return (plays.ElementAt(index));
        }
    }
}