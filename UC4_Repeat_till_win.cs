using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_and_Ladder
{
    class UC4_Repeat_till_win
    {
        public const int samePosition = 0;
        public const int ladder = 1;
        public const int Snake = 2;
        public void Repeat_till_win()
        {
            int starting_position = 0;
            int spacialCase = 0;
          
            Console.WriteLine("player is at starting position:" + starting_position);
            while (starting_position <= 100 && spacialCase==0)
            {
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
                        if ((starting_position + Outcome) > 100)
                        {   spacialCase = 1;
                            starting_position += Outcome;
                            Console.WriteLine("palyer is win! "); 
                        }
                        else
                        {
                           starting_position += Outcome; 
                        }
                        break;
                    default:
                        if ((starting_position - Outcome) < 0)
                            starting_position = 0;
                        else
                             starting_position -= Outcome;
                        break;

                }
               
            }
            Console.WriteLine("the final postion is :" + starting_position);
          
        }

    }
}
