using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connor
{
    public class DefensePlays
    {
        public List<string> plays;
        public DefensePlays()
        {
            plays = new List<string>();
            plays.Add("Hold");
            plays.Add("Zone");
            plays.Add("Blitz");
        }

        public void PrinPays()
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
