using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个月份:");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 2:
                case 3:Console.WriteLine("第一季度");break;
                case 4:
                case 5:
                case 6:Console.WriteLine("第二季度");break;
                case 7:
                case 8:
                case 9:Console.WriteLine("第三季度");break;
                case 10:
                case 11:
                case 12:Console.WriteLine("第四季度");break;
                default:Console.WriteLine("输错了，没有这个月份!");break;
            }
        }
    }
}
