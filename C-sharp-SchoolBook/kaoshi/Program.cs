using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaoshi
{
    class Program
    {

        class MySpace
        {
            public int X
            {
                set;
                get;
            }
            public int Y
            {
                set;
                get;

            }
            public int Z
            {
                set;
                get;
            }

            public MySpace(int X, int Y, int Z)
            {
                this.X = X;
                this.Y = Y;
                this.Z = Z;
            }

            public void Print(MySpace cm)
            {

                Console.WriteLine("坐标X的值为" + cm.X + "坐标Y的值为" + cm.Y + "坐标Z的值为" + cm.Z);
            }

            public double Distance()
            {
                double distance = Math.Sqrt(Math.Pow((X - 0) , 2) +Math.Pow( (Y - 0) , 2) +Math.Pow( (Z - 0) , 2));
                return distance;
            }

            public double Distance(MySpace cm1, MySpace cm2)
            {
                double distance = Math.Sqrt(Math.Pow((cm1.X - cm2.X) , 2) + Math.Pow((cm1.Y - cm2.Y) , 2) +Math.Pow( (cm1.Z - cm2.Z) , 2));
                return distance;
            }

            public static bool operator >=(MySpace cm1, MySpace cm2)
            {
                if (cm1.Distance() >= cm2.Distance())
                    return true;
                else
                    return false;
            }

            public static bool operator <=(MySpace cm1, MySpace cm2)
            {
                if (cm1.Distance() <= cm2.Distance())
                    return true;
                else
                    return false;
            }
            public static double Area(MySpace a, MySpace b, MySpace c)
            {
                double s1;
                double s2;
                double s3;
                double sin;
                double cos;
                s1 = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
                s2 = Math.Sqrt(Math.Pow(c.X - b.X, 2) + Math.Pow(c.Y - b.Y, 2) + Math.Pow(c.Z - b.Z, 2));
                s3 = Math.Sqrt(Math.Pow(a.X - c.X, 2) + Math.Pow(a.Y - c.Y, 2) + Math.Pow(a.Z - c.Z, 2));
                cos = (Math.Pow(s1, 2) + Math.Pow(s2, 2) - Math.Pow(s3, 2));
                sin = Math.Sqrt(1 - Math.Pow(cos, 2));
                return 1 / 2 * s1 * s2 * sin;
            }


            public void MaxMin(int [] Spaces,out int max,out int min)
             {
                max = Spaces[0];
                min = Spaces[0];
                for(int i=0;i<Spaces.Length;i++)
                {
                    if(max<=Spaces[i])
                    {
                        max = Spaces[i];
                    }
                    if(min>=Spaces[i])
                    {
                        min = Spaces[i];
                    }
                }
             }

            private static void Main(String[] args)
            {
                MySpace[] Spaces = new MySpace[]
                {
                   new MySpace(3, 4, 5),
                   new MySpace(3, 4, 5),
                   new MySpace(7, 8, 9),
                   new MySpace(2, 3, 3),
                   new MySpace(3, 4, 2)
               };
               
            }
        }
    }
}

