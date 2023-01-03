using BussniessLayer.Concreate;
using BussniessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiziFilm.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        KategoriManager km = new KategoriManager(new EFKategoriDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = km.GetKategoriList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddKategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddKategori(Kategori p)
        {
            //km.KategoriAddBL(p);
            KategoriValidator kv = new KategoriValidator();
            ValidationResult result = kv.Validate(p);
            if (result.IsValid)
            {
                km.KategoriAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}