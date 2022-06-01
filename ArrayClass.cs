using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohitconsoleapp
{
    internal class ArrayClass
    {
        public void show()
        {
            int[] array = { 20, 30, 40, 50 };
            Console.WriteLine(array[0]);
            
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
                foreach (int j in array)
                {
                    Console.WriteLine(j);

                }
                
           
            Console.ReadKey();
        }
    }
}
