using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class ControlFlow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Line 1");
            Console.WriteLine("Executing Line 2");
            Console.WriteLine("Executing Line 3");
            Console.WriteLine("Executing Line 4");
            Console.WriteLine("Executing Line 5");

            /**
             * Selection or branching
             * Iteration or looping
             * Jumping statements
             */

            int number;
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 10)
            /*Console.WriteLine($"{number} is greater than 10");*/
            {
                Console.WriteLine($"{number} is greater than 10");
                Console.WriteLine("End of if block");
            }
            else
            {
                Console.WriteLine($"{number} is less than 10");
                Console.WriteLine("End of else block");
            }


            int a = 20, b = 25, c = 10;
            int largestNumber = 0;

            if (a > b)
            {
                Console.WriteLine($"Outer IF block");
                if (a > c)
                {
                    Console.WriteLine("Outer IF - Inner IF block");
                    largestNumber = a;
                }
                else
                {
                    Console.WriteLine("Outer IF - Inner ELSE block");
                    largestNumber = c;
                }
            }
            else
            {
                Console.WriteLine("Outer ELSE block");
                if (b > c)
                {
                    Console.WriteLine("Outer ELSE - Inner IF block");
                    largestNumber = b;
                }
                else
                {
                    Console.WriteLine("Outer ELSE - Inner ELSE block");
                    largestNumber = c;
                }
            }

            Console.WriteLine($"The largest number is : {largestNumber}");



            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else if (number == 25)
            {
                Console.WriteLine("Numnber is 25");
            }
            else
            {
                Console.WriteLine("Number is not 10, 20 or 25");
            }


            // switch - case

            Console.WriteLine("Switch Case Demo");
            switch (number)
            {
                case 10: 
                    Console.WriteLine("Number is 10");
                    break;
                case 20: 
                    Console.WriteLine("Number is 20");
                    break;
                case 25: Console.WriteLine("Number is 25");
                    break;
                default: Console.WriteLine("Number is not 10, 20 or 25");
                    break;

            }


            string inputStr = "Web API";

            switch(inputStr)
            {
                case "C#":
                case "Java":
                case "C":
                case "Python":
                    Console.WriteLine("It is a programming language");
                    break;

                case "MySQL":
                case "MS SQL":
                case "Postgres":
                    Console.WriteLine("It is a database");
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }


            Console.WriteLine("End of Main block");


            // Looping - Counter Loop, Conditional loop

            for (int i = 1; i <= 10; i++ )
            {
                Console.WriteLine(i);
            }

            // While

            int x = 10;
            while (true) // entry checking
            {
                Console.WriteLine("Current vaule of x is : " + x);
                x++; //x = x + 1; <- post increment

                if (x <= 15)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("End value of x is " + x);

            Console.WriteLine("do while demo");
            
            // x = 10;
            
            do // exit checking
            {
                Console.WriteLine("Current value of x is " + x);
                x++;
            } while (x <= 15);


            Console.WriteLine("End value of x is " + x);

            // For loop


            Console.WriteLine("\n\nFor Loop demo");
            /* for (initialization; cndition; increment/decrement)
             {
                 // statements
             }*/

            int counter = 0;

            for (; counter <= 10; )
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("Final value of counter is " + counter);

        }
    }
}
