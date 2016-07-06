using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myconsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_input = "";
            string inputS = "";
            string email = "";
            string phoneN = "";
            string response = "";
            Console.WriteLine("Hello World");
            user_input = Console.ReadLine();
            Console.WriteLine("Hello " + user_input);
            inputS = Console.ReadLine();
            
            if (inputS == "who are you")
            {
                Console.WriteLine("I am Emma");
                Console.WriteLine("What is your email?");
                email = Console.ReadLine();
                Console.WriteLine("What is your phone number?");
                phoneN = Console.ReadLine();
                Console.WriteLine("So you Are " + user_input + " Your email is " + email + " and Your phone number is " + phoneN);
                Console.WriteLine("Are you my admin?");
                response = Console.ReadLine();
                if (response == "yes")
                {
                    string userN = "";
                    string pssw = "";
                    Console.WriteLine("Please enter username");
                    userN = Console.ReadLine();
                    Console.WriteLine("Plase enter password");
                    pssw = Console.ReadLine();
                    if (userN == "admin" && pssw == "blackhat") 
                    {
                        Console.WriteLine("Welcome Back admin, how can i be of service :-)");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadLine();
                    }

                }
                else 
                {
                    Console.WriteLine("Too Bad");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadLine();
                }
            }
            else 
            {
                Console.WriteLine("You did not ask who i am. Piss Off Jerk ");
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();

            }

        }
    }
}
