namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            byte b1 = 67;

            sbyte sb1 = -100;

            Console.WriteLine($"SByte Size : {sizeof(sbyte)} Byte");
            Console.WriteLine($"SByte MaxValue : {sbyte.MaxValue} Byte");
            Console.WriteLine($"SByte MinValue : {sbyte.MinValue} Byte");


            Int16 int16 = 123;
            Int32 int32 = 123;
            Int64 int64 = 123;


            Console.WriteLine(sizeof(Int16));
            Console.WriteLine(Int16.MinValue + " " + Int16.MaxValue);
            Console.WriteLine(sizeof(Int32));
            Console.WriteLine(Int32.MinValue + " " + Int32.MaxValue);

            Console.WriteLine(sizeof(Int64));
            Console.WriteLine(Int64.MinValue + " " + Int64.MaxValue);


            uint uInt = 123;

            ushort ushortInt = 123;

            ulong ulongInt = 123;


            Console.WriteLine(uint.MinValue + " " + uint.MaxValue);


            short numShort = 123;
            int numInt = 123;
            long numLong = 123;

            float numFloat = 123.123f; // single precision

            decimal numDecimal = 123.123M; // decimal floating point

            double numDouble = 1123; // double precision


            // Single, Double, Decimal

            float a = 1.78986380830029492956829698978655434342477f; //7 digits Maximum
            double b = 1.78986380830029492956829698978655434342477; //15 digits Maximum
            decimal c = 1.78986380830029492956829698978655434342477m; //29 digits Maximum

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // Characters = a, ^, & , *

            char ch = 'A';

            char chUnicode = '\u0041'; // \n, \\, \t

            // Booleans <- true or false

            bool boolVar = true; // false


            // base-10, base-2, base-16

            int numBinary = 0b10001;
            Console.WriteLine(numBinary);

            // sequence of characters Edward

            string edward = "We are learning \n DotNet using \t CSharp"; // verbatim string vs regular string literal

            string verbatimStr = @"We are learning \n DotNet using \t CSharp";

            Console.WriteLine(edward);
            Console.WriteLine(verbatimStr);

        }
    }
}