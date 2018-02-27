using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Mountain.Models;
using Mountain.Class;
using System.Net;
using System.IO;
using System.Text;

namespace Mountain.Controllers
{
    public class movieController : Controller
    {
        public void CallApi(string searchText, int? page)
        {
            int pageNo = Convert.ToInt32(page) == 0 ? 1 : Convert.ToInt32(page);
            string apiKey = "897db07c3353e3ffcecfaccb07427887";
            HttpWebRequest apiRequest = WebRequest.Create("https://api.themoviedb.org/3/search/movie?api_key=" + apiKey + "&language=en-US&query=" + searchText + "&page=" + pageNo) as HttpWebRequest;
            string apiResponse = "";
            using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                apiResponse = reader.ReadToEnd();
            }

            //convert to Json
            ResponseTitleSearch rootObject = JsonConvert.DeserializeObject<ResponseTitleSearch>(apiResponse);
            StringBuilder sb = new StringBuilder();
            sb.Append("<div class=\"resultDiv\"><p> Titles </p>");
            foreach(Result result in rootObject.results)
            {
                string image = result.poster_path == null ? Url.Content("~/Content/Image/no-image.png") : "https://image.tmdb.org/t/p/w500" + result.poster_path;

                sb.Append("<div class=\"result\" resourceId=\"" + result.id + "\">" + "<img src=\"" + image + "\" />" + "<p>" + result.title + "</a></p></div>");



            }
            ViewBag.Result = sb.ToString();
            int pageSize = 20;
            PagingInfo pagingInfo = new PagingInfo();
            pagingInfo.CurrentPage = pageNo;
            pagingInfo.TotalItems = rootObject.total_results;
            pagingInfo.ItemsPerPage = pageSize;
            ViewBag.Paging = pagingInfo;

            
        }
        // GET: movie
        public ActionResult Index(string title, int? page)
        {
            if (page != null)
                CallApi(title, Convert.ToInt32(page));
            Models.TheMovieDb theMovieDb = new Models.TheMovieDb();
            theMovieDb.searchText = title;
           
            return View(theMovieDb);
        }
        [HttpPost]
        public ActionResult Index(Models.TheMovieDb theMovieDb, string searchText)
        {
            if (ModelState.IsValid)
            {
                CallApi(searchText, 0);
            }
            return View(theMovieDb);
        }
    }
}