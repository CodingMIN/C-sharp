using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string m;
            int number = 0;
            m=Console.ReadLine();
            foreach (char c in m)
            {
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U': number++;
                        break;

                }
            }
            Console.WriteLine("元音个数为：" + number);
        }
    }
}
