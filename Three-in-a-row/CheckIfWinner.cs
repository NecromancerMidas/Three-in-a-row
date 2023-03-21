using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_in_a_row
{
    internal class CheckIfWinner
    {

        public static bool CheckWinner(Square[] board)
        {
            string winner = String.Empty;
            if (Horizontal(board, 0, true))
            {
                winner = "player1";
            }
            else if (Horizontal(board, 3, true))
            {
                winner = "player1";
            }
            else if (Horizontal(board, 6, true))
            {
                winner = "player1";
            }
            else if (CheckLine(board, 0, 4, 8, true))
            {
                winner = "player1";
            }
            else if (CheckLine(board, 2, 4, 6, true))
            {
                winner = "player1";
            }
            else if (Vertical(board, 0, true))
            {
                winner = "player1";
            }
            else if (Vertical(board, 1, true))
            {
                winner = "player1";
            }
            else if (Vertical(board, 2, true))
            {
                winner = "player1";
            }
            else
            {
                if (Horizontal(board, 0, false))
                {
                    winner = "player2";
                }
                else if (Horizontal(board, 3, false))
                {
                    winner = "player2";
                }
                else if (Horizontal(board, 6, false))
                {
                    winner = "player2";
                }
                else if (CheckLine(board, 0, 4, 8, false))
                {
                    winner = "player2";
                }
                else if (CheckLine(board, 2, 4, 6, false))
                {
                    winner = "player2";
                }
                else if (Vertical(board, 0, false))
                {
                    winner = "player2";
                }
                else if (Vertical(board, 1, false))
                {
                    winner = "player2";
                }
                else if (Vertical(board, 2, false))
                {
                    winner = "player2";
                }
            }

            if (winner == "player1")
            {
                Console.Write(@"Great you won, well played.");
                return true;
            }
            if (winner == "player2")
            {
                Console.WriteLine(@"Better luck next time, seems I won.");
                return true;
            }

            return false;
        }

        public static bool CheckLine(Square[] board, int index1, int index2, int index3, bool player)
        {
            if (board[index1].fill == " " || board[index2].fill == " " || board[index3].fill == " ")
            {
                return false;
            }
            if (player)
            {
                if (!board[index1].takenByPlayer1 || !board[index2].takenByPlayer1 || !board[index3].takenByPlayer1)
                {
                    return false;
                }

                return board[index1].takenByPlayer1 == board[index2].takenByPlayer1 &&
                       board[index2].takenByPlayer1 == board[index3].takenByPlayer1;

            }



            if (!board[index1].isEmpty == !board[index2].isEmpty && !board[index2].isEmpty == !board[index3].isEmpty)
            {
                return !board[index1].takenByPlayer1 == !board[index2].takenByPlayer1 && !board[index2].takenByPlayer1 == !board[index3].takenByPlayer1;
            }
            return false;
        }

        public static bool Horizontal(Square[] board, int index, bool player)
        {
            return CheckLine(board, index, index + 1, index + 2, player);
        }

        public static bool Vertical(Square[] board, int index, bool player)
        {
            return CheckLine(board, index, index + 3, index + 6, player);
        }
    }
}

    

