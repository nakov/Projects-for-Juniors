using System;
using System.Threading;

namespace Hangman
{
    public class Program
    {
        public static void Main()
        {
            string[] frames = 
            {
				@"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"     ███  ║   " + '\n' +
	            @"    ══════╩═══",
	            // 1
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"     ███  ║   " + '\n' +
	            @"    ══════╩═══",
	            // 2
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"     ███  ║   " + '\n' +
	            @"    ══════╩═══",
	            // 3
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"      |\  ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"     ███  ║   " + '\n' +
	            @"    ══════╩═══",
	            // 4
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"     /|\  ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"     ███  ║   " + '\n' +
	            @"    ══════╩═══",
	            // 5
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"     /|\  ║   " + '\n' +
	            @"       \  ║   " + '\n' +
	            @"     ███  ║   " + '\n' +
	            @"    ══════╩═══",
	            // 6
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"     /|\  ║   " + '\n' +
	            @"     / \  ║   " + '\n' +
	            @"     ███  ║   " + '\n' +
	            @"    ══════╩═══"
            };

            string[] DeathAnimation = 
			{
				@"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"     /|\  ║   " + '\n' +
	            @"     / \  ║   " + '\n' +
	            @"     ███  ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"     /|\  ║   " + '\n' +
	            @"     / \  ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      o>  ║   " + '\n' +
	            @"     /|   ║   " + '\n' +
	            @"      >\  ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"     /|\  ║   " + '\n' +
	            @"     / \  ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"     <o   ║   " + '\n' +
	            @"      |\  ║   " + '\n' +
	            @"     /<   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"     /|\  ║   " + '\n' +
	            @"     / \  ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      o>  ║   " + '\n' +
	            @"     /|   ║   " + '\n' +
	            @"      >\  ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      o>  ║   " + '\n' +
	            @"     /|   ║   " + '\n' +
	            @"      >\  ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"     /|\  ║   " + '\n' +
	            @"     / \  ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"     <o   ║   " + '\n' +
	            @"      |\  ║   " + '\n' +
	            @"     /<   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"     <o   ║   " + '\n' +
	            @"      |\  ║   " + '\n' +
	            @"     /<   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"     <o   ║   " + '\n' +
	            @"      |\  ║   " + '\n' +
	            @"     /<   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"     /|\  ║   " + '\n' +
	            @"     / \  ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      o   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      o   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      o   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      o   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      o   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      o   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      /   ║   " + '\n' +
	            @"      \   ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    |__   ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"      .   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    \__   ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @"   ____   ║   " + '\n' +
	            @"    ══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @"      .   ║   " + '\n' +
	            @"    __    ║   " + '\n' +
	            @"   /══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"      .   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"    _ '   ║   " + '\n' +
	            @"  _/══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @"      _   ║   " + '\n' +
	            @" __/══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @"      .   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @" __/══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"      .   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @" __/══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @"      _   ║   " + '\n' +
	            @" __/══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @"      .   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @" __/══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"      .   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @" __/══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @"      _   ║   " + '\n' +
	            @" __/══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      .   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @" __/══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      '   ║   " + '\n' +
	            @" __/══════╩═══",
	            //
	            @"      ╔═══╗   " + '\n' +
	            @"      |   ║   " + '\n' +
	            @"      O   ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"          ║   " + '\n' +
	            @"      _   ║   " + '\n' +
	            @" __/══════╩═══"
			};

			string word = "wo";
			char[] wordSymbols = word.ToCharArray();

			int incorectGuess = 0;
			int guessCount = 0;

			string wordToGuess = new String('_', wordSymbols.Length);
			char[] wordToGuessChar = wordToGuess.ToCharArray();


			Console.WriteLine(frames[incorectGuess]);
			Console.WriteLine($"Guess: {wordToGuess}");
            Console.WriteLine($"You have to guess {wordSymbols.Length} symbols.");
            Console.Write("Your symbol: ");

			char playerSymbol = char.Parse(Console.ReadLine());

            while (true)
            {
				bool isContains = false;
				int symbolsCount = 0;
				string remakedWord = "";


				for (int i = 0; i < wordSymbols.Length; i++)
                {
                    if (playerSymbol == wordSymbols[i])
                    {
						symbolsCount++;
						isContains = true;
                    }
                }

                if (isContains)
                {
					for (int i = 0; i < wordToGuessChar.Length; i++)
                    {
                        if (playerSymbol == wordSymbols[i])
                        {
							guessCount++;
							wordToGuessChar[i] = playerSymbol;
                        }
                    }


                    for (int i = 0; i < wordToGuessChar.Length; i++)
                    {
						remakedWord += wordToGuessChar[i];
					}

					Console.Clear();
					Console.WriteLine(frames[incorectGuess]);
					Console.WriteLine($"Guess: {remakedWord}");
					Console.WriteLine($"You have to guess {wordSymbols.Length} symbols.");
					Console.Write("Your symbol: ");
                }
                else
                {
					for (int i = 0; i < wordToGuessChar.Length; i++)
					{
						remakedWord += wordToGuessChar[i];
					}

					incorectGuess++;
					Console.Clear();
					Console.WriteLine(frames[incorectGuess]);
					Console.WriteLine($"Guess: {remakedWord}");
					Console.WriteLine($"You have to guess {wordSymbols.Length} symbols.");
					Console.Write("Your symbol: ");
				}

                if (guessCount == wordToGuess.Length)
                {
					//TODO: End Screen
					break;
                }

                if (incorectGuess == frames.Length - 1)
                {
					//TODO: DeathScreen
					Console.Clear();

					for (int i = 0; i < DeathAnimation.Length; i++)
					{
						Console.WriteLine(DeathAnimation[i]);
						Thread.Sleep(200);
						Console.Clear();
					}
					break;
                }

				playerSymbol = char.Parse(Console.ReadLine());

			}
    
		}
    }
}
