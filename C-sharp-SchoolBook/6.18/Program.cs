using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._18
{
    class Myclass
    {
        public void ConeVolume(int radius,int height)
        {
            float area = 3.14f * radius * radius * height / 3;
            Console.WriteLine("圆锥体的体积为{0}", area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            int r = 3; //圆锥半径
            int h = 4; //圆锥高
            my.ConeVolume(r, h);//正确
            my.ConeVolume(height: h, radius: r);//正确
            my.ConeVolume(h, r);  //错误
        }
    }
}
