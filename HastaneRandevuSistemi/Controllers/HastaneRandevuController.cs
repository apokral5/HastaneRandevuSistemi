using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HastaneRandevuSistemi.Models.Entity;
namespace HastaneRandevuSistemi.Controllers
{
    public class HastaneRandevuController : Controller
    {
        // GET: HastaneRandevu
        HastaneOtomasyonSistemiEntities1 db =new HastaneOtomasyonSistemiEntities1();
        public ActionResult Index()
        {
            var degerler = db.TBL_HASTA.ToList();
            return View(degerler);
        }
    }
}