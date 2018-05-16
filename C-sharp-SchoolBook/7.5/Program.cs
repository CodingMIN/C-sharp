using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5
{
    class Program
    {
        interface IMyInterface
        {
            int Add(int x, int y);
            string Name
            {
                get;
                set;
            }
            int this[int index]
            {
                get;
                set;
            }
        }
        static void Main(string[] args)
        {
          
        }
    }
}
