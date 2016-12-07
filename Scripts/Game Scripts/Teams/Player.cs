using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connor
{
    public class Player
    {
        public string position { get; set; }
        public string Name { get; set; }
        public int JerseyNumber { get; set; }

        public Player(string pos, string name, int number)
        {
            position = pos;
            Name = name;
            JerseyNumber = number;
        }
    }
}
