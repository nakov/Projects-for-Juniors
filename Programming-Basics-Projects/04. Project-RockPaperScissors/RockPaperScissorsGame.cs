using System;

public class RockPaperScissorsGame
{
    public static void Main()
    {
        const string Rock = "Rock";
        const string Paper = "Paper";
        const string Scissors = "Scissors";

        // Step 1: read player's move
        Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
        string playerMove = Console.ReadLine();
        if (playerMove == "r" || playerMove == "rock")
        {
            playerMove = Rock;
        }
        else if (playerMove == "p" || playerMove == "paper")
        {
            playerMove = Paper;
        }
        else if (playerMove == "s" || playerMove == "scissors")
        {
            playerMove = Scissors;
        }
        else
        {
            Console.WriteLine("Invalid input.");
            return;
        }
        Console.WriteLine($"Your choice: {playerMove}.");

        // Step 2: choose computer's move
        Random random = new Random();
        int computerRandomNumber = random.Next(1, 4);
        string computerMove = "";
        switch (computerRandomNumber)
        {
            case 1:
                computerMove = Rock;
                break;
            case 2:
                computerMove = Paper;
                break;
            case 3:
                computerMove = Scissors;
                break;
        }
        Console.WriteLine($"Computer choice: {computerMove}.");

        // Step 3: decide about the game outcome (win / lose / draw)
        if ((playerMove == Rock && computerMove == Scissors) ||
                (playerMove == Paper && computerMove == Rock) ||
                (playerMove == Scissors && computerMove == Paper))
        {
            Console.WriteLine("You win.");
        }
        else if ((playerMove == Rock && computerMove == Paper) ||
                (playerMove == Paper && computerMove == Scissors) ||
                (playerMove == Scissors && computerMove == Rock))
        {
            Console.WriteLine("You lose.");
        }
        else
        {
            Console.WriteLine("This game was a draw.");
        }
    }
}
