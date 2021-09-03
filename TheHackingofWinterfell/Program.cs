using System;

namespace TheHackingofWinterfell
{
    /*
         INPUT
         string first_strike_army_name
         int no_of_dragons
         int no_of_white_lords

         OUTPUT
         string result(formatted as army_name | turns)

         EXAMPLE 1
         Input: "Seven Kingdom Army", 4, 5
         Output: White Walker Army | 6

         EXAMPLE 2
         Input: "Seven Kingdom Army", -1, 5
         Output: Invalid parameter provided
    */
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: Seven Kingdom Army, 4, 5");

            var sevenKingdomArmy = new Army(new Soldiers(600, 600, 4),
                                   new Soldiers(2, 2, 5000),
                                   "Seven Kingdom Army");

            var whiteWalkerArmy = new Army(new Soldiers(50, 100, 5),
                                    new Soldiers(1, 3, 10000),
                                    "White Walker Army");

            var game = new Battle(sevenKingdomArmy, whiteWalkerArmy);

            game.Fight("Seven Kingdom Army");

            Console.WriteLine($"Winner Army Name: {game.WinnerArmyName} | Number Of Attacks: {game.NumberOfAttacks}");
            Console.ReadLine();
        }
    }
}