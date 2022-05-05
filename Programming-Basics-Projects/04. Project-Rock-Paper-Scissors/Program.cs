using System;

namespace RockPaperScissors
{
    public class Program
    {
        public static void Main()
        {
            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = "Rock";
                    break;
                case 2:
                    computerMove = "Paper";
                    break;
                case 3:
                    computerMove = "Scissors";
                    break;
            }

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = "Rock";
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = "Paper";
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = "Scissors";
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
            }

            Console.WriteLine($"The computer chose {computerMove}.");

            switch (playerMove, computerMove)
            {
                case ("Rock", "Paper"):
                case ("Paper", "Scissors"):
                case ("Scissors", "Rock"):
                    Console.WriteLine("You lose.");
                    break;

                case ("Rock", "Scissors"):
                case ("Paper", "Rock"):
                case ("Scissors", "Paper"):
                    Console.WriteLine("You win.");
                    break;
                
                default:
                    Console.WriteLine("This game was a draw.");
                    break;
            }


        }
    }
}
