using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_12.HTML
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack) { }
            /****************Cleare LogIn USER *****************/
            Session["UserName"] = null;
            Session["Admin"] = 0;
          


            /****************Redirect to main Page***************/
            string localHost = Request.Url.ToString().Substring(0, 23);
            Response.Redirect(localHost + "HTML/Physics.aspx");


        }
    }
}