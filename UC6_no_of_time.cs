using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_and_Ladder
{
    class UC6_no_of_time
    {


        public const int No_play = 0;
        public const int ladder = 1;
        public const int Snake = 2;
        public void get_position_each_time()
        {
            int starting_position = 0;
            int spacialCase = 0;
            int count = 0;
            Console.Write("player is at starting position:" + starting_position);
            while (starting_position <= 100 && spacialCase == 0)
            {
                Random random = new Random();
                int Outcome = random.Next(1, 7);

                Console.Write("dice throw :" + Outcome);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case No_play:
                        starting_position += 0;
                        Console.Write("  NO Play ! ");
                        break;
                    case ladder:
                        if ((starting_position + Outcome) == 100)
                        {
                            spacialCase = 1;
                            starting_position += Outcome;
                            Console.Write("  palyer is win ! ");
                        }
                        else if ((starting_position + Outcome) > 100)
                        {
                            starting_position += 0;
                            Console.Write(" very close to win !");

                        }
                        else
                        {
                            starting_position += Outcome;
                        }
                        Console.Write("  ladder  ! ");
                                   
                        break;
                    default:
                        Console.Write("  snake   ! ");
                        if ((starting_position - Outcome) < 0)
                            starting_position = 0;
                        else
                            starting_position -= Outcome;
                        break;

                }
                count++;
                Console.WriteLine("the postion is :" + starting_position);
            }
            Console.WriteLine("the final postion is :" + starting_position);
            Console.WriteLine("no. of times dice throw :" + count);
        }

    
    }
}
