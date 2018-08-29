using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> age_1 = 20;
            DateTime? birthday_1 = null;
            int age_2;
            DateTime birthday_2;
            if (age_1.HasValue)
                age_2 = age_1.Value;
            else
                age_2 = 22;
            if (birthday_1 != null)
                birthday_2 = (DateTime)birthday_1;
            else
                birthday_2 = DateTime.Parse("1990/1/1");
            Console.WriteLine("年龄:{0}", age_2);
            Console.WriteLine("出生日期:{0}", birthday_2);

            age_1 = null;
            age_2 = age_1.GetValueOrDefault();
            birthday_2 = birthday_1.GetValueOrDefault();
            Console.WriteLine();
            Console.WriteLine("年龄:{0}", age_2);
            Console.WriteLine("出生日期:{0}", birthday_2);
        }
    }
}
