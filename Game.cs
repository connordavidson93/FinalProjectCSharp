using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace connor
{
    class Game
    {
        public Team myTeam;
        public Team CompTeam;
        private int yards;
        public void Opening()
        {
            Console.WriteLine("Welcome to the Superbowl! The big game is about to begin!");
            Console.WriteLine("It's the Patriots against the Seahawks - which team will you play?");
            string team = "";
            while (!team.Equals("Patriots") && !team.Equals("Seahawks")) { 
                team = Console.ReadLine();
                if (team.Equals("Patriots"))
                {
                    // then create a patriots team
                    myTeam = new Team(team);
                    CompTeam = new Team("Seahawks");
                } else
                {
                    if (team.Equals("Seahawks"))
                    {
                        myTeam = new Team(team);
                        CompTeam = new Team("Patriots");
                    } else
                    {
                        Console.WriteLine("Please enter Patriots or Seahawks!");
                    }
                }
            }
            Console.WriteLine("You are playing for the " + team);
            
        }
        //Timer to create a pause between plays and player choices
        public static void GameTimer()
        {
            Thread.Sleep(2000);
        }

        public void Play()
        {
            Console.WriteLine("The teams are... ");
            Console.WriteLine("You are the " + myTeam.TeamName);
            myTeam.PrintRoster();
            Console.WriteLine("----");
            Console.WriteLine("The Computer is the " + CompTeam.TeamName);
            CompTeam.PrintRoster();


            // this is the game loop
            bool okToPlay = true;
            int NumTries = 0;
            yards = 0;

            while (okToPlay && NumTries < 4)
            {
                // choose the play for the player
                myTeam.ChoosPlay();
                // chose the play for the computer
                CompTeam.RandomPlay();
                // execute the play
                int gain = PlayBall(myTeam, CompTeam);
                // dimaply the results
                Console.WriteLine("Yards Gained: " + gain.ToString());
                yards += gain;
                // see if the game is over
                NumTries++;
                if ( yards >= 50 )
                    okToPlay = false;
            }
            if(yards >= 50)
                Console.WriteLine("You Win With " + yards.ToString() + "yards.");
            else
                Console.WriteLine("You Lose With only " + yards.ToString() + "yards.");
            Console.WriteLine("Game Over!");
        }
        private int PlayBall( Team myTeam, Team CompTeam )
        {
            int yardsGained = 0;
            Console.WriteLine("Play:  " + myTeam.PlayName + " VS " + CompTeam.PlayName);
            switch (myTeam.PlayName)
            {
                case "Run":
                    if (!CompTeam.PlayName.Equals("Hold"))
                        yardsGained = 10;
                    break;
                case "Pass":
                    if (!CompTeam.PlayName.Equals("Zone"))
                        yardsGained = 15;
                    break;
                case "Trick":
                    if (!CompTeam.PlayName.Equals("Blitz"))
                        yardsGained = 30;
                    break;
            }
            return yardsGained;
        }


    }
}
