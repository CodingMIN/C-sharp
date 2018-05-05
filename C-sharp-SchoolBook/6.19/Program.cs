using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._19
{
    class Myclass
    {
        public void CubeVolume(int length,int width=4,int height=3)
        {
            int area = length * width * height;
            Console.WriteLine("长方体体积为{0}", area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            my.CubeVolume(5);
            my.CubeVolume(5, 2);
            my.CubeVolume(5, 2, 1);
            my.CubeVolume(5, width: 1);
            my.CubeVolume(5, height: 1);
        }
    }
}
