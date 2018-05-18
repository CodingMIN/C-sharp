using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._12
{
    class ClassA { }
    class ClassB { }
    class SubClassC : ClassA { }
    class Program
    {
        static void Main(string[] args)
        {
            object[] objArray = new object[7];
            objArray[0] = new ClassA();
            objArray[1] = new ClassB();
            objArray[2] = "hello";
            objArray[3] = 123;
            objArray[4] = 123.4;
            objArray[5] = null;
            objArray[6] = new SubClassC();
            for (int i = 0; i < objArray.Length; ++i)
            {
                Console.Write("第{0}个元素:", i);
                string s = objArray[i] as string;
                if (s != null)
                {
                    Console.WriteLine("'" + s + "'");
                }
                else
                {
                    Console.WriteLine("不是字符串!");
                }
            }
                for (int i = 0; i < objArray.Length; ++i)
                {
                    Console.Write("第{0}个元素:", i);
                    ClassA a = objArray[i] as ClassA;
                    if (a != null)
                    {
                        Console.WriteLine("objArray[{0}]可以转换成ClassA类型对象", i);
                    }
                    else
                    {
                        Console.WriteLine("objArray[{0}]不能转换成ClassA类型对象", i);
                    }
                }
            }
        }
    }

