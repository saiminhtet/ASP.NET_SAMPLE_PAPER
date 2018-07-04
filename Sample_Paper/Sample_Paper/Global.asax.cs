using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Sample_Paper
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Session_Start(object sender, EventArgs e)
        {

            //Declear Session Variables
            Session["receipt"] = new Receipt();  //this is calling the Receipt Class 

            Session["rebate"] = new Rebates();  //this is calling the Rebates Class
        }
    }
}