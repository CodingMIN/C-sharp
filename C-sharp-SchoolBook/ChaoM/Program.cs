using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mylib;


namespace ChaoM
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation cm = new Calculation();
            cm.Area(3);
            cm.Area(1, 2, 3);
            cm.Area(2, 3);
            Console.WriteLine("Area()方法被调用的次数为:"+cm.GetCount());
        }
    }
}
