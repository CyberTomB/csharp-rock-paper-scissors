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
      var random = new Random();
      var index = random.Next(choices.Count);
      string computerChoice = RPS[index];
      foreach (string i in RPS)
      {
        System.Console.WriteLine("{0} ", i);
      }
      PlayerChoice(computerChoice);

    }

    private void PlayerChoice(string computerChoice)
    {
      string playerChoice = Console.ReadLine().ToLower();
      if (choices.ContainsKey(playerChoice) == false)
      {
        System.Console.WriteLine("That's not a valid choice. Try again, noob:");
        PlayerChoice(computerChoice);
      }
      else {
        if(computerChoice == playerChoice){
          System.Console.WriteLine(@"
          I chose: {playerChoice}
          You chose: {computerChoice}
          Result: DRAW");
        } else {
        System.Console.WriteLine(@$"
          I chose: {computerChoice}
          You chose: {playerChoice}
          Result: WIN");
        foreach (string i in choices[playerChoice]){
        System.Console.WriteLine(i);
        }
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