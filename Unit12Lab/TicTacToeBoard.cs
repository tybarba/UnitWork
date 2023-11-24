using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit12Lab
{
    public class TicTacToeBoard
    {
        private int BoardSize;
        private string[,] hengs;

        public TicTacToeBoard()
        {
            hengs = new string[0,0];
        }

        public TicTacToeBoard(int boardSize)
        {
            BoardSize = boardSize;
            hengs = new string[BoardSize, BoardSize];
            SetUpBoard();
        }

        private void SetUpBoard()
        {
            int index = 1;
            for(int row = 0; row < BoardSize; row++)
            {
                for(int col = 0; col < BoardSize; col++)
                {
                    hengs[row, col] = hengs.Length > 9 ? string.Format("  {0:00}  ", index) : $" {index} ";
                    index++;
                }
            }
        }

        public void SetSquare(char choice, int row, int col)
        {
            if(hengs.Length <= 9)
            {
                hengs[row, col] = $" {choice} ";
            }
            else
            {
                hengs[row, col] = $"   {choice}  ";
            }

        }

        public bool CheckSquareEmpty(int row, int col)
        {
            return (hengs[row, col].Trim() != "X" && hengs[row,col].Trim() != "O");
        }

        public bool CheckForWinner()
        {
            return (CheckVertically() || CheckHorizontally() || CheckDiagonally());
        }

        private bool CheckThree(string[] squares)
        {
            int xTotal = 0;
            int yTotal = 0;
            foreach(string square in squares)
            {
                if (square == " X ")
                {
                    xTotal++;
                }
                else if (square == " O ")
                {
                    yTotal++;
                }
            }
            return (xTotal == BoardSize || yTotal == BoardSize);
        }

        private bool CheckHorizontally()
        {
            string[] squaresToCheck = new string[BoardSize];
            for (int heng = 0; heng < BoardSize; heng++)
            {
                for (int squareInRow = 0; squareInRow < BoardSize; squareInRow++)
                {
                    squaresToCheck[squareInRow] = hengs[heng, squareInRow];
                }

                if (CheckThree(squaresToCheck))
                {
                    return true;
                }

            }
            return false;
        }

        private bool CheckVertically()
        {
            string[] squaresToCheck = new string[BoardSize];
            for (int heng = 0; heng < BoardSize; heng++)
            {
                for (int y = 0; y < BoardSize; y++)
                {

                    squaresToCheck[y] = hengs[y, heng];
                }
                if (CheckThree(squaresToCheck))
                {
                    return true;
                }

            }
            return false;
        }

        private bool CheckDiagonally()
        {
            string[] squaresToCheck = new string[BoardSize];
            for (int heng = 0; heng < BoardSize; heng++)
            {
                for (int shu = 0; shu < BoardSize; shu++)
                {
                    squaresToCheck[shu] = hengs[shu, shu];
                }
                if (CheckThree(squaresToCheck))
                {
                    return true;
                }

                for (int shu = 0; shu < BoardSize; shu++)
                {
                    squaresToCheck[shu] = hengs[BoardSize - 1 - shu, shu];
                }
                if (CheckThree(squaresToCheck))
                {
                    return true;
                }
            }
            return false;
        }

        public void DisplayBoard()
        {
            DrawBoardLine();
            for(int row = 0; row < BoardSize; row++)
            {
                Console.Write("|");
                for (int col = 0; col < BoardSize; col++)
                {
                    Console.Write($"{hengs[row, col]}|");
                }
                Console.WriteLine();
                DrawBoardLine();
            }
        }

        private void DrawBoardLine()
        {
            string underSquare = hengs.Length <= 9 ? "----" : "-------";

            for(int i = 0; i<BoardSize; i++)
            {
                Console.Write(underSquare);
            }
            Console.WriteLine();
        }
    }
}
