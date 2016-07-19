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
                Console.WriteLine("A trapdoor opens under you. Your heart pounds as you fall... 3 seconds," 
                    + " 5 seconds... 10 seconds. *splash* You land in a deep lake. You gasp for breath and "+
                    "claw for the surface. Shaking, you make your way to the shore. You're in a round, dimly-lit"+
                    " cavern. There's a single path leading out, barred by a door. On the door, inscribed in bright "+
                    "red paint, the words GUESS MY NUMBER are crudely painted.");
                Console.WriteLine("Looking closer, you see a keypad next to the door's handle.");
                var theMagicNumber = new Random().Next(9999);
                int numberGuess = -1;
                while(numberGuess != theMagicNumber) { 
                    Console.WriteLine("What number do you guess?");
                    var read = Console.ReadLine();
                    if (!int.TryParse(read, out numberGuess))
                    {
                        Console.WriteLine(read + " is not a number. What are you thinking?");
                    }
                    if (numberGuess > theMagicNumber*2)
                    {
                        Console.WriteLine("Your intuition tells you that your number is way too large.");
                    }
                    else if (numberGuess > theMagicNumber)
                    {
                        Console.WriteLine("Your intuition tells you that your number is too large.");
                    }
                    else if (numberGuess < theMagicNumber / 2)
                    {
                        Console.WriteLine("Your intuition tells you that your number is way too small.");
                    }
                    else if (numberGuess < theMagicNumber)
                    {
                        Console.WriteLine("Your intuition tells you that your number is too large.");
                    }
                }
                Console.WriteLine("You punch the numbers into the keypad. The door creakily slides open. You walk through, " 
                    + "into a pitch-black hallway.");

                Console.WriteLine("The light nearly blinds you as you enter another room. As your eyes adjust, you immediately" 
                    + " notice the garish hot dog stand wallpaper covering the walls, floors, and ceiling.");
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