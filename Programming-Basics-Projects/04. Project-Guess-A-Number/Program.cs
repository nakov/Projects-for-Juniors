using System;

namespace Guess_A_Number
{
    public class Program
    {
        public static void Main()
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 6);

            Console.Write("Guess a number (1-5): ");

            string playerGuese = Console.ReadLine();
            bool isValid = int.TryParse(playerGuese, out int number);

            if (!isValid)
            {
                Console.WriteLine("Invalid input.");
            }
            else if (computerNumber != number)
            {
                Console.WriteLine($"Incorrect guese.");
            }
            else if (computerNumber == number)
            {
                Console.WriteLine("You guessed it!");
            }

            Console.Write("Press any key to exit...");


        }
    }
}
