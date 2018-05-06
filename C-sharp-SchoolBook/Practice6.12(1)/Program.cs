using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6._12_1_
{
    enum Gender { 男, 女 };           //枚举
    class Student
    {
        String name;             //姓名
        String id;               //学号
        Gender sex;              //性别
        int age;
        public int Age           //自动实现的年龄属性
        {
            get;
            set;
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public String ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public Gender Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }
        public Student(string name,string id,int age, Gender sex=Gender.男)  //构造函数，sex初始值 男
        {
            this.name = name;
            this.id = id;
            Age = age;
            this.sex = sex;
            
        }
    }

    struct CourseScore
    {
        private string course;            //课程名称
        private int score;                //课程成绩
        public string Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }
        public CourseScore(string course,int score=100)   //构造函数，score初始值100
        {
            this.course = course;
            this.score = score;
        }

    }

    class StudentScore
    {
        private ArrayList lstScore;   //课程成绩列表字段
        private Student student;     //学生信息字段
        public CourseScore this[int x]
        {
            get { return (CourseScore)lstScore[x]; }
            set { lstScore[x] = value; }
        }
        public StudentScore(int n)
        {
            lstScore = new ArrayList(n);
        }
        public void AddStudent()
        {
            Console.WriteLine("输入学生姓名:");
            String name = Console.ReadLine();
            Console.WriteLine("输入学生学号:");
            String id = Console.ReadLine();
            Console.WriteLine("输入学生性别:");
            String Sex = Console.ReadLine();
            Gender sex;
            if(Sex=="男")
            {
                sex = Gender.男;
            }
            else
            {
                sex = Gender.女;
            }
            Console.WriteLine("输入学生的年龄:");
            int age = int.Parse(Console.ReadLine());
            student = new Student(name, id, age, sex);
        }

        public void AddCourseScore(int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("第" + (i + 1) + "门课程的名称为:");
                string name=Console.ReadLine();
                Console.WriteLine("第" + (i + 1) + "门课程的成绩为:");
                int score = int.Parse(Console.ReadLine());
                CourseScore s = new CourseScore(name, score);
                lstScore.Add(s);
            }
        }
        public void ShowStudentScore()
        {
            Console.WriteLine("学生的姓名为:{0},学号为:{1},年龄为:{2},性别为:{3}", student.Name, student.ID, student.Age, student.Sex);
            foreach(CourseScore c in lstScore)
            {
                Console.WriteLine("课程名称为" + c.Course + "的成绩为" + c.Score);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentScore[] s = new StudentScore[3];
            for(int i=0;i<3;i++)
            {
                s[i] = new StudentScore(3);
                s[i].AddStudent();
                s[i].AddCourseScore(3);
            }
            foreach(StudentScore a in s)
            {
                a.ShowStudentScore();
            }
        }
    }
}
