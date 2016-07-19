using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Go_With_the_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Are you feeling hungry?");
            string answer = Console.ReadLine();
           



            if (answer == "Yes")
                Console.WriteLine("Ok here you go have a Snickers bar!");
            else if (answer == "No")
                Console.WriteLine("Oh ok well sorry for bothering you, have a good day!");
            else if (answer == "Maybe")
                Console.WriteLine("Hmm well maybe you should have a glass of water and I'll come back and ask you later.");
           

            Console.ReadKey();




        }
    }
}
