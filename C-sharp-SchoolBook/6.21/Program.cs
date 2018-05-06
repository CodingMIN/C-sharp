using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._21
{
    struct MyStruct
    {
        public void Volume(int length,int width,int height)
        {
            Console.WriteLine("长方体体积为{0}", length * width * height);
        }
        public void Volume(int radius)
        {
            float f = 4 * 3.14f * radius * radius * radius / 3;
            Console.WriteLine("球体积为{0}", f);
        }
        public void Volume(int radius,params int[]a)
        {
            Console.WriteLine("params");
        }
        //以下两个方法参数列表相同，仅ref和out不同，不能重载
        /*
         * public void Volume(ref int radius)
         * {
         *   Console.WriteLine("ref");
         *   }
         *   */
         public void Volume(out int radius)
        {
            radius = 1;
            Console.WriteLine("out");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct my;
            my.Volume(3);
            my.Volume(3, 4, 5);
            my.Volume(3, 4, 5, 6);
            int i = 4;
            //my.Volume(ref i);
            my.Volume(out i);
        }
    }
}
