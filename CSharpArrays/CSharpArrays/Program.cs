

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shorthand for writing arrays in C#...this is an anonymous constructor
            var colors = new string[] {
    "Red", "Green", "Blue"
};
            //Regular ole Non-Shorthand for writing arrays in C#
            var colors1 = new string[3];
            colors[0] = "Red";
            colors[1] = "Green";
            colors[2] = "Blue";

            //Individual Task of Pulling Indexes out of an Arry
            var newsHeadline = new string[] {
                "Your mom fell down and caused an earthquake!",
                "Your mom was so ugly her reflection has fled and cannot be found!",
                "Your mom is so mean you grew up to be an awful person with emotional scarring!"
            };

            Random rnd = new Random();
            int rndPick = rnd.Next(0, newsHeadline.Length);
            Console.WriteLine(newsHeadline[rndPick]);

            Console.ReadLine();

            }
        }
    }

