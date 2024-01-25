using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_12.Model
{
    public class Course
    {
        public int CId { get; set; }
        public string CourseName { get; set; }
        public string CourseNumber { get; set; }
        public string ResponsibleTeacher { get; set; }
    }

    public class Courses : List<Course>
    {
        public Courses() { }

        public Courses(IEnumerable<Course> list)
            : base(list)
        {

        }



    }
}