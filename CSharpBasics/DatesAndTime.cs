using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class DatesAndTime
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            dt = new DateTime();

            Console.WriteLine(dt);

            dt = new DateTime(2020, 12, 21);
            Console.WriteLine(dt);

            dt = new DateTime(2021, 12, 23, 5, 12, 12);
            Console.WriteLine(dt);

            dt = new DateTime(2012, 12, 12, 4, 12, 12, DateTimeKind.Utc);
            Console.WriteLine(dt);


        }
    }
}
