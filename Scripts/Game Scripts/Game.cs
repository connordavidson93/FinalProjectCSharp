//The game itself
using System;
public class Game{
    //Beginning when you run the game
    public string Opening(){
        Console.WriteLine("Welcome to the Superbowl! The big game is about to begin!");
    }

    //Running through the game's main function
    public void Play(){
        TeamBase.ChooseTeam();


    }
    
    //Timer to create a pause between plays and player choices
    public static void GameTimer(){
        System.Threading.Sleep(2000);
    }
}
/*After Game starts: 
    Choose a team.
    List Players.
    Choose a play.
    Plays gain yards if successful.
        Run = 10 yards (basic)
        Pass = 20 yards
        Hail Mary = 30 yards
    Defense plays try to stop player
        Blitz > Pass
        Hold > Run
        Pull Back > Hail Mary
    Repeat Play
    Four chances to gain 50 yards.
    If gain 50 yards, win game "Touchdown".
    If do not gain 50 yards, lose game "Turnover".
    */
