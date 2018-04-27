using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5] { 14, 25, 7, 36, 53 };
            foreach (int number in myArray)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            for(int i=0;i<myArray.Length;i++)
            {
                Console.Write("{0} ", myArray[i]);

            }
            Console.WriteLine();
        }
    }
}
