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
            var fname = "pravin";
            var lname = "deshatwar";
            var fullname = fname + " " + lname;
            Console.WriteLine(fullname);

            var myfullname = string.Format("My name is {0} {1}", fname, lname);
            Console.WriteLine(myfullname);
            
            
            var names = new string[3] { "a", "b", "c" };
            var formatnames = string.Join(",", names);
            Console.WriteLine(formatnames);
            
            
        }

    }
}
