using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7._7_3_
{    class ABCException : Exception
    { public override string Message
        { get { return "方程没有实根！"; } } }
    class ABC
    {
        private int a, b, c;
        private double delta;
        public ABC(int a, int b, int c)
        { this.a = a; this.b = b; this.c = c; delta = b * b - 4 * a * c; }
        public void GetRoot()//求方程的根        
        {             double x1, x2;
            if (delta < 0)
            {                 throw new ABCException();             }
            else if (delta == 0)

            {                 x1 = x2 = -b / (2.0 * a);
                Console.WriteLine("方程有两个相等的实根：x1=x2={0}", x1);             }
            else             {                 x1 = (-b + delta) / (2.0 * a);
                x2 = (-b - delta) / (2.0 * a);
                Console.WriteLine("方程有两不等的实根：x1={0}    x2={1}", x1,x2);
            }         }     }
    class Program     {         static void Main(string[] args)
        {             try             {
                Console.Write("请输入二元一次方程的系数a：");
                int a = int.Parse(Console.ReadLine());
                Console.Write("请输入二元一次方程的系数b：");
                int b = int.Parse(Console.ReadLine());
                Console.Write("请输入二元一次方程的系数c：");
                int c = int.Parse(Console.ReadLine());
                ABC t = new ABC(a, b, c);
                t.GetRoot();             }
            catch (ABCException e)
            {                 Console.WriteLine(e.Message);             }
            catch (Exception e)             {                 Console.WriteLine(e.Message);             }         }     }
}
