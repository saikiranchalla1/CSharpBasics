using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Strings
    {
        static void Main1(string[] args)
        {
            // string == char[]

            // strings are reference types

            int aInt = 10;
            double aDouble = 10;

            string aStr = "abc";

            String anotherString = String.Concat(" "); // "abc";


            // Strings are immutable

            string str = "";

            StringBuilder stringBuilder = new StringBuilder();


            // str = "Google";

            int counter = 0;

            Console.WriteLine("Loop started");
            var stopWatch = new Stopwatch();

            stopWatch.Start();

            for (int i = 0; i < 10000; i++)
            {
                // str = Guid.NewGuid().ToString();
                // str = "DELL Technologies" ;
                // counter = counter + 1;

                // str = "DELL Technologies" + str;
                stringBuilder.Append("DELL Technologies");
            }
            
            stopWatch.Stop();

            Console.WriteLine("Loop ended");

            Console.WriteLine("Loop execution time:" + stopWatch.ElapsedMilliseconds);

        }
    }
}
