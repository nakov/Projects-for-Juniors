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

![image](https://user-images.githubusercontent.com/1689586/167416642-2b055cf0-e26f-4c19-98d9-851e071f80dc.png)

![image](https://user-images.githubusercontent.com/1689586/167416225-ea1b623f-3ca5-41eb-8871-54cbb9b7784e.png)

![image](https://user-images.githubusercontent.com/1689586/167416733-3b1c1bac-db50-4b89-9e5d-2d7f778ffc2d.png)

![image](https://user-images.githubusercontent.com/1689586/167416928-e86bcc6a-97c0-41df-8b24-2009509f253c.png)

![image](https://user-images.githubusercontent.com/1689586/167417031-f47473e8-a0cf-4f0b-bc92-18d717a29305.png)

## Live Demo 

You can play the game directly in your Web browser here:

[<img alt="Play Button" width="150px" src="http://clipart-library.com/images/kcKBGL6gi.png" />](https://replit.com/@nakov/Rock-Paper-Scissors-CSharp#RockPaperScissorsGame.cs)
