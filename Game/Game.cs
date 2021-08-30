using System.Collections.Generic;
using System;

namespace csharp_rps
{
  public class Game
  {
    private List<String> RPS {get; set;}
    private Dictionary<String, Array> choices;
    public void StartGame()
    {
      System.Console.WriteLine("Let's play rock-paper-scissors!");
      foreach (string i in RPS)
      {
        System.Console.WriteLine("{0} ", i);
      }
      PlayerChoice();

    }

    private void PlayerChoice()
    {
      string playerChoice = Console.ReadLine().ToLower();
      if (choices.ContainsKey(playerChoice) == false)
      {
        System.Console.WriteLine("That's not a valid choice. Try again, noob:");
        PlayerChoice();
      }
      else { 
        foreach (string i in choices[playerChoice]){
        System.Console.WriteLine(i);
      }
       }
    }

    public Game()
    {
      RPS = new List<String>{"rock", "paper", "scissors"};
      choices = new Dictionary<string, Array>{
        {"rock", new[]{"scissors"}},
        {"scissors", new[]{"paper"}},
        {"paper", new[]{"rock"}},

      };
      StartGame();
    }
  }
}