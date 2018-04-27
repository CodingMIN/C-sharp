using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable tb1 = new Hashtable();
            tb1.Add(1, 200);
            tb1.Add("pi", 3.14f);
            tb1.Add('A', 65);
            float mult = (int)tb1[1] * (float)tb1["pi"];            //A拆箱后进行运算
            Console.WriteLine(mult);
        }
    }
}
