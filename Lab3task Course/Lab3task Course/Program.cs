using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TaskCourse
{
    class Course
    {

        private String coursename;
        private String coursecode;
        private int coursecredit;
        public string courseName
        {
            get { return coursename; }
            set { coursename = value; }
        }
        public string courseCode
        {
            get { return coursecode; }
            set { coursecode = value; }
        }
        public int courseCredit
        {
            get { return coursecredit; }
            set { coursecredit = value; }
        }
        public Course(String coursename, String coursecode, int coursecredit)
        {
            this.coursename = coursename;
            this.coursecode = coursecode;
            this.coursecredit = coursecredit;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name :" + coursename);
            Console.WriteLine("Course Code :" + coursecode);
            Console.WriteLine("Course Credit :" + coursecredit);
        }

        static void Main(string[] args)
        {
            Course c1 = new Course("Bangladesh Studies", "7689", 10);
            c1.ShowInfo();
            Course c2 = new Course("Computer Graphics", "3309", 7);
            c2.ShowInfo();

        }
    }
}