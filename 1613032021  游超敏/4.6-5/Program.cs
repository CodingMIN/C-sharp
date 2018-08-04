using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0, pos = 0, neg = 0;
            int []a = new int[100];
            int t=1;//保存读入的数字
            int i = 0;//计数
            while (t!=0) {
                t = int.Parse(Console.ReadLine());//一个输入一个回车，遇0结束
                sum += t;
                if (t > 0) pos += 1;
                else if (t < 0) neg += 1;
                i+=1;
            }
            Console.WriteLine("和：" + sum + '\n' + "平均值：" + sum / i + '\n'+"正数个数："+pos+'\n'+"负数个数："+neg);
        }
    }
}
