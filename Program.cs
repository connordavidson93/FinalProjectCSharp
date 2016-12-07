using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connor
{
    class Program
    {
        public static Game myGame = new Game();
        static void Main(string[] args)
        {
            myGame.Opening();
            myGame.Play();
        }
    }
}
