using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using task_12.App_Code;

namespace task_12.HTML
{
    public partial class AdminMainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {


                if (!((bool)Session["Admin"]))
                {
                    string localHost = Request.Url.ToString().Substring(0, 23);
                    Response.Redirect(localHost + "HTML/Physics.aspx");
                }
                else
                {

                    /********Bring the full table*******************/

                    /*********** Builde SQL Command ****************/
                    string SQLStr = "SELECT * FROM Physics1";

                    mainTable.InnerHtml = Helper.FetchTable(SQLStr);
                }
            }
            catch
            {
                string localHost = Request.Url.ToString().Substring(0, 23);
                Response.Redirect(localHost + "HTML/Physics.aspx");
            }

        }

    }

}