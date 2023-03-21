using System;
//Does what it says on the tin, nothing more nothing less.
namespace Three_in_a_row
{


    public class Randomer
    {
        public static int Randomizer(int min, int max)
        {
            Random rng = new Random();
            int num = rng.Next(min, max);
            return num;


        }
    }
}
