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
            public static string AI = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=1&hitCount=49119&PREV_LIST=0&NEXT_LIST=2&view=c&md5=124a59eae8dcbd3fa218b3355da6845a&_ArticleListID=-923711570&chunkSize=25&sisr_search=&TOTAL_PAGES=1965&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomPrev=%3C%3C+Previous&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string SoftwareEngineering = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=1&hitCount=106207&PREV_LIST=0&NEXT_LIST=2&view=c&md5=49f4df74f58f94d1986f5f528f472223&_ArticleListID=-923717260&chunkSize=25&sisr_search=&TOTAL_PAGES=4249&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomPrev=%3C%3C+Previous&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string TheoryOfComputerScience = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=1&hitCount=118379&PREV_LIST=0&NEXT_LIST=2&view=c&md5=8da51becb8ee3a88f70e703a5bd17117&_ArticleListID=-923718042&chunkSize=25&sisr_search=&TOTAL_PAGES=4736&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomPrev=%3C%3C+Previous&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string ComputerGraphics = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=1&hitCount=44718&PREV_LIST=0&NEXT_LIST=2&view=c&md5=29fbbfd816bdc0678fc25f71ef82e5a3&_ArticleListID=-923718148&chunkSize=25&sisr_search=&TOTAL_PAGES=1789&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomPrev=%3C%3C+Previous&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string CloudComputing = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=1&hitCount=13379&PREV_LIST=0&NEXT_LIST=2&view=c&md5=2bdc7d06d2b0edcf504d55e1e519d720&_ArticleListID=-923718801&chunkSize=25&sisr_search=&TOTAL_PAGES=536&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomPrev=%3C%3C+Previous&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string ParallelComputing = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=1&hitCount=91127&PREV_LIST=0&NEXT_LIST=2&view=c&md5=78bc51a1e82604bd037e923e0b0a0ec3&_ArticleListID=-923720674&chunkSize=25&sisr_search=&TOTAL_PAGES=3646&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomPrev=%3C%3C+Previous&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string DistributedDatabase = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=1&hitCount=40608&PREV_LIST=0&NEXT_LIST=2&view=c&md5=6f7d36ce6dfe33eee34aea4197f0f63f&_ArticleListID=-923720780&chunkSize=25&sisr_search=&TOTAL_PAGES=1625&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomPrev=%3C%3C+Previous&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string ComputerVision = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=1&hitCount=44873&PREV_LIST=0&NEXT_LIST=2&view=c&md5=9cc0d29f3e2bc94682de1d1e9c4f839c&_ArticleListID=-923718527&chunkSize=25&sisr_search=&TOTAL_PAGES=1795&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomPrev=%3C%3C+Previous&displayPerPageFlag=f&resultsPerPage="+ page;
            public static string ComputerNetworks = "http://www.sciencedirect.com/science?_ob=ArticleListURL&_method=tag&searchtype=a&refSource=search&_st=4&count=1000&sort=r&filterType=&_chunk=1&hitCount=155137&PREV_LIST=0&NEXT_LIST=2&view=c&md5=a3b888304df7aac7960195a5325ff398&_ArticleListID=-923722396&chunkSize=25&sisr_search=&TOTAL_PAGES=6206&zone=exportDropDown&citation-type=RIS&format=cite-abs&bottomPaginationBoxChanged=&bottomPrev=%3C%3C+Previous&displayPerPageFlag=f&resultsPerPage="+ page;



        }

    }
}