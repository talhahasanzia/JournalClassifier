using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Searcher
    {
        // THIS CLASS DEFINES CATEGORIES


        public class Springer
        {
            public static int page;
            public static string ComputerScience = "http://link.springer.com/search/page/"+page+"?facet-discipline=%22Computer+Science%22&facet-content-type=%22Article%22&query=";
            public static string Engineering = "http://link.springer.com/search/page/" + page + "?facet-discipline=%22Engineering%22&facet-content-type=%22Article%22&query=";
            public static string Mathematics = "http://link.springer.com/search/page/"+page+"?facet-discipline=%22Mathematics%22&facet-content-type=%22Article%22&query=";
			public static string TheoreticalComputerScience = "http://link.springer.com/search/page/"+page+"?facet-discipline=%22Computer+Science%22&facet-sub-discipline=%22Theoretical+Computer+Science%22&facet-content-type=%22Article%22&query=";
			public static string AI = "http://link.springer.com/search/page/"+page+"?facet-discipline=%22Computer+Science%22&facet-sub-discipline=%22AI%22&facet-content-type=%22Article%22&query=";
        	public static string ComputerNetworks = "http://link.springer.com/search/page/"+page+"?facet-discipline=%22Computer+Science%22&facet-sub-discipline=%22Communication+Networks%22&facet-content-type=%22Article%22&query=";
			public static string InformationSystemsAndApplications = "http://link.springer.com/search/page/"+page+"?facet-discipline=%22Computer+Science%22&facet-sub-discipline=%22Information+Systems+and+Applications%22&facet-content-type=%22Article%22&query=";
			
			public static string Algebra = "http://link.springer.com/search/page/"+page+"?facet-discipline=%22Mathematics%22&facet-sub-discipline=%22Algebra%22&facet-content-type=%22Article%22&query=";
			public static string MathematicalAndComputationalPhysics = "http://link.springer.com/search/page/"+page+"?facet-discipline=%22Mathematics%22&facet-sub-discipline=%22Theoretical%2C+Mathematical+%26+Computational+Physics%22&facet-content-type=%22Article%22&query=";
		//test commit
		
		}
        public class ACM
        {
            public static int page;
            
            public static string AI = "http://dl.acm.org/results.cfm?query=%28%252Bartificial%20%252Bintelligence%29&start="+page*20+"&filtered=&within=owners%2Eowner%3DACM&dte=&bfr=&srt=_score";
            public static string SoftwareEngineering = "http://dl.acm.org/results.cfm?query=%28%252Bsoftware%20%252Bengineering%29&start="+page*20+"&filtered=&within=owners%2Eowner%3DACM&dte=&bfr=&srt=_score";
            public static string TheoryOfComputerScience = "http://dl.acm.org/results.cfm?query=%28%252BTheory%20%252Bof%20%252Bcomputer%20%252Bscience%29&start="+page*20+"&filtered=&within=owners%2Eowner%3DACM&dte=&bfr=&srt=_score";
            public static string ComputerGraphics = "http://dl.acm.org/results.cfm?query=%28%252Bcomputer%20%252Bgraphics%29&start="+page*20+"&filtered=&within=owners%2Eowner%3DACM&dte=&bfr=&srt=_score";
            public static string CloudComputing = "http://dl.acm.org/results.cfm?query=%28%252Bcloud%20%252Bcomputing%29&start="+page*20+"&filtered=&within=owners%2Eowner%3DACM&dte=&bfr=&srt=_score";
            public static string ParallelComputing = "http://dl.acm.org/results.cfm?query=%28%252Bparallel%20%252Bcomputing%29&start="+page*20+"&filtered=&within=owners%2Eowner%3DACM&dte=&bfr=&srt=_score";
            public static string DistributedDatabase = "http://dl.acm.org/results.cfm?query=%28%252Bdistributed%20%252Bdatabase%29&start="+page*20+"&filtered=&within=owners%2Eowner%3DACM&dte=&bfr=&srt=_score";
            public static string ComputerVision = "http://dl.acm.org/results.cfm?query=%28%252Bcomputer%20%252Bvision%29&start="+page*20+"&filtered=&within=owners%2Eowner%3DACM&dte=&bfr=&srt=_score";
            public static string ComputerNetworks = "http://dl.acm.org/results.cfm?query=%28%252Bcomputer%20%252Bnetworks%29&start=" + page * 20 + "&filtered=&within=owners%2Eowner%3DACM&dte=&bfr=&srt=_score";

        }


    }
}