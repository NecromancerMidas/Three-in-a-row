using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_in_a_row
{
    public class Board
    {
        public Square[] theBoard;


        public  Board()
        {
            theBoard = new Square[9];
            for (int i = 0; i < theBoard.Length; i++)
            {
                int number = 0;
                string id = String.Empty;
                if (i == 0 || i == 1 || i == 2)
                {
                    number = 1;
                }
               else if (i == 3 || i == 4 || i == 5)
                {
                    number = 2;
                }
                else
                {
                    number = 3;
                }
                if (i == 0 || i == 3 || i == 6)
                {
                    id = "a";
                }

               else if (i == 1 || i == 4 || i == 7)
                {
                    id = "b";
                }
                else
                {
                    id = "c";
                }

                theBoard[i] = new Square($@"{id}{number}");
            }
        }
    }
}
