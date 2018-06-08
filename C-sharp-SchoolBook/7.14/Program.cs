using _7._14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._14
{
    class ClassA
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
}

class ClassB:ClassA
{
    public void Volume(int radius,int height)
    {
        double f = (3.14 * radius * radius * height) / 3;
        Console.WriteLine("圆锥体积为{0}", f);
    }
}
class Program
{
    static void Main(string[] args)
    {
        ClassA a = new ClassA();
        ClassB b = new ClassB();
        a.Volume(3);
        a.Volume(1, 2, 3);
        b.Volume(3);
        b.Volume(1, 2, 3);
        b.Volume(1, 3);
     }
 }

