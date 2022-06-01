using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohitconsoleapp
{
    internal class Datatypes
    {
        public void show()
        {

            int i = 11;
            long l = 8478797847;
            float f = 9.87F;
            double d = 99.23D;
            String name = "Rohit";
            bool result = true;
            char mh = 'a';
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(name);
            Console.WriteLine(mh);
            Console.WriteLine(result);
            Console.WriteLine("Enter Username:");
            String Username = Console.ReadLine();
            Console.WriteLine("Username is: " + Username);
            Console.ReadLine();

        }
    }
}