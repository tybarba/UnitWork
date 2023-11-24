using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit12Lab
{
    public class TicTacToe
    {
        private TicTacToeBoard Board;
        private char currentMark = 'X';
        private int size;
        private int numTurns;
        private int turn = 0;
        public TicTacToe()
        {
            //set empty board
            Board = new TicTacToeBoard();
        }

        public void PlayGame()
        {
            bool gameOver = false;
            while (!gameOver)
            {
                Console.Clear();
                Board.DisplayBoard();
                GetUserInput();
                turn++;
                gameOver = CheckGameOver();
                SwitchMark();
                if (gameOver)
                {
                    if (NewGame()) 
                    {
                        gameOver = false;
                        turn = 0;
                        SwitchMark();
                        SetUpGame();
                    }
                }
            }
        }

        public void SetUpGame()
        {
            Console.Write("What size board do you want? ");
            size = int.Parse(Console.ReadLine());
            numTurns = size * size;
            Board = new TicTacToeBoard(size);
        }

        private bool NewGame()
        {
            Console.Write("Do you want to play again? (y/n): ");
            string playAgain = Console.ReadLine();
            return playAgain == "y";
        }

        private bool CheckGameOver()
        {
            //someone won
            if (Board.CheckForWinner())
            {
                System.Console.Clear();
                Board.DisplayBoard();
                Console.WriteLine($"Player {currentMark} is the winner!");
                return true;
            }

            //if no one has won, check it's a tie (there's no more options left, and no one has won)
            else if (turn == numTurns)
            {
                System.Console.Clear();
                Board.DisplayBoard();
                Console.WriteLine("No winner! It's a tie!");
                return true;
            }

            return false;
        }

        private void SwitchMark()
        {
            switch (currentMark)
            {
                case 'X':
                    currentMark = 'O';
                    break;

                case 'O':
                    currentMark = 'X';
                    break;
            }
        }

        public void GetUserInput()
        {
            bool squareIsEmpty = false;
            string userResponse;
            int col = 0;
            int row = 0;
            while (!squareIsEmpty)
            {
                Console.WriteLine($"Player {currentMark}, please choose a square in the following by its number. ");
                userResponse = Console.ReadLine();
                int responseInt = int.Parse(userResponse);
                col = (responseInt - 1) % size;
                row = (responseInt - 1) / size;

                if (Board.CheckSquareEmpty(row, col))
                {
                    break;
                }
                Console.WriteLine("The square you chose was not empty.");
            }
            Board.SetSquare(currentMark, row, col);
        }

    }
}
