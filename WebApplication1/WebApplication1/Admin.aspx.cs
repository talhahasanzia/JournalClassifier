using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Admin : System.Web.UI.Page
    {

        string source=Searcher.Springer.ComputerScience;
        List<string> KeywordsList = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            OutputLabel.Text = "";
        }

        protected void RunButton_Click(object sender, EventArgs e)
        {


            // SET CATEGORIES

            if (DropDownList1.SelectedValue == "Springer")
            {
                if (DropDownList2.SelectedValue == "CS")
                {

                    source = Searcher.Springer.ComputerScience;

                }
                if (DropDownList2.SelectedValue == "MA")
                {

                    source = Searcher.Springer.Mathematics;

                }
                if (DropDownList2.SelectedValue == "EN")
                {

                    source = Searcher.Springer.Engineering;

                }

            }

            List<string> keywords=JournalLinks.FromSpringer(source,1);

            foreach (string word in keywords)
            {
                OutputLabel.Text += "<br>"+word;
            
            }
        }

  

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        
        }
    }
}