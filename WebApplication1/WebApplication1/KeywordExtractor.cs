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

            int counter = 0;
            List<string> springerkeywords;
            using (WebClient client = new WebClient())
            {

                springerkeywords = new List<string>();
                client.DownloadFile(uri, @".\springerfiles.txt");
                //    if (file.Contains(""))
                //    Console.WriteLine(file);D:\localfiles.txt
                string keywords = "<h3 class=\"Heading\">Key Words</h3>";
                string keywordswithoutspace = "<h3 class=\"Heading\">Keywords</h3>";
                string end = "</div>";
                bool printNow = false;
                //  HtmlDocument doc = new HtmlDocument();
                //   doc.LoadHtml(file);
                string quoteandgreatersymbol = "Keyword";
                StringBuilder sb = new StringBuilder();
                System.IO.StreamReader file =
         new System.IO.StreamReader("D:\\localfile.txt");
                foreach (var linee in File.ReadLines(@".\springerfiles.txt"))
                {
                    //Console.WriteLine(linee);
                    if (printNow)
                    {
                        if (linee.Contains(end))
                        {
                            printNow = false;
                            counter++;
                        }
                    }
                    if (printNow)
                    {
                        // Debug.WriteLine(linee);
                        if (linee.Contains(quoteandgreatersymbol))
                        {
                            var a = linee.IndexOf(">");
                            var b = linee.LastIndexOf("<");
                            var c = linee.Substring(a, b - a);
                            //     var d = c.IndexOf('>');
                            //   var e = c.IndexOf('<');
                            // var f = c.Substring(d, e - d);


                            Console.WriteLine(c.Trim('>'));
                            springerkeywords.Add(c.Trim('>'));
                            //   Console.WriteLine(f.Trim('>'));
                        }
                        //   Console.WriteLine(linee);
                    }
                    if ((linee.Contains(keywords) || (linee.Contains(keywordswithoutspace))) && counter == 0)
                        printNow = true;
                    // counter++;

                }

            }
            return springerkeywords;
        }
    }
}