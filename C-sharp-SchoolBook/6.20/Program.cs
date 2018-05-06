using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._20
{
    class Myclass
    {
        public void Volume(int length, int width, int height)
        {
            int f = length * width * height;
            Console.WriteLine("长方体体积为{0}", f);
        }
        public void Volume(int radius)
        {
            float f = 4 * 3.14f * radius * radius * radius / 3;
            Console.WriteLine("球体积为{0}", f);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            my.Volume(3);
            my.Volume(3, 4, 5);
        }
    }
}
