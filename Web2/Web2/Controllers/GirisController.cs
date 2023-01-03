using BussniessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DiziFilm.Controllers
{
    public class GirisController : Controller
    {
        GirisYapManager gym = new GirisYapManager(new EFGirisYapDal());
        public ActionResult GirisYap()
        {
            var GirisYapValues = gym.GetList();
            return View(GirisYapValues);
        }
        UyeOlManager uom = new UyeOlManager(new EFUyeOlDal());
        public ActionResult UyeOl()
        {
            var UyeOlValues = uom.GetList();
            return View(UyeOlValues);
        }
        //AdminManager am = new AdminManager(new EFAdminGirisDal());
        //public ActionResult AdminGiris()
        //{
        //    var a
        //    return View();
        //}
        SifremiUnuttumManager sum = new SifremiUnuttumManager(new EFSifreUnuttumDal());
        public ActionResult SifreUnuttum()
        {
            var SifreUnuttumValues = sum.GetList();
            return View(SifreUnuttumValues);
        }
    }
}