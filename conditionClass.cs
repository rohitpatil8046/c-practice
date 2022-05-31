using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohitconsoleapp
{
    internal class conditionClass
    {
        public void OutPutMethod()
        {
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
                if (time < 10)
                {
                    Console.WriteLine("Morning Time");
                    if(time < 8)
                    {
                        Console.WriteLine("Good Morning");
                    }
                    else
                    {
                        Console.WriteLine("Morning");
                    }
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            Console.ReadKey();
        }
        

    }
}
