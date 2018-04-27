using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[8] { 14, 25, 7, 36, 53,3,2,7 };
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        int tmp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = tmp;
                    }
                }
            }
            foreach(int tmp in myArray)
            {
                Console.Write("{0} ", tmp);
            }
            Console.WriteLine();
        }
    }
}
