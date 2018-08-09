using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string s;
            try
            {
                Console.Write("请输入一个除数:");
                s = Console.ReadLine();
                a = int.Parse(s);
                Console.Write("请输入一个被除数:");
                s = Console.ReadLine();
                b = int.Parse(s);
                Console.WriteLine("积为{0}", a * b);//若输入3、0积放上面可以显示，放下面显示不出来
                Console.WriteLine("商为{0}", a / b);
                
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("处理异常:{0}", e.GetType().Name);
            }
            catch(FormatException e)
            {
                Console.WriteLine("处理异常:{0}", e.GetType().Name);
            }
            finally
            {
                Console.WriteLine("必须要运行的finally语句块代码");
            }
            Console.WriteLine("继续运行程序，直到产生其他异常或程序结束");
        }
    }
}
