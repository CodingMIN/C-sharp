using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCM
{
    class Program
    {
        class Student
        {
            public string Name
            {
                get;
                set;
            }
            public int CourseAmount
            {
                set;
                get;
            }
            private string [,] courseScore;
            public static int count=1;
            public static int count1 = 1;
            public Student()
            {
                Console.WriteLine("输入第{0}个学生的姓名:",count);
                Name = Console.ReadLine();
                Console.WriteLine("输入第{0}个学生的课程数:", count);
                CourseAmount = int.Parse(Console.ReadLine());
                courseScore = new String[CourseAmount, 2];
                count++;
            }
            public void InitCourseScore()
            {
                //Console.WriteLine("请输入{0}个课程及对应成绩", CourseAmount);

                for (int i = 0; i < CourseAmount; i++)
                {
                    Console.WriteLine("输入学生{0}的第{1}门课程的名称:", Name,i + 1);
                    courseScore[i, 0] = Console.ReadLine();
                    Console.WriteLine("输入学生{0}的课程{1}的成绩:", Name,  courseScore[i,0]);
                    courseScore[i, 1] = Console.ReadLine();
                }
                count1++;
            }
            public string this[int coursename, int score]   //索引器
            {
                get { return courseScore[coursename, score]; }
                
            }
            public static bool operator >=(Student s1, Student s2)
            {
                double ave1, ave2, sum = 0;
                for (int i = 0; i < s1.CourseAmount; i++)
                {
                    sum += Convert.ToDouble(s1.courseScore[i, 1]);
                }
                ave1 = sum / s1.CourseAmount;
                for (int i = 0; i < s2.CourseAmount; i++)
                {
                    sum += Convert.ToDouble(s2.courseScore[i, 1]);
                }
                sum = 0;
                ave2 = sum / s2.CourseAmount;

                if (ave1 >= ave2)
                    return true;
                else return false;

            }
            public static bool operator <=(Student s1, Student s2)
            {
                double ave1, ave2, sum = 0;
                for (int i = 0; i < s1.CourseAmount; i++)
                {
                    sum += Convert.ToDouble(s1.courseScore[i, 1]);
                }
                ave1 = sum / s1.CourseAmount;
                for (int i = 0; i < s2.CourseAmount; i++)
                {
                    sum += Convert.ToDouble(s2.courseScore[i, 1]);
                }
                sum = 0;
                ave2 = sum / s2.CourseAmount;

                if (ave1 <= ave2)
                    return true;
                else return false;

            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.InitCourseScore();
            for (int i = 0; i < s1.CourseAmount; i++)
            {
                Console.WriteLine("学生{0}的{1}的成绩为:{1}", s1.Name,s1[i, 0], s1[i, 1]);
            }
            s2.InitCourseScore();
            for (int i = 0; i < s2.CourseAmount; i++)
            {
                Console.WriteLine("学生{0}的{1}的成绩为:{1}", s2.Name, s2[i, 0], s2[i, 1]);
            }

            if (s1 >= s2)
                Console.WriteLine("学生{0}的平均分大于等于学生{1}",s1.Name,s2.Name);
            else Console.WriteLine("学生{0}的平均分小于学生{1}", s1.Name, s2.Name);
        }
    }
    
}
