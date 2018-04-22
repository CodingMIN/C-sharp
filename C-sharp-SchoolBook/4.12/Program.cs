using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t, count = 1;
            bool flag;
            Console.Write(2 + "\t");
            for(n=3;n<=100;n+=2)
            {
                flag = true;
                for (t = 2; t <= (int)Math.Sqrt(n); t++)
                {
                    if (n % t == 0) flag = false;
                }
                if(flag)
                {
                    count++;
                    Console.Write(n + "\t");
                    if (count % 5 == 0) Console.WriteLine();
                }
            }
            Console.WriteLine("素数个数为:" + count);
        }
    }
}
