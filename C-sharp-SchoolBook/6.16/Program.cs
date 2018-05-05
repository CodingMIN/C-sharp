using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._16
{
    class Myclass
    {
        public void MaxMinVal(int []a,out int max,out int min)
        {
            max = a[0];
            min = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if (max < a[i])
                    max = a[i];
                if (min > a[i])
                    min = a[i];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            int maxVal, minVal;
            int[] a = new int[] { 20, 10, 50, 40, 30 };
            my.MaxMinVal(a, out maxVal, out minVal);
            Console.WriteLine("最大值{0},最小值{1}", maxVal, minVal);
        }
    }
}
