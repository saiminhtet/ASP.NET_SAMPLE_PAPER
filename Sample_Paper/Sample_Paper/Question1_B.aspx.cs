using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample_Paper
{
    public partial class Question2 : System.Web.UI.Page
    {
      static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count = count + 1;
            Label1.Text = count.ToString();

        }
    }
}