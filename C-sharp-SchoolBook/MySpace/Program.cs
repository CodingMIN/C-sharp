
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_TEST
{
    class MySpace
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public MySpace(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
        }
        public static void Print(MySpace a)
        {
            Console.WriteLine("X=" + a.x + "Y=" + a.y + "Z=" + a.z);
        }
        public static double Distance(MySpace a)
        {
            return Math.Sqrt(Math.Pow(a.x, 2) + Math.Pow(a.y, 2) + Math.Pow(a.z, 2));
        }
        public static double Distance(MySpace a, MySpace b)
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2) + Math.Pow(a.z - b.z, 2));
        }

        public static Boolean operator >=(MySpace a, MySpace b)
        {
            if (Distance(a) >= Distance(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator <=(MySpace a, MySpace b)
        {
            if (Distance(a) <= Distance(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double Area(MySpace a, MySpace b, MySpace c)
        {
            double s1;
            double s2;
            double s3;
            double sin;
            double cos;
            s1 = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Sqrt(Math.Pow(a.y - b.y, 2) + Math.Sqrt(Math.Pow(a.z - b.z, 2))));
            s2 = Math.Sqrt(Math.Pow(c.x - b.x, 2) + Math.Sqrt(Math.Pow(c.y - b.y, 2) + Math.Sqrt(Math.Pow(c.z - b.z, 2))));
            s3 = Math.Sqrt(Math.Pow(a.x - c.x, 2) + Math.Sqrt(Math.Pow(a.y - c.y, 2) + Math.Sqrt(Math.Pow(a.z - c.z, 2))));
            cos = (Math.Pow(s1, 2) + Math.Pow(s2, 2) - Math.Pow(s3, 2));
            sin = Math.Sqrt(1 - Math.Pow(cos, 2));
            return 1 / 2 * s1 * s2 * sin;
        }

        public static void MaxMin(out MySpace a, out MySpace b, MySpace[] c, int d)
        {
            a = c[0];
            b = c[0];
            for (int i = 0; i < d; i++)
            {
                if (Distance(a) <= Distance(c[i])) a = c[i];
                if (Distance(b) >= Distance(c[i])) b = c[i];
            }
        }
        public static void MaxTriangle(MySpace a, MySpace[] b, int c)
        {
            double area = Area(b[0], b[1], b[3]);
            for (int i = 0; i < c; i++)
                for (int m = i + 1; m < c; m++)
                    for (int k = m + 1; k < c; k++)
                    {
                        if (area < Area(b[i], b[m], b[k])) area = Area(b[i], b[m], b[k]);
                    }
            Console.WriteLine(area);

        }
    }
}
