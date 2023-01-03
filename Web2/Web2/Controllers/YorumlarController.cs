using BussniessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiziFilm.Controllers
{
    public class YorumlarController : Controller
    {
        YorumlarManager ym = new YorumlarManager(new EFYorumlarDal());
        public ActionResult Index()
        {
            var IndexValues = ym.GetList();
            return View(IndexValues);
        }
    }
}