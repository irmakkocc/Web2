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
    public class FilmlerController : Controller
    {
        FilmlerManager fm = new FilmlerManager(new EFFilmlerDal());
        public ActionResult Filmler()
        {
            var FilmlerValues = fm.GetList();
            return View(FilmlerValues);
        }
        [HttpGet]
        public ActionResult AddFilm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFilm(Filmler p)
        {
            FilmlerValidator filmlerValidator = new FilmlerValidator();
            ValidationResult result = filmlerValidator.Validate(p);
            if (result.IsValid)
            {
                fm.FilmlerAdd(p);
                return RedirectToAction("Filmler");
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