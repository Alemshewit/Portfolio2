using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Models.AlemShewitEntities db = new Models.AlemShewitEntities();

        public ActionResult Index()
        {
            return View();
        }

    }
}
