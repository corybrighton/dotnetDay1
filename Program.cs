using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      string rock = "r",
       paper = "p",
       sissors = "s";
      bool playing = true;
      int tie = 0,
        win = 0,
        lose = 0;
      Random r = new Random();

      while (playing)
      {
        string[] choises = { "Rock", "Paper", "Sissors" };
        Console.WriteLine($"Enter {rock} for Rock, {paper} for Paper, {sissors} for Sissors, or anthing else to end game.");
        string play = Console.ReadLine();
        int playerC = -1;
        if (play == rock)
        {
          playerC = 0;
        }
        else if (play == paper)
        {
          playerC = 1;
        }
        else if (play == sissors)
        {
          playerC = 2;
        }
        else
        {
          playing = false;
          break;
        }
        int computerC = r.Next(0, 3);
        Console.WriteLine($"You played {choises[playerC]} <=> Computer played {choises[computerC]}");
        if (playerC == computerC)
        {
          Console.WriteLine("Tie");
          tie++;
        }
        else if ((playerC - computerC) % 3 == 1 || (playerC == 0 && computerC == 2))
        {
          Console.WriteLine("You Win");
          win++;
        }
        else
        {
          Console.WriteLine("You lose");
          lose++;
        }
        Console.WriteLine($"Wins {win} <-> Loses {lose} <-> Tie {tie}");
      }

    }
  }
}
