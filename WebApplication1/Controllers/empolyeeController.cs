using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class empolyeeController : Controller
    {
        Model1 db = new Model1();
        // GET: empolyee
        public ActionResult empolyee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult empolyee(Empolyee emply)
        {
            db.Empolyee.Add(emply);
            db.SaveChanges();
            return RedirectToAction("login");
        }

        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(login lg)
        {
            var user = db.Empolyee.Where(s => s.Email.Equals(lg.Email) && s.password.Equals(lg.password)).FirstOrDefault();
            if (user != null)
            {
                return RedirectToAction("index", "home");
            }
            else
            {
                return View();
            }

        }

    }
}