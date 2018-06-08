using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylib
{
    public class Calculation
    {
        public void Area(int radius)
        {
            float f = 3.14f * radius * radius;
            Console.WriteLine("圆的面积为{0}", f);
            count++;
        }
        public void Area(int length,int width,int height)
        {
            int f = (length*width+width*height+length*height)*2;
            Console.WriteLine("长方体的面积为{0}", f);
            count++;
        }
        public void Area(int bottom,int height)
        {
            double f = 0.5* (bottom * height);
            Console.WriteLine("三角形的面积为{0}", f);
            count++;
        }
        private static int count=0;
      
        public int GetCount()
        {
            return count;
        }
    }
}
