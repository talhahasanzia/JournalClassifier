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
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RunButton_Click(object sender, EventArgs e)
        {

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
            
            FromSpringer(1);
      
        }

        void FromSpringer(int depth)
        {
            Searcher.Springer.page = depth;
            OutputLabel.Text = "";
            var html = new HtmlDocument();
            
            html.LoadHtml(new WebClient().DownloadString(source)); // load a string
            var root = html.DocumentNode;


            var p = root.Descendants()
    .Where(n => n.GetAttributeValue("class", "").Equals("title"))
  .ToArray();


            var nodes = p.ToArray();


            List<string> Links = new List<string>();

            foreach (var node in nodes)
            {
                try
                {
                    HtmlAttribute link = node.Attributes["href"];
                   

                    string temp = "link.springer.com" + link.Value;
                    Links.Add(temp);
                     OutputLabel.Text += "<br>"+temp;
                }
                catch (Exception ex)
                {


                }


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