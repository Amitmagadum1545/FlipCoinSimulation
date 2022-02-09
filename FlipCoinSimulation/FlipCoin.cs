using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoinSimulation
{
    internal class FlipCoin
    {
        public static void GetHeadOrTail()
        {
            Random random = new Random();
            int head = 1, tail = 0, headCount = 0, tailCount = 0, won = 21;
            while (headCount < won && tailCount < won)
            {
                int check = random.Next(0, 2);
                if (check == head)
                {
                    headCount++;
                    Console.WriteLine("Got Head, headCount: " + headCount);
                }
                else if (check == tail)
                {
                    tailCount++;
                    Console.WriteLine("Got Tails, tailCount: " + tailCount);
                }
            }
            Console.WriteLine("Number of Times Head Won: " + headCount);
            Console.WriteLine("Number of Times Tail Won: " + tailCount);
            if(headCount == tailCount)
            {
                Console.WriteLine("Its Tie");
            }
            else if (headCount==won)
            {
                Console.WriteLine($"head won by {headCount-tailCount}");
            }
            else if (tailCount == won)
            {
                Console.WriteLine($"tail won by {tailCount-headCount}");
            }
        }
        

    }
}
