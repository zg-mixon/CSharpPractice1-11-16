using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the first line of code to run
            //Typescript: console.log
            Console.WriteLine("hello World!");

            //Typescript: Math.random() - 0 - 1;

            Random rand = new Random();
            var myNum = rand.Next(11, 20);
            Debug.Assert(myNum >= 5 && myNum < 10, "Oops! myNum is out of range :(");
            Console.WriteLine(myNum);

            //these are the same 
            bool blah = true;
            Boolean blah1 = true;


            //Individual Task - Working with .NET Classes
            var now = DateTime.Now;
            Console.WriteLine(now);

            //TS Variables: let varName: type
            //C# variables: type varName

            // string data type
            var message = "Hello World!";

            // char data type
            var letter = 'A';

            // decimal data type
            var price = 34.55m;

            // double data type
            var totalGrainsOfSandOnEarth = 5d;

            // float data type
            var weightOfPlanetEarth = 5f;

            // int data type
            var unitsInStock = 7;

            // long data type
            var countOfStars = 8978979893432434234;

            //How to add multiple user inputs

            // get first number
            Console.Write("Enter the first number:");
            var firstNum = int.Parse(Console.ReadLine());

            // get second number
            Console.Write("Enter the second number:");
            var secondNum = int.Parse(Console.ReadLine());

            // display result
            var result = firstNum + secondNum;
            Console.WriteLine("The result is " + result.ToString());

            // pause
            Console.ReadLine();

            Console.ReadLine();

            
        }
    }
}
