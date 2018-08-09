using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._23
{
    class TriangleException : Exception
    {
        public override string Message
        {
            get
            {
                return "不能构成三角形!";
            }
        }
    }

    class Triangle
    {
        public double TriangleArea(int a,int b,int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                double p = (a + b + c) / 2.0;
                return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            }
            else
                throw new TriangleException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int[] w = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.Write("请输入三角形第{0}条边长:", i + 1);
                s = Console.ReadLine();
                int.TryParse(s, out w[i]);
            }
            Triangle t = new Triangle();
            try
            {
                double area = t.TriangleArea(w[0], w[1], w[2]);
                Console.WriteLine("三角形面积为:{0}", area);
            }
            catch(TriangleException e)
            {
                Console.WriteLine(e.Message + e.GetType().Name);
            }
        }
    }
}
