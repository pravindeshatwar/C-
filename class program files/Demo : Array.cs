using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{

    class Program
    {
         static void Main(string[] args)
        {
            var n = new int[5];
                n[0] = 1;
                n[1] = 2;
                n[2] = 3;
            Console.WriteLine(n[0]);
            Console.WriteLine(n[1]);
            Console.WriteLine(n[2]);

            var flags = new bool[4];
            Console.WriteLine(flags[0]);

            var names = new string[5] { "asdc", "sefsd", "fsefs" , "fvds","vsv"};
            Console.WriteLine(names[4]);
        }

    }
}
