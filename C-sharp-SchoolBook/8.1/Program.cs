using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> age = 20;          //等同于int?age=20;
            DateTime? birthday = null;       //等同于Nullable<DateTime>birthday=null;
            if (age != null)                    //age.HasValue
                Console.WriteLine("年龄:{0}", age);
            else
                Console.WriteLine("年龄:无");
            if (birthday.HasValue)           //birthday!=null
                Console.WriteLine("出生日期:{0}", birthday);
            else
                Console.WriteLine("出生日期:无");
        }
    }
}
