using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            List<string> keywords = TextBox2.Text.Split(',').ToList();

            SCS.Text = " Computer Science: " + Comparator.matchSpringerCS(keywords.ToArray()) + "%";
            SEN.Text = " Engineering: " + Comparator.matchSpringerEN(keywords.ToArray()) + "%";
            SMA.Text = " Mathematics: " + Comparator.matchSpringerMA(keywords.ToArray()) + "%";

        }
    }
}