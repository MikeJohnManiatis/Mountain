using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mountain.Class
{
    public class Result
    {
        public int id { get; set; }
        public string title { get; set; }
        public string poster_path { get; set; }
        public double popularity { get; set; }
        public bool adult { get; set; }
    }
}