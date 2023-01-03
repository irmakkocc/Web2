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
    public class AdminKategoriController : Controller
    {
        KategoriManager km = new KategoriManager(new EFKategoriDal());
        // GET: AdminKategori
        public ActionResult Index()
        {
            var kategorivalues = km.GetKategoriList();
            return View(kategorivalues);
        }
        [HttpGet]
        public ActionResult AddKategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddKategori(Kategori p)
        {
            KategoriValidator kategoriValidator = new KategoriValidator();
            ValidationResult result = kategoriValidator.Validate(p);
            if (result.IsValid)
            {
                km.KategoriAdd(p);
                return RedirectToAction("Index");
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
        public ActionResult DeleteKategori(int id)
        {
            var kategorivalue = km.GetByID(id);
            km.KategoriDelete(kategorivalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditKategori(int id)
        {
            var kategorivalue = km.GetByID(id);
            return View(kategorivalue);
        }
        [HttpPost]
        public ActionResult EditKategori(Kategori p)
        {
            km.KategoriUpdate(p);
            return RedirectToAction("Index");
        }
    }
}