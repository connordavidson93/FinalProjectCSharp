using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace connor
{
    public class Game
    {
        public Team myTeam;
        public Team CompTeam;
        private int yards;
        public void Opening()
        {
            Console.WriteLine("Welcome to the Superbowl! The big game is about to begin!");
            GameTimer();
            Console.WriteLine("It's the Patriots against the Seahawks - which team will you play?");
            string team = "";
            while (!team.Equals("Patriots") && !team.Equals("Seahawks"))
            {
                team = Console.ReadLine();
                if (team.Equals("Patriots"))
                {
                    // Creates a patriots team
                    myTeam = new Team(team);
                    CompTeam = new Team("Seahawks");
                }
                else
                {
                    if (team.Equals("Seahawks"))
                    {
                        //Creates a Seahawks team
                        myTeam = new Team(team);
                        CompTeam = new Team("Patriots");
                    }
                    else
                    {
                        //If invalid entry
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
            //Lists the team rosters based on what team the player chose.
            Console.WriteLine("The teams are... ");
            GameTimer();
            Console.WriteLine("You are the " + myTeam.TeamName);
            myTeam.PrintRoster();
            Console.WriteLine("----");
            GameTimer();
            Console.WriteLine("The Computer is the " + CompTeam.TeamName);
            CompTeam.PrintRoster();
            Console.WriteLine("----");


            // This is the game loop
            bool okToPlay = true;
            int NumTries = 0;
            yards = 0;

            while (okToPlay && NumTries < 4)
            {
                // choose the play for the player
                myTeam.ChoosePlay();
                // choose the play for the computer
                CompTeam.RandomPlay();
                // execute the play
                int gain = PlayBall(myTeam, CompTeam);
                // display the results
                Console.WriteLine("Yards Gained: " + gain.ToString());
                yards += gain;
                GameTimer();
                // see if the game is over
                NumTries++;
                if (yards >= 50)
                    okToPlay = false;
            }
            //Getting 50 yards in four downs wins the game.
            //Not getting 50 yards in four downs loses the game.
            if (yards >= 50)
            {
                Console.WriteLine("Touchdown!");
                GameTimer();
                Console.WriteLine(myTeam.TeamName + " Win with " + yards.ToString() + "yards.");
                Console.WriteLine("Game Over!");
            }
            else
            {
                Console.WriteLine("Turnover!");
                GameTimer();
                Console.WriteLine(myTeam.TeamName + " Lose with only " + yards.ToString() + "yards.");
                GameTimer();
                Console.WriteLine("Game Over!");
            }
        }
        private int PlayBall(Team myTeam, Team CompTeam)
        {
            int yardsGained = 0;
            Console.WriteLine("Play:  " + myTeam.PlayName + " VS " + CompTeam.PlayName);
            GameTimer();
            switch (myTeam.PlayName)
            {
                //Checking player's choice against computer's choice to see if it's a successful play.
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
