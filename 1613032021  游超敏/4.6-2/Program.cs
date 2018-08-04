using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, sum = 0;
            for (int i = 1; i <= 10; i++){
                int k=1;
                for (int m = 1; m <= i; m++)
                {
                    k *= m;
                }
                sum += k;
            }
            Console.WriteLine("1到10的阶乘和为" + sum);
        }
    }
}
