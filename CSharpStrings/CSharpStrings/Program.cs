using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to check if a string is an empty or undefined string
            var quickbrown = "the quick brown fox";

            Console.WriteLine(string.IsNullOrEmpty("")); //true
            Console.WriteLine(string.IsNullOrEmpty("quickbrown")); //false

            Console.WriteLine(quickbrown.Split(' ')); // ["the", "quick", ...] 
            

            //C# automatically replaces all the instances of a character in a string...there is no replace all method

            Console.ReadLine();
        }
    }
}
