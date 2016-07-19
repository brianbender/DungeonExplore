using System;

namespace DungeonExplore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("?: I am going to flip a coin. If you guess the flip correctly," +
                              " you win. If you do not, you must escape the dungeon.");
            var input = "";
            while (input != "h" && input != "t")
            {
                Console.WriteLine("Do you choose heads (h) or tails (t)?");
                input = Console.ReadKey().KeyChar.ToString();
            }
            var predictedSide = input == "h" ? "heads" : "tails";
            Console.WriteLine("The coin spins in the air. It lands... " + predictedSide + " up.");
            if (CoinFlipMatchesPrediction(input))
            {
                Console.WriteLine("?: Very well. You may leave.");
            }
            else
            {
                Console.WriteLine("?: Very well, then! You have lost the wager, and the dungeon is your fate!");
            }
        }

        private static bool CoinFlipMatchesPrediction(string input)
        {
            var random = new Random();
            var flippedHeads = random.Next(1);
            return input == "h" && flippedHeads == 1;
        }
    }
}