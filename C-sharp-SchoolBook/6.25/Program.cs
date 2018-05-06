using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._25
{
    class Cuboid
    {
        private int h, w, l;
        public Cuboid(int height,int width,int length)
        {
            h = height;
            w = width;
            l = length;
        }
        public static bool operator < (Cuboid c1,Cuboid c2)   //重载"<"运算符
        {
            if (c1.h * c1.w * c1.l < c2.h * c2.w * c2.l)
                return true;
            else
                return false;
        }
        public static bool operator > (Cuboid c1,Cuboid c2)  //重载">"运算符
        {
            if (c1.h * c1.w * c1.l > c2.h * c2.w * c2.l)
                return true;
            else
                return false;
        }
        public static bool operator ==(Cuboid c1, Cuboid c2)  //重载"=="运算符
        {
            if (c1.h * c1.w * c1.l ==c2.h * c2.w * c2.l)
                return true;
            else
                return false;
        }
        public static bool operator != (Cuboid c1, Cuboid c2)  //重载"!="运算符
        {
            if (c1.h * c1.w * c1.l != c2.h * c2.w * c2.l)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cuboid c1 = new Cuboid(1, 2, 3);
            Cuboid c2 = new Cuboid(1, 2, 3);
            if (c1 < c2)
                Console.WriteLine("c1的体积小于c2");
            else if (c1 > c2)
                Console.WriteLine("c1的体积大于c2");
            else
                Console.WriteLine("c1的体积等于c2");
        }
    }
}
