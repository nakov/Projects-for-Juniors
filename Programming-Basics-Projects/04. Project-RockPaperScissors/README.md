# The "Rock - Paper - Scissors" Game

A console-based C# implementation of the "**Rock - Paper - Scissors**" game.

<img src="https://user-images.githubusercontent.com/1689586/167414132-7228c697-6806-48a4-81dc-679796135ed0.png" width="200px" />

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

## Screenshots

![image](https://user-images.githubusercontent.com/1689586/167414587-dfba062b-fec1-4cab-85ec-c481b24c1a2e.png)

![image](https://user-images.githubusercontent.com/1689586/167414967-efc009d7-5246-4680-9874-f9a57a47c295.png)

![image](https://user-images.githubusercontent.com/1689586/167415095-a20ac29b-385b-4f7d-b78d-7b13cdaa53b7.png)

![image](https://user-images.githubusercontent.com/1689586/167415258-8efcde7d-b223-4df4-8282-5d28be39a6c2.png)

## Live Demo 

You can play the game directly in your Web browser here:

[<img alt="Play Button" width="150px" src="http://clipart-library.com/images/kcKBGL6gi.png" />](https://replit.com/@PetarPaunov/Rock-Paper-Scissors#)
