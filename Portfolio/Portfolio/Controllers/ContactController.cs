using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        Models.AlemShewitEntities db = new Models.AlemShewitEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.ContactForm());
        }

        [HttpPost]
        public ActionResult Index(Models.ContactForm contactForm)
        {
            Models.AlemShewitEntities db = new Models.AlemShewitEntities();
            db.ContactForms.Add(contactForm);
            db.SaveChanges();

            return RedirectToAction("Thankyou", "Contact");
        }

        public ActionResult Thankyou()
        {
            return View();
        }

    }
}
