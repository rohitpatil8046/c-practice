using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohitconsoleapp
{
    internal class LoopClass
    {
        public void Show()
        {
            Console.WriteLine("For loop");
            for (int k = 0; k <= 10; k = k+2)
            {
                Console.WriteLine(k +"  Forloop");
            }
            Console.WriteLine("While loop");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i + "  whileloop");
                i++;
            }
            Console.WriteLine("do while loop");
            int j = 0;
            do
            {
                Console.WriteLine(j + "  doWhileloop");
                j++;
            }
            while (j < 5);

            Console.ReadKey();
        }
    }
}
