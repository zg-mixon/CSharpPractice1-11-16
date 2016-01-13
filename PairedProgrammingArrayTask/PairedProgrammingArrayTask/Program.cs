using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedProgrammingArrayTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paired Task: Reverse Sentence Words
            Console.WriteLine("Enter a sentence here:");
            string sentence = Console.ReadLine();
            string[] splitArray = sentence.Split(' ');
            Array.Reverse(splitArray);
            Console.WriteLine(string.Join(" ", splitArray));

            Console.ReadLine();


        }
    }
}
