using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteToBinaryLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intergers with and without sign +/- 
            //*********Signed***************
            //SByte
            //Short
            //int
            //long

            // -|64|32|16|8|4|2|1  BASE -1
            // +|64|32|16|8|4|2|1  BASE  0
            


            //********UnSigned**************
            //Byte
            //Ushort
            //uint
            //ulong

            // 128|64|32|16|8|4|2|1
          


            for (int i = sbyte.MinValue; i < sbyte.MaxValue; i++)
            {
                Console.WriteLine(String.Format("{0}\t {1}", i, Convert.ToString(i, 2).PadLeft(32, '0')));
            }

            Console.WriteLine("*************************************** INT");
            Console.WriteLine(String.Format("{0}\t {1}", int.MaxValue, Convert.ToString(int.MaxValue, 2).PadLeft(32, '0')));
            Console.WriteLine(String.Format("{0}\t {1}", int.MinValue, Convert.ToString(int.MinValue, 2).PadLeft(32, '0')));

            Console.WriteLine("*************************************** UINT");
            Console.WriteLine(String.Format("{0}\t {1}", uint.MaxValue, Convert.ToString(uint.MaxValue, 2).PadLeft(32, '0')));
            Console.WriteLine(String.Format("{0}\t\t {1}", uint.MinValue, Convert.ToString(uint.MinValue, 2).PadLeft(32, '0')));
            Console.ReadKey();
        }
    }
}
