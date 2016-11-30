using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static Game myGame = new Game();
        public static void Main(string[] args){
            myGame.Opening();
            myGame.Play();
        }


    }
}
