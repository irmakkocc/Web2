using BussniessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiziFilm.Controllers
{
    public class DizilerController : Controller
    {
        DizilerManager mg = new DizilerManager(new EFDizilerdal());
        public ActionResult Diziler()
        {
            var DizilerValues = mg.GetList();
            return View(DizilerValues);
        }
    }
}