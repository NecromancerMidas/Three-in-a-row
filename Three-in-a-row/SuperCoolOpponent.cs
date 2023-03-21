using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_in_a_row
{
    internal class SuperCoolOpponent
    {

        public static void Opponent(Square[] board)
        {
            if (board[4].isEmpty)
            {
                Square.setSquareOpponent(board,4);
                
            }
            else
            {
                int index = Randomer.Randomizer(0, 8);
                while (!board[index].isEmpty)
                {
                    index = Randomer.Randomizer(0, 8);
                    if (board[index].isEmpty)
                    {
                        Square.setSquareOpponent(board, index);
                        break;
                    }
                }
            }




        }

    }
}
