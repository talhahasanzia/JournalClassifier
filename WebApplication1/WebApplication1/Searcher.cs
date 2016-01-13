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
		public class IEEE
        {
            public static int page;
            public static string ComputerScience ;
            public static string AI = "http://ieeexplore.ieee.org/search/searchresult.jsp?queryText=(artificial%20intelligence)&refinements=4294967269&refinements=4291944245&matchBoolean=true&pageNumber="+page+"&searchField=Search_All";
            public static string ComputerNetworks = "http://ieeexplore.ieee.org/search/searchresult.jsp?queryText=(Computer%20Networks)&refinements=4294967269&refinements=4291944245&matchBoolean=true&pageNumber="+page+"&searchField=Search_All";
            public static string SoftwareEngineering = "http://ieeexplore.ieee.org/search/searchresult.jsp?queryText=(Software%20engineering)&refinements=4294967269&refinements=4291944245&matchBoolean=true&pageNumber="+page+"&searchField=Search_All";
            public static string TheoryOfComputerScience = "http://ieeexplore.ieee.org/search/searchresult.jsp?queryText=(Theory%20of%20Computer%20Science)&refinements=4294967269&refinements=4291944245&matchBoolean=true&pageNumber="+page+"&searchField=Search_All";
            public static string ComputerGraphics = "http://ieeexplore.ieee.org/search/searchresult.jsp?queryText=(Computer%20Graphics)&refinements=4294967269&refinements=4291944245&matchBoolean=true&pageNumber="+page+"&searchField=Search_All";
            public static string CloudComputing = "http://ieeexplore.ieee.org/search/searchresult.jsp?queryText=(cloud%20computing)&refinements=4294967269&refinements=4291944245&matchBoolean=true&pageNumber="+page+"&searchField=Search_All";
            public static string DistributedDatabase = "http://ieeexplore.ieee.org/search/searchresult.jsp?queryText=(Distributed%20Database)&refinements=4294967269&refinements=4291944245&matchBoolean=true&pageNumber="+page+"&searchField=Search_All";
            public static string ParallelComputing = "http://ieeexplore.ieee.org/search/searchresult.jsp?queryText=(Parallel%20Computing)&refinements=4294967269&refinements=4291944245&matchBoolean=true&pageNumber="+page+"&searchField=Search_All";
            public static string ComputerVision = "http://ieeexplore.ieee.org/search/searchresult.jsp?queryText=(computer%20vision)&refinements=4294967269&refinements=4291944245&matchBoolean=true&pageNumber="+page+"&searchField=Search_All";

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