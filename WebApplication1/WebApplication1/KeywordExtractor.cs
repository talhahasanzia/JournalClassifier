using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace WebApplication1
{
    public class KeywordExtractor
    {
       public static List<string> springer(string uri)
        {
            List<string> springerkeywords = new List<string>();

            var html = new HtmlDocument();

            html.LoadHtml(new WebClient().DownloadString(uri)); // load a string web address
            // create a root node
            var root = html.DocumentNode;

            // get element having class =Keyword, which is juournal link node
            var p = root.Descendants().Where(n => n.GetAttributeValue("class", "").Equals("Keyword")).ToArray();


            var nodes = p.ToArray();

            foreach(var node in nodes)
            {

                string tempKeyword = node.InnerHtml;
                springerkeywords.Add(tempKeyword);
                System.Diagnostics.Debug.WriteLine(tempKeyword);
            }
            return springerkeywords;
        }
    }
}