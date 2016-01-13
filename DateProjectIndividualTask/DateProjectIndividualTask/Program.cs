using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProjectIndividualTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a date in mm/dd/yyyy format: ");
            string userInput = Console.ReadLine();
            var userDate = DateTime.Parse(userInput);
            Console.WriteLine(userDate.ToLongDateString());


            Console.ReadLine();

        }
    }
}
