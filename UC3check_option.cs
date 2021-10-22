using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_and_Ladder
{
    class UC3check_option
    {
        public const int samePosition = 0;
        public const int ladder = 1;
        public const int Snake = 2;
        public void check_option()
        { 
            int starting_position = 0;
            
            Console.WriteLine("player is at starting position:" + starting_position);

            Random random = new Random();
            int Outcome = random.Next(1, 7);

            Console.WriteLine("the output of rolled dice :" + Outcome);
            int option = random.Next(0, 3);
            switch (option)
            {
                case samePosition:
                    starting_position += 0;
                    break;
                case ladder:
                    starting_position += Outcome;
                    break;
                default:
                    starting_position -= Outcome;
                    break;
               
            }
            Console.WriteLine("the final postion is :" + starting_position);

        }
    }
}
