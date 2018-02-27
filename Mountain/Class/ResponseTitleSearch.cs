using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mountain.Class
{
    public class ResponseTitleSearch
    {
        public int page { get; set; }
        public List<Result> results { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
    }
}