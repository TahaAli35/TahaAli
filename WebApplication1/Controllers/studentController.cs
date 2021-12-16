using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class studentController : Controller
    {
        Model1 db = new Model1();
        // GET: student
        public ActionResult student()
        {
            return View();
        }
        [HttpPost]
        public ActionResult student(student std)
        {
            db.student.Add(std);
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
            var user = db.student.Where(s => s.Email.Equals(lg.Email) && s.password.Equals(lg.password)).FirstOrDefault();
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