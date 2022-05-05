using System;

namespace Guess_A_Number
{
    public class Program
    {
        public static void Main()
        {
            Random randomNumber = new Random();
            int computerNumer = randomNumber.Next(1, 101);

            while (true)
            {
                Console.Write("Guess a number (1-100): ");

                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                Console.Clear();

                if (!isValid)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                else if (playerNumber == computerNumer)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else
                {
                    if (playerNumber > computerNumer)
                    {
                        Console.WriteLine("High");
                    }
                    else
                    {
                        Console.WriteLine("Low");
                    }
                }

            }
        }
    }
}
