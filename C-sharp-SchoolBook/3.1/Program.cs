using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 200;
            object o = n;  //装箱
            o = 201;       //修改对象o的值，而n的值不变
            Console.WriteLine("{0},{1}", n, o);        //A
            object i = 20;
            int j = (int)i;
            Console.WriteLine(j);
        }
    }
}
