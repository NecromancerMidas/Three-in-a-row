using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_in_a_row
{
    public class Square
    {
        public bool isEmpty { get; private set; } = true;
        public bool takenByPlayer1 { get; private set; }
        public string fill { get; private set; } = " ";
        public string Id { get; }

        public Square(string idValue)
        {
            Id = idValue;

        }

        public static void setSquareOpponent(Square[] board, int index)
        {
            board[index].fill = "x";
            board[index].isEmpty = false;
        }
        

        public static void createSquares(Square[] board)
        {

            for (int i = 0; i < board.Length; i++)
            {
                Console.Write(board[i].Id);
            }

        }

        public static void MarkSquare(Square[] board)
        {
            bool legalmove = false;
            bool winner = false;
            while (!winner)
            {
                while (!legalmove)
                {
                    string answer = Console.ReadLine();
                    foreach (var square in board)
                    {
                        if (answer == square.Id)
                        {
                            if (!square.isEmpty)
                            {
                                Console.WriteLine("You have to make a legal move");
                                break;
                            }

                            square.isEmpty = false;
                            square.takenByPlayer1 = true;
                            square.fill = "o";
                            legalmove = true;
                        }
                    }
                }
                
                GameConsole.Show(board);
                winner = CheckIfWinner.CheckWinner(board);
                SuperCoolOpponent.Opponent(board);
                GameConsole.Show(board);
                legalmove = false;
                winner = CheckIfWinner.CheckWinner(board);
            }
        }
    }
}
        
