using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connor
{
    public class OffensePlays
    {
        public List<string> plays;
        public OffensePlays()
        {
            plays = new List<string>();
            plays.Add("Run");
            plays.Add("Pass");
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