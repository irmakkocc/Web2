using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2.Controllers
{
    public class IMDBController : Controller
    {
        // GET: IMDB
        public ActionResult Index()
        {
            return View();
        }
    }
}