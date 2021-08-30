using System.Collections.Generic;
using System;

namespace csharp_rps
{
  public class Game
  {
    private List<String> RPS {get; set;}
    public void StartGame()
    {
      System.Console.WriteLine("Let's play rock-paper-scissors!");
      foreach (string i in RPS){
        System.Console.WriteLine("{0} ", i);
      }
      string playerChoice = Console.ReadLine().ToLower();
      string match = RPS.Find(s => s == playerChoice);
      if(match == null){
        System.Console.WriteLine("That's not a valid choice.");
      } else {System.Console.WriteLine("You chose: " + match);}
      
    }
    public Game()
    {
      RPS = new List<String>{"rock", "paper", "scissors"};
      StartGame();
    }
  }
}