using System;

namespace RockPaperScissors
{
    public class Program
    {
        public static void Main()
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = rock;
                    break;
                case 2:
                    computerMove = paper;
                    break;
                case 3:
                    computerMove = scissors;
                    break;
            }

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }

            Console.WriteLine($"The computer chose {computerMove}.");

            switch (playerMove, computerMove)
            {
                case (rock, paper):
                case (paper, scissors):
                case (scissors, rock):
                    Console.WriteLine("You lose.");
                    break;

                case (rock, scissors):
                case (paper, rock):
                case (scissors, paper):
                    Console.WriteLine("You win.");
                    break;

                default:
                    Console.WriteLine("This game was a draw.");
                    break;
            }
        }
    }
}