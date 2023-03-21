// See https://aka.ms/new-console-template for more information

using System.Collections.Immutable;
using System.Runtime.InteropServices;

namespace Three_in_a_row
{

    internal class Program
    {


        public static void Main()
        {

            var board = new Board().theBoard;
            Square.createSquares(board);
            GameConsole.Show(board);
            Console.WriteLine(@"I want to play a game. You mark a box each turn, and I mark a box each turn. 
First to get three in a row wins.
First move is yours you place yours by typing b1 for example which would place it on row 1 and column b, Good Luck.");
            Square.MarkSquare(board);


            


        }





    }
}