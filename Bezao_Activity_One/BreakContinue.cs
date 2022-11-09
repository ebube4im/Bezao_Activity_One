using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezao_Activity_One
{
    public class BreakContinue
    {

        public void Run()
        {
            int count = 0;
            while ( count++ < 20 )
            {
                Console.WriteLine(count);

                if (count == 7)
                {
                    Console.WriteLine("You have reached a Perfect Number {0}", count);
                    break;
                }


                if (count % 2 == 0)
                {
                    Console.WriteLine("You have got an even Number {0}", count);
                }
            }


        }
    }
}
