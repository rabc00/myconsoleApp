using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myconsoleApp
{
    public class User
    {
        public string Name; public string phoneN; public string email;


    }







    class Program
    {
        static void Main(string[] args)
        {

            User user_object = new User();


           // string user_input = "";
            string inputS = "";
            //string email = "";
            //string phoneN = "";
            string response = "";
            Console.WriteLine("Hello World");
            user_object.Name = Console.ReadLine();
            Console.WriteLine("Hello " + user_object.Name);
            inputS = Console.ReadLine();
            
            if (inputS == "who are you")
            {
                Console.WriteLine("I am Emma");
                Console.WriteLine("What is your email?");
                user_object.email = Console.ReadLine();
                Console.WriteLine("What is your phone number?");
                user_object.phoneN = Console.ReadLine();
                Console.WriteLine("So you Are " + user_object.Name + " Your email is " + user_object.email + " and Your phone number is " + user_object.phoneN);
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
                    Console.WriteLine("Too Bad. We have nothing to talk about");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadLine();
                }
            }//If InputS Terminates
            else 
            {
                Console.WriteLine("You did not ask who i am. Piss Off Jerk ");
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();

            }

            user_object.Name = "Name: " + user_object.Name + "; ";
            user_object.phoneN = "Phone Number: " + user_object.phoneN + "; ";
            user_object.email = "E-Mail: " + user_object.email + "; ";

           /* string[] lines = {user_object.Name, user_object.phoneN, user_object.email};

            System.IO.File.WriteAllLines(@"E:\aspnet\myconsoleApp\Records.txt", lines);
            */






        }//Main Ends
    }
}
