using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{


    public class person
    {
        public string FirstName;
        public string LastName;

        public void introduce()
        {
            Console.WriteLine(" My name is "+ FirstName + " "+ LastName );
        }
    } 

    class Program
    {
         public static void Main(string[] args)
        {
            var pravin = new person();
            pravin.FirstName = "Pravin";
            pravin.LastName = "Deshatwar";
            pravin.introduce();
        }
    }
}
    
