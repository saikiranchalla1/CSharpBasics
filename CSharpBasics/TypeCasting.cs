using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class TypeCasting
    {
        static void Main1(string[] args)
        {
            // Implicit type conversion

            int numInt = 1000;

            double numDouble = numInt;

            /**
             * 
             * byte -> short, int, long, float, double
             * short -> int, long, float, double
             * int -> long, float, double
             * long -> float, double
             * float -> double
             * 
             */

            // Explicit type conversion

            numDouble = 1.23;

            numInt = (int) numDouble;


            Console.WriteLine(numDouble);
            Console.WriteLine(numInt);


            int numInt1 = 100;

            byte numByte = (byte) numInt1;

            Console.WriteLine(numInt1);
            Console.WriteLine(numByte);

            // string str = "100testing";
            string str = "100";

            int strToInt = Convert.ToInt32(str);

            Console.WriteLine("Converted value of str: " + strToInt);


            // built-in parse methods

            string str2 = "100";

            int strToInt2 = int.Parse(str2);

            Console.WriteLine("Parse method output:" + strToInt2);

            string str3 = "TRUE";

            bool strToBool = bool.Parse(str3);

            Console.WriteLine("Pase method output for Bool: " + strToBool);
            

            // TryParse

            string str4 = "100testing";
            bool isConverted = int.TryParse(str4, out numInt);

            if (isConverted)
            {
                Console.WriteLine("Conversion successful :" + numInt); 
            }
            else
            {
                Console.WriteLine("Conversion was not successful");
            }


        }
    }
}
