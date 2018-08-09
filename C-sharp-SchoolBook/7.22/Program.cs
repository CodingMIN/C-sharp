using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._22
{
    class classA
    {
        public int Divide(int a,int b)
        {
            if (b == 0)
                throw new DivideByZeroException("除数不能为0!");
            else
                return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            classA a = new classA();
            try
            {
                Console.Write("请输入被除数x:");
                x = int.Parse(Console.ReadLine());
                Console.Write("请输入除数y:");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("商为:{0}", a.Divide(x, y));
            }
            catch(FormatException e)
            {
                Console.WriteLine("处理异常:{0}", e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("处理异常:{0}", e.Message);
            }
        }
    }
}
