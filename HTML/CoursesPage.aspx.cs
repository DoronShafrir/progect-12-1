using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using task_12.Mapping;
using task_12.Model;

namespace task_12.HTML
{
    public partial class CoursesPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CourseDB db = new CourseDB();
            Courses courses = db.SelectAll();
            string coursesList = "";
            foreach (var line in courses)
            {
                foreach (Course item in line) { 
                coursesList += item.CourseName;
                
                }
                coursesList += "<br>";
            }
            courseList.InnerHtml = coursesList;
        }
    }
}