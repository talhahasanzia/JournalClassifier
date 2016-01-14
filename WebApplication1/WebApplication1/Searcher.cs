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
            public static string AI = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=0&hitCount=2010&NEXT_LIST=1&view=c&md5=504eea1c742fe21d81eb55acb8f055b0&_ArticleListID=-922222509&chunkSize=25&sisr_search=&TOTAL_PAGES=81&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&displayPerPageFlag=t&resultsPerPage="+page;
            public static string SoftwareEngineering = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=openAccess&_chunk=0&hitCount=5880&NEXT_LIST=1&view=c&md5=eb86ad891b8e9b587139869e59063caa&_ArticleListID=-922475102&chunkSize=25&sisr_search=&TOTAL_PAGES=236&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&displayPerPageFlag=t&resultsPerPage="+page;
            public static string TheoryOfComputerScience = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=openAccess&_chunk=0&hitCount=7201&NEXT_LIST=1&view=c&md5=d4c688dc078e6036cecb0a72dabfb09b&_ArticleListID=-922475426&chunkSize=50&sisr_search=&TOTAL_PAGES=145&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&displayPerPageFlag=t&resultsPerPage="+page;
            public static string ComputerGraphics = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=openAccess&_chunk=0&hitCount=1126&NEXT_LIST=1&view=c&md5=5d8700a2cd22fdf8d551de3dac0d7435&_ArticleListID=-922478117&chunkSize=50&sisr_search=&TOTAL_PAGES=23&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&displayPerPageFlag=t&resultsPerPage="+page;
            public static string CloudComputing = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=openAccess&_chunk=0&hitCount=1268&NEXT_LIST=1&view=c&md5=be1c4afe347819873b9ff99b8ba055a0&_ArticleListID=-922478750&chunkSize=25&sisr_search=&TOTAL_PAGES=51&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&displayPerPageFlag=t&resultsPerPage="+page;
            public static string ParallelComputing = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=openAccess&_chunk=0&hitCount=3699&NEXT_LIST=1&view=c&md5=2fabc8c911a0a194135a7b792f81b4f2&_ArticleListID=-922479051&chunkSize=50&sisr_search=&TOTAL_PAGES=74&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&displayPerPageFlag=t&resultsPerPage="+page;
            public static string DistributedDatabase = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=openAccess&_chunk=0&hitCount=1771&NEXT_LIST=1&view=c&md5=da19c6d333dd97c7dac8d42fc0c825e0&_ArticleListID=-922482428&chunkSize=25&sisr_search=&TOTAL_PAGES=71&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&displayPerPageFlag=t&resultsPerPage="+page;
            public static string ComputerVision = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=95&sort=r&filterType=openAccess&_chunk=0&hitCount=95&NEXT_LIST=1&view=c&md5=342b15d3029bd2b4603d5aff2e56b1f5&_ArticleListID=-922483248&chunkSize=50&sisr_search=&TOTAL_PAGES=2&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&displayPerPageFlag=t&resultsPerPage="+page;
            public static string ComputerNetworks = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=224&sort=r&filterType=openAccess&_chunk=0&hitCount=224&NEXT_LIST=1&view=c&md5=f00f521510f610d4bfb65687ed65511e&_ArticleListID=-922483452&chunkSize=25&sisr_search=&TOTAL_PAGES=9&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&displayPerPageFlag=t&resultsPerPage="+page;



        }

    }
}