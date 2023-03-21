using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Three_in_a_row
{
    internal class GameConsole
    {

        public static void Show(Square[] board)
        {
            
            
            Console.WriteLine(@$" 
  a b c
 ┌─────┐
1│{board[0].fill} {board[1].fill} {board[2].fill}│
2│{board[3].fill} {board[4].fill} {board[5].fill}│
3│{board[6].fill} {board[7].fill} {board[8].fill}│
 └─────┘");
        }
    }
}
