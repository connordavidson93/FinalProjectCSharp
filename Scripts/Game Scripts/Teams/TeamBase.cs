//Base function of the player
using System;
public class TeamBase{
    public static void ChooseTeam(){
        Console.WriteLine("It's the Patriots against the Seahawks - which team will you play?");
        team = Console.ReadLine;
        Console.WriteLine("You are playing for the " + team);
    }
}

/*Need a way to determine different lists of players for the different teams, using the names of the team for use in the game.