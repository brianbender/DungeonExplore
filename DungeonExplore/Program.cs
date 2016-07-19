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
            Console.WriteLine(Environment.NewLine + "The coin spins in the air. It lands... " + predictedSide + " up.");
            if (CoinFlipMatchesPrediction(input))
            {
                Console.WriteLine("?: Very well. You may leave.");
            }
            else
            {
                Console.WriteLine("?: Very well, then! You have lost the wager, and the dungeon is your fate!");
                Console.WriteLine("A trapdoor opens under you. Your heart pounds as you fall... 3 seconds,"
                                  +
                                  " 5 seconds... 10 seconds. *splash* You land in a deep lake. You gasp for breath and " +
                                  "claw for the surface. Shaking, you make your way to the shore. You're in a round, dimly-lit" +
                                  " cavern. There's a single path leading out, barred by a door. On the door, inscribed in bright " +
                                  "red paint, the words GUESS MY NUMBER are crudely painted.");
                Console.WriteLine("Looking closer, you see a keypad next to the door's handle.");
                var theMagicNumber = new Random().Next(9999);
                var numberGuess = -1;
                string read;
                while (numberGuess != theMagicNumber)
                {
                    Console.WriteLine("What number do you guess?");
                    read = Console.ReadLine();
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
                    else if (numberGuess < theMagicNumber/2)
                    {
                        Console.WriteLine("Your intuition tells you that your number is way too small.");
                    }
                    else if (numberGuess < theMagicNumber)
                    {
                        Console.WriteLine("Your intuition tells you that your number is too small.");
                    }
                }
                Console.WriteLine("You punch the numbers into the keypad. The door creakily slides open. You walk through, "
                                  + "into a pitch-black hallway.");

                Console.WriteLine("The light nearly blinds you as you enter another room. As your eyes adjust, you immediately"
                                  +
                                  " notice the garish hot-dog stand wallpaper covering the walls, floors, and ceiling.");

                Console.WriteLine("Next, you notice a button sitting on a small table in the middle of the room. " +
                                  "After scouring the room, there doesn't seem to be anything else present.");

                Console.WriteLine("A voice booms out from nowhere.");

                Console.WriteLine("?: You have one choice. Do you press the button?");

                read = Console.ReadLine();
                while (read != "yes" && read != "y" && read != "no" && read != "n")
                {
                    Console.WriteLine("?: I'll have your answer. [yes] or [no]? ");
                    read = Console.ReadLine();
                    read = read?.ToLower();
                }

                if (read == "yes" || read == "y")
                {
                    Console.WriteLine("You press the button.");
                }
                else
                {
                    Console.WriteLine("You don't press the button.");
                }
                if (theMagicNumber > 4999)
                {
                    Console.WriteLine("?: You have chosen wisely. You may go.");
                    Console.WriteLine(
                        "One of the walls slides away to expose an elevator. You quickly enter it and the " +
                        "doors close behind you. It starts to ascend without you doing anything." +
                        " You find yourself back at the surface.");
                }
                else
                {
                    Console.WriteLine("?: You have chosen poorly.");

                    Console.WriteLine("The mysterious voice cuts out. Nothing else happens. As the minutes pass, " +
                                      "you begin to get restless. You check the door behind you. It refuses to open. You carefully " +
                                      "inspect the table and the button. Nothing reveals itself. You go over the walls and the " +
                                      "floors, searching for any sort of hint. Nothing reveals itself. Is this the end?");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("YOU WIN");
        }

        private static bool CoinFlipMatchesPrediction(string input)
        {
            var random = new Random();
            var flippedHeads = random.Next(1);
            return input == "h" && flippedHeads == 1;
        }
    }
}