using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_and_Ladder
{
    class UC2_dice_roll
    {
        public void  dice_roll()
        {
            int start = 0;
            Console.WriteLine("player is at starting position:" + start);

            Random random = new Random();
            int Outcome = random.Next(0,7);

            Console.WriteLine("the output of rolled dice :" + Outcome);
        }
    }
}
