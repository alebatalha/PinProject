using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinProject
{
    class Program
    {
        static string correctPin = "0112";
         // the correctPin beeing a class program allow changing the Pin without changing the code. 
        static bool ValidatePin(string pin)
        {
            if (pin == correctPin)
            {
                return true;
            }
            // using a boolen sistem I can prove if the givin pin is coorect
            return false;
        }

        static void Main(string[] args)
        {
            string user;
            string password;
            Console.WriteLine("\n\nWelcome, please enter your user name:\n");
            user = Console.ReadLine();
            // this code is just for start and know the user name 
            Console.WriteLine("Welcome " + user);
            
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Please enter your password:    \n");
                password = Console.ReadLine();
                if (ValidatePin(password))
                {
                    Console.WriteLine("that is correct, You have entered the correct PIN number");
                    Console.WriteLine("press Enter to exit");
                    Console.ReadLine();
                    return;
                    // this is the loop for return the correct pin or don not
                } else
                {
                    Console.WriteLine("That was incorrect. You have entered and invalid PIN you have {0} of 3", j+1);
                    // Using j+ We can return the number of attemps. The counting in started a 0. 
                }
            }

            Console.WriteLine("press Enter to exit");
            Console.ReadLine();
        }
    }
}
