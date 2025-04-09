using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a program that checks if a number is even or odd using an if else statement
            int num;
            Console.WriteLine("Enter a number");
            num= int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} is odd an odd number");
            }
            Console.ReadLine();
            Console.ReadKey();

            // a program that checks if user is logged in using if statement
            bool LoggedIn = true;
            if (LoggedIn)
            {
                Console.WriteLine("Welcome");


            }
            Console.ReadLine() ;

            /*checks a driver’s speed and gives a warning or fine based on 
             how fast they’re going. using if-else-if statement   */

            int speed;
            Console.WriteLine("Please enter your speed");
            speed= int.Parse(Console.ReadLine());

            if (speed < 60)
            {
                Console.WriteLine("You are under the speed limit");
            }
            else if(speed >= 60 && speed <=80)
                {
                Console.WriteLine("You are slighty speedind");

            }
            else if( speed >= 80 && speed <= 100)
            {
                Console.WriteLine("Slow down, you are speeding");
            }
            else
            {
                Console.WriteLine("You are driving above the speed limit");
            }
            Console.ReadLine();
            //using a switch case statement create a program that will ask a user to enter a day and display an appropriate message

              Console.WriteLine("Please enter a day");
            string day= Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Moday ");
                    break;
                case "Tuesday":
                    Console.WriteLine("Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("That is not a day");
                        break;
                    

            }
            Console.ReadLine();



        }
    }
}
