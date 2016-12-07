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
            //Run gains 10 yards
            plays.Add("Run");
            //Pass gains 15 yards
            plays.Add("Pass");
            //Trick gains 30 yards
            plays.Add("Trick");
        }

        public void PrinPays()
        {
            foreach(string s in plays)
            {
                Console.WriteLine(s);
            }
        }

        public bool IsPlayValid( string p)
        {
            return(plays.Contains(p));
        }
    }
}