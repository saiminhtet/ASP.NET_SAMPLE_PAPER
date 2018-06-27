using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample_Paper
{
    public partial class Question1_C : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count = (int)Session["count"];
            count = count + 1;
            Label1.Text = count.ToString();
            //Session["count"] = count;
        }
    }
}