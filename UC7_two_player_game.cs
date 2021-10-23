using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_and_Ladder
{
    class UC7_two_player_game
    {

      //  public const int No_play = 0;
        public const int ladder = 1;
        public const int Snake = 2;
        public int spacialCase = 0;
        public int player = 0;
        public int Final_player = 0;
        public bool repeat = false;
        int[] player_position = new int[] { 0, 0 };

        public void change(int value)
        {
            if (value == 0)
                player = 1;
            else
                player = 0;
        }
        public void play_game( int i, int starting_position )
        {

            Random random = new Random();
            int Outcome = random.Next(1, 7);

            Console.Write("dice throw :" + Outcome);
       
            int option = random.Next(1, 3);
            switch (option)
            {
                case ladder:
                    if ((starting_position + Outcome) == 100)
                    {
                        spacialCase = 1;
                        starting_position += Outcome;
                        Final_player = i;
                        Console.Write("  palyer"+(i+1)+" is win ! ");
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
                    repeat = true;
                        
                    break;
                default:
                    repeat = false;
                    Console.Write("  snake   ! ");
                    if ((starting_position - Outcome) < 0)
                        starting_position = 0;
                    else
                        starting_position -= Outcome;
                    break;

            }
            player_position[i] = starting_position;
            Console.WriteLine("player"+(i+1)" postion is :" + starting_position);

            if (repeat == false)
                change(i);

                
        }


        public void Two_player_game()
        {
          

            int count = 0;
           
            Console.WriteLine("Both players are at starting position:  0" );
            do
            {     
               play_game(player, player_position[player]);
                count++;
            }
            while (player_position[0] <= 100 && player_position[1] <= 100 && spacialCase == 0);
                     

            Console.WriteLine("the final postion of player"+(player+1)+" :" + player_position[player]);
            Console.WriteLine("no. of times dice throw :" + count);
        }

    }
}
