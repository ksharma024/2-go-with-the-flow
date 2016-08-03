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
            while (true)
            {
                Console.WriteLine("Hello! Are you feeling hungry? (Yes/No/Maybe)");
                string answer = Console.ReadLine();

                //Answer "Yes" or "No"


                if (answer == "Yes")
                {
                    Console.WriteLine("Ok would you like to eat something healthy or junk food?");
                    string food = Console.ReadLine();

                    if (food == "healthy")
                        Console.WriteLine("Great choice! Here is an apple!");

                    else if
                        (food == "junk food")
                        Console.WriteLine("Fine it's your body after all...here have an ice cream sundae.");
                }


                else if (answer == "No")
                {
                    Console.WriteLine("Oh are you sure? (Yes/No)");
                    string reply = Console.ReadLine();

                    if (reply == "Yes")
                        Console.WriteLine("Ok, I won't ask you again, have a nice day!");
                    else if (reply == "No")
                        Console.WriteLine("Ok well think about and come find me.");
                }

                else if (answer == "Maybe")
                    Console.WriteLine("Hmm well maybe you should have a glass of water and I'll come back and ask you later.");


                Console.ReadKey();
            }



        }
    }
}
