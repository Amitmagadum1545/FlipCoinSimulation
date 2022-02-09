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
            int check = random.Next(0, 2);
            int head = 1, tail = 0;
            if (check == head)
            {
                Console.WriteLine("Heads");
            }
            else if (check == tail)
            {
                Console.WriteLine("Tails");
            }
        }
        

    }
}
