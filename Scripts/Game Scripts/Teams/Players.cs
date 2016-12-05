using System.Collections.Generic;
using System;
public class Players{
    public List<Players> listofPlayers;
    public void RunList(){
        listofPlayers = new List<Players>();
        
    }
    private void ChangeList(string name int number){
        TeamMate new TeamMate = new TeamMate();
    }
    private void GetListOfPlayers(){
        foreach(TeamMate in listofPlayers){
            Console.WriteLine(TeamMate.name + " is the name of your quarterback. His number is " + TeamMate.number)
        }
    }

}

/*Need a list of teammates for the chosen team. It lists the quarterback, the receiver, and the runningback with their names and numbers.

Maybe allow for player to change the names?