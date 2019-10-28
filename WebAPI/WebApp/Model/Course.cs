using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }

        public Course(int pcourseid, string pcoursename)
        {
            CourseID = pcourseid;
            CourseName = pcoursename;
        }
    }
}
