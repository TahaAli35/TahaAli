using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}