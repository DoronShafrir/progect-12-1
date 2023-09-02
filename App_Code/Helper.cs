using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace task_12.App_Code
{
    public static class Helper
    {
        public const string DBName = "Database.mdf";
        public const string tblName = "Users";
        public const string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\Physics.mdf;Integrated Security=True";

        public static String FetchTable(string SQLStr)
        {
            /******* Connedt to DataBase  **********/
            SqlConnection con = new SqlConnection(conString);
           
            /***********Build SQL Query **********/
            SqlCommand cmd = new SqlCommand(SQLStr, con);
            
            /***********Build Dataset **********/
            DataSet ds = new DataSet();
            
            /***********Build Adapter **********/
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            /***********Get data from DB and fill it into the database **********/
            adapter.Fill(ds, tblName);

            /***************Build the table and render it *************************/
            DataTable dt = ds.Tables[tblName];
            string table = BuildUsersTable(dt);
            return table;
        }
    

        public static string BuildUsersTable(DataTable dt)
        {
            string str = "<table id='users' align='center'>";
            str += "<tr>";
            foreach (DataColumn column in dt.Columns)
            {
                str += "<th>" + column.ColumnName + "</th>";
            }
            str += "</tr>";

            foreach (DataRow row in dt.Rows)
            {
                str += "<tr>";
                foreach (DataColumn column in dt.Columns)
                {
                    str += "<td>" + row[column] + "</td>";
                }
                str += "</tr>";
            }
            str += "</tr>";
            str += "</Table>";
            return str;
        }
    }

    public class User
    {
        public int userId;
        public string firstName;
        public string lastName;
        public string Address;
        public string Phone;
        public string Hobbies;
        public bool Admin;
        public DateTime BirthDate;
        public string password;
        public string UserName;
        public string Email;
    
    public User()
    {
        userId = -1;
        firstName = "";
        lastName = "";
        Address = "";
        Phone = "";
        Hobbies = "";
        Admin = false;
        BirthDate = DateTime.Today;
        password = "";
        UserName = "";
        Email = "";
    }

}
}