# The "Rock - Paper - Scissors" Game

A console-based C# implementation of the "**Rock - Paper - Scissors**" game.

![image](https://user-images.githubusercontent.com/1689586/167414132-7228c697-6806-48a4-81dc-679796135ed0.png)

[**Rock - Paper - Scissors**](https://en.wikipedia.org/wiki/Rock_paper_scissors) is a simple **two player game**, where you and your oponent (the computer) simultaneously choose one of the following three options: "**rock**", "**paper**" or "**scissors**". The rules are as follows:
  - **Rock beats scissors** (the scissors get broken by the rock)
  - **Scissors beats paper** (the paper get cut by the scissors)
  - **Paper beats rock** (the paper covers the rock)

The **winner** is the player whose choice beats the choice of his oponent. If both players choose the same option (e.g. "paper"), the game outcome is "**draw**".

## Input and Output

The player enters one of the following options:
  - `rock` or `r`
  - `paper` or `p`
  - `scissors` or `s`

The computer chooses a **random option**, then reveals the winner.

## Solution

One of the following 9 situations can occur:

| You      | Computer | Outcome  |
| -------- | -------- |--------- |
| rock     | rock     | Draw     |
| rock     | paper    | You lose |
| rock     | scissors | You win  |
| paper    | rock     | You win  |
| paper    | paper    | Draw     |
| paper    | scissors | You lose |
| scissors | rock     | You lose |
| scissors | paper    | You win  |
| scissors | scissors | Draw     |

We handle all these situations using a series of checks.
  - [Source Code (C#)](RockPaperScissorsGame.cs)

## Live Demo 

You can play the game directly in your Web browser here:

[<img alt="Play Button" width="150px" src="http://clipart-library.com/images/kcKBGL6gi.png" />](https://replit.com/@PetarPaunov/Rock-Paper-Scissors#)
