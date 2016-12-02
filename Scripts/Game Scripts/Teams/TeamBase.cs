//Base function of the player
using System;
public class TeamBase{
    public static void ChooseTeam(){
        Console.WriteLine("It's the Patriots against the Seahawks - which team will you play?");
        team = Console.ReadLine;
        Console.WriteLine("You are playing for the " + team);
    }
}