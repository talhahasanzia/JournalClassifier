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

        public class Elsevier {

            public static int page;
            public static string AI = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=0&hitCount=49119&NEXT_LIST=1&view=c&md5=fd72b971f7093a99ab4696b14899522d&_ArticleListID=-923711570&chunkSize=25&sisr_search=&TOTAL_PAGES=1965&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomNext=Next+%3E%3E&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string SoftwareEngineering = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=0&hitCount=106207&NEXT_LIST=1&view=c&md5=dcc7b08011c8b0e03f1ea96c08c9e406&_ArticleListID=-923717260&chunkSize=100&sisr_search=&TOTAL_PAGES=1063&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomNext=Next+%3E%3E&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string TheoryOfComputerScience = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=0&hitCount=118379&NEXT_LIST=1&view=c&md5=77d64e976edb23b84d35aa18c9fa59ec&_ArticleListID=-923718042&chunkSize=100&sisr_search=&TOTAL_PAGES=1184&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomNext=Next+%3E%3E&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string ComputerGraphics = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=0&hitCount=44718&NEXT_LIST=1&view=c&md5=db0f0f47758138689af3febc152e17e2&_ArticleListID=-923718148&chunkSize=100&sisr_search=&TOTAL_PAGES=448&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomNext=Next+%3E%3E&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string CloudComputing = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=0&hitCount=13379&NEXT_LIST=1&view=c&md5=2f107830fcd91da6b50c5b380d7bfa35&_ArticleListID=-923718801&chunkSize=100&sisr_search=&TOTAL_PAGES=134&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomNext=Next+%3E%3E&displayPerPageFlag=f&resultsPerPage=" + page;
            public static string ParallelComputing = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=0&hitCount=91127&NEXT_LIST=1&view=c&md5=5d4219be1dfc603aa1a2371f8855b5bb&_ArticleListID=-923720674&chunkSize=100&sisr_search=&TOTAL_PAGES=912&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomNext=Next+%3E%3E&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string DistributedDatabase = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=0&hitCount=40608&NEXT_LIST=1&view=c&md5=8d23e1e32b5fe8028bb9e7fa311abaf3&_ArticleListID=-923720780&chunkSize=100&sisr_search=&TOTAL_PAGES=407&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomNext=Next+%3E%3E&displayPerPageFlag=f&resultsPerPage=" + page;
            public static string ComputerVision = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=0&hitCount=44873&NEXT_LIST=1&view=c&md5=b3f4f3b563cd1cce23b3934a2a514eba&_ArticleListID=-923718527&chunkSize=100&sisr_search=&TOTAL_PAGES=449&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomNext=Next+%3E%3E&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string ComputerNetworks = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=0&hitCount=155137&NEXT_LIST=1&view=c&md5=21ce2d17ebc405cbdab599fda48e8313&_ArticleListID=-923722396&chunkSize=25&sisr_search=&TOTAL_PAGES=6206&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomNext=Next+%3E%3E&displayPerPageFlag=f&resultsPerPage=" + page;



        }

    }
}