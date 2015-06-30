using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAddAndMultOp
{
    class Program
    {
        static void Main(string[] args)
        {
            // + 
            Console.WriteLine("Addition");
            Console.WriteLine(" 5 + 5 = {0} as Int", 5 + 5);         // addition Int
            Console.WriteLine(" 5 + .5 = {0} as Double", 5 + .5);    // addition Double
            Console.WriteLine("\"5\" + \"5\" = {0} as String", "5" + "5"); // string concatenation
            Console.WriteLine(" 5.0 + \"5\" = {0} as String", 5.0 + "5"); // string concatenation 
            Console.ReadLine();

            // -
            Console.WriteLine("Subtraction");
            Console.WriteLine(" 5 - 1 = {0} as Int", 5 - 1); // int
            Console.WriteLine(" 5 - .5 = {0} as Double", 5 - .5); //double

            Console.ReadLine();


            // * 
            //Also use to declare pointers in unsafe code
            Console.WriteLine("Multiplication");
            Console.WriteLine(" 5 * 2 = {0} as Int", 5 * 2); // int
            Console.WriteLine("-.5 * .2= {0} as Double", -.5 * .2); // double
            Console.WriteLine("-.5m * .2m= {0} as Decimal", -.5m * .2m); // decimal type
            Console.ReadLine();
        


            // /
            Console.WriteLine("Division");
            Console.WriteLine(" 7 / 3 = {0} as Int", 7 / 3); // int
            Console.WriteLine("-7 / 3 = {0} as Int", -7 / 3); // int
            Console.WriteLine(" 7f / 3 = {0} as Float", 7f / 3); // float

            Console.WriteLine("8 / 5 = {0} as Int", 8 / 5); // int
            Console.WriteLine("8 / -5 = {0} as Int", 8 / -5); // int
            Console.WriteLine("8 / 5.0 = {0} as Double", 8 / 5.0); // double
            Console.ReadLine();

            // %
            Console.WriteLine("Mod"); 
            Console.WriteLine(" 5 % 2 = {0} as Int", 5 % 2);       // int
            Console.WriteLine("-5 % 2 = {0} as Int",  -5 % 2);      // int
            Console.WriteLine(" 5.0 % 2.2 = {0} as Double",  5.0 % 2.2);   // double
            Console.WriteLine(" 5.0m % 2.2m = {0} as Decimal", 5.0m % 2.2m); // decimal
            Console.WriteLine("-5.2 % 2.0 = {0} as Double", -5.2 % 2.0);  // double
            Console.ReadLine();

        }
    }
}
