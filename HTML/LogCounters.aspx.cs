using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_12.HTML
{
    public partial class Log : System.Web.UI.Page
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
                    mainCounter.InnerHtml = Application["globalCounter"].ToString();
                    currentCounter.InnerHtml = Application["inSite"].ToString();
                    mainCounterLogedIn.InnerHtml= Application["globalCounterLogedIn"].ToString();
                    currentCounterLogedIn.InnerHtml = Application["inSiteLogedIn"].ToString();
            }
            catch
            {
                string localHost = Request.Url.ToString().Substring(0, 23);
                Response.Redirect(localHost + "HTML/Physics.aspx");
            }
        }


    }
}
