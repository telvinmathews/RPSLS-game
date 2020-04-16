using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class GameSimulation
    {
        //member variables (has a)
        Players player1;
        Players player2;
        public int pointsNeededToWin;

        //constructor (spawn)
        public GameSimulation()
        {
            pointsNeededToWin = 3;
            player1 = new Human();
        }

        //member method (can do)
        public void RunGame()
        {
            DisplayRules();
            SelectGameMode();
            player1.SelectGesture();
            player2.SelectGesture();
            CompareGesures();
            DisplayCurrentScore();
            CheckForGameWinner();
            
        }
        public void DisplayRules()
        {
            // Logic for Displaying rules
            string rules = "Scissors cuts paper,\n " +
                "paper covers rock,\n" +
                "rock crushes lizard,\n " +
                "lizard poisons Spock,\n" +
                "Spock smashes scissors,\n " +
                "scissors decapitates lizard,\n " +
                "lizard eats paper,\n " +
                "paper disproves Spock,\n " +
                "Spock vaporizes rock,\n " +
                "and as it always has,\n " +
                "rock crushes scissors.\n";
            
            Console.WriteLine(rules + " " + "You need: " + pointsNeededToWin + " " + "to win");
        }

        public void SelectGameMode()
        {
            // logic for human to select HvC or HvH
            Console.WriteLine("Choose a game mode: Type 1 for HvH Type 2 HvC");
            string useInput = Console.ReadLine();

            if (useInput == "1")
            {
                player2 = new Human();
            } 
            else if ( useInput == "2")
            {
                player2 = new Computer();
            }
            else
            {
                Console.WriteLine("Error: Type 1 for HvH or 2 for HvC");
                SelectGameMode();
            }
            
        }

        public void CompareGesures()
        {
            if (player1.chosenGesture == "Rock" && player2.chosenGesture == "Scissors" || player2.chosenGesture == "Lizard")
            {
                player1.score++;
            }
            else if (player1.chosenGesture == "Paper" && player2.chosenGesture == "Rock" || player2.chosenGesture == "Spock")
            {
                player1.score++;
            }
            else if (player1.chosenGesture == "Scissors" && player2.chosenGesture == "Paper" || player2.chosenGesture == "Lizard")
            {
                player1.score++;
            }
            else if (player1.chosenGesture == "Lizard" && player2.chosenGesture == "Paper" || player2.chosenGesture == "Spock")
            {
                player1.score++;
            }
            else if (player1.chosenGesture == "Spock" && player2.chosenGesture == "Rock" || player2.chosenGesture == "Scissors")
            {
                player1.score++;
            }
            else if (player2.chosenGesture == "Rock" && player1.chosenGesture == "Scissors" || player1.chosenGesture == "Lizard")
            {
                player2.score++;
            }
            else if (player2.chosenGesture == "Paper" && player1.chosenGesture == "Rock" || player1.chosenGesture == "Spock")
            {
                player2.score++;
            }
            else if (player2.chosenGesture == "Scissors" && player1.chosenGesture == "Paper" || player1.chosenGesture == "Lizard")
            {
                player2.score++;
            }
            else if (player2.chosenGesture == "Lizard" && player1.chosenGesture == "Paper" || player1.chosenGesture == "Spock")
            {
                player2.score++;
            }
            else if (player2.chosenGesture == "Spock" && player1.chosenGesture == "Rock" || player1.chosenGesture == "Scissors")
            {
                player2.score++;
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }

        public void DisplayCurrentScore()
        {
            Console.WriteLine("Player 1 has: " + player1.score + " points");
            Console.WriteLine("Player 2 has: " + player2.score + " points");
        }

        public void CheckForGameWinner()
        {
            if (player1.score == 3)
            {
                Console.WriteLine("Player 1 wins the game");
            }
            else if (player2.score == 3)
            {
                Console.WriteLine("Player 2 wins the game");
            }
            else
            {
                player1.SelectGesture();
                player2.SelectGesture();
                CompareGesures();
                DisplayCurrentScore();
                CheckForGameWinner();
                Console.WriteLine("Play again?: Y or N");
            }

        }
    }
}
