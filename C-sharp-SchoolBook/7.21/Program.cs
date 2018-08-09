using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._21
{
    class ClassA
    {
        public virtual void Print()
        {
            Console.WriteLine("ClassA");
        }
    }

    class ClassB:ClassA
    {
        public override void Print()
        {
            Console.WriteLine("ClassB");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a;
            ClassB b;
            int[] t = new int[] { 100, 200, 300, 400 };
            int x;
            Console.WriteLine("输入整数1或2，选择要创建的对象1：ClassA 2：ClassB");
            try
            {
                string s = Console.ReadLine();
                x = int.Parse(s);        //可能会引起FormatException异常
                if(x==1)
                {
                    a = new ClassA();
                }
                else
                {
                    a = new ClassB();
                }
                b = (ClassB)a;           //可能会引起InvalidCastException异常
                b.Print();
                Console.Write("请输入要输出的数组t的元素编号：");
                s = Console.ReadLine();
                x = int.Parse(s);           //可能会引起FormatException异常
                Console.Write("数组第{0}个元素的值为：", x);
                Console.WriteLine(t[x]);         //可能会引起IndexOutOfRangeException异常
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine("处理异常:{0}", e.GetType().Name);
            }
            catch(FormatException e)
            {
                Console.WriteLine("处理异常:{0}", e.GetType().Name);
            }
            catch(Exception e)
            {
                Console.WriteLine("处理异常:{0}", e.GetType().Name);
            }
        }
    }
}
