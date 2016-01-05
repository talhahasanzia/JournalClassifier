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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RunButton_Click(object sender, EventArgs e)
        {
            string LinkToExtract = LinkText.Text;
            var html = new HtmlDocument();
            //html.Load(@"C:\HtmlDocs\test.html"); // load a file
            html.LoadHtml(new WebClient().DownloadString("http://www.springer.com/generic/search/results?SGWID=9-40109-24-653415-0&sortOrder=relevance&channels=146&searchType=ADVANCED_CDA&language=en&searchScope=journals&queryText=&resultStart=1&media=journal")); // load a string
            var root = html.DocumentNode;
     

            var p = root.Descendants()
    .Where(n => n.GetAttributeValue("class", "").Equals("productAdditionalInformation"))
    .SelectMany(n => n.Descendants("h2")).ToArray();
            
            
            var nodes = p.ToArray();


            List<string> Links = new List<string>();

            foreach (var node in nodes)
            {

            
               // OutputLabel.Text += "\n\n" + link.Descendants("a");
            
            }
          
        }
    }
}