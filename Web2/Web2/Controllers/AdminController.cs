using BussniessLayer.Concreate;
using DataAccessLayer.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiziFilm.Controllers
{
    public class AdminController : Controller
    {
        AdminManager am = new AdminManager(new EFAdminGirisDal());
        public ActionResult Index()
        {
            var AdminValues = am.GetList();
            return View(AdminValues);
        }
    }
}