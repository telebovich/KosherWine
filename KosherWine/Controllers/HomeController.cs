using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using KosherWine.Models;

namespace KosherWine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Kosher Wine!";

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            try
            {
                KosherWine.Models.Email email = new KosherWine.Models.Email();
                email.Address = Request.Form["Email"];
                KosherWine.Models.Email.Add(email);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Index_Production()
        {
            return View();
        }
    }
}
