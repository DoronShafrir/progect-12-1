using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using task_12.Model;

namespace task_12.Mapping
{
    public class CourseDB
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Physics.mdf;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public CourseDB()
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }
        public Courses SelectAll()
        {
            Courses courses = new Courses();
            command.CommandText = "SELECT * FROM Courses";
            
            
            try
            {
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();
                Course course;
                while (reader.Read())
                {
                    course = new Course();
                    course.CId = (int)reader["CId"];
                    course.CourseName = reader["CourseName"].ToString();
                    course.CourseNumber = reader["CourseNumber"].ToString();
                    course.ResponsibleTeacher = reader["ResponsibleTeacher"].ToString();
                    courses.Add(course);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return courses;

        }
    }
}