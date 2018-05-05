using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._17
{
    class Myclass
    {
        public void MaxVal(params int[] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                max = max < a[i] ? a[i] : max;
            }
            Console.WriteLine("最大值为{0}", max);
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            int[] a = new int[] { 20, 10, 50, 40, 30 };
            int x = 10, y = 20;
            my.MaxVal(a);
            my.MaxVal(x, y);
        }
    }
}
