using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class functionController : Controller
    {
        Model1 db = new Model1();
        // GET: function
        public ActionResult registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult registration(registration reg)
        {
            db.Registrations.Add(reg);
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
            var user = db.Registrations.Where(s => s.Email.Equals(lg.Email) && s.password.Equals(lg.password)).FirstOrDefault();
            if(user != null)
            {
                FormsAuthentication.SetAuthCookie(user.userName, false);
                return RedirectToAction("index", "home");
            }
            else
            {
                return View();
            }
            
        }

    }
}