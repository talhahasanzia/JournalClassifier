using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Searcher
    {
        // THIS CLASS DEFINES CATEGORIES
        // RIGHT NOW ONLY 3 OF 1 WEBSITE

        public class Springer
        {
            public static int page;
            public static string ComputerScience = "http://link.springer.com/search/page/"+page+"?facet-discipline=%22Computer+Science%22&facet-content-type=%22Article%22&query=";
            public static string Engineering = "http://link.springer.com/search/page/" + page + "?facet-discipline=%22Engineering%22&facet-content-type=%22Article%22&query=";
            public static string Mathematics = "http://link.springer.com/search/page/"+page+"?facet-discipline=%22Mathematics%22&facet-content-type=%22Article%22&query=";

        
        }
        public class IEEE
        {
            public static int page;
            public static string ComputerScience ;
            public static string Engineering ;
            public static string Mathematics ;


        }
        public class ACM
        {
            public static int page;
            public static string ComputerScience ;
            public static string Engineering ;
            public static string Mathematics ;


        }


    }
}