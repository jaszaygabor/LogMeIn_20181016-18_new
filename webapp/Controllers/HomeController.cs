using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webapp.Models;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UserDetails()
        {
            var bob = new User();
            bob.Name = "Bob";
            bob.BirthDate = new DateTime(2000, 1, 1);
            return View(bob);
        }
        public ActionResult programozas()
        {
            this.ViewBag.Page = "programozas";
            return View();
        }
        public ActionResult html_css_js()
        {
            this.ViewBag.Page = "html_css_js";
            return View();
        }
        public ActionResult linux()
        {
            this.ViewBag.Page = "linux";
            return View();
        }
        public ActionResult iszgy()
        {
            this.ViewBag.Page = "iszgy";
            return View();
        }

        public ActionResult halozat()
        {
            this.ViewBag.Page = "halozat";
            return View();
        }

        public ActionResult reg()
        {
            this.ViewBag.Page = "reg";
            return View();
        }
        public ActionResult impresszum()
        {
            this.ViewBag.Page = "impresszum";
            return View();
        }
        public ActionResult newpassword()
        {
            this.ViewBag.Page = "newpassword";
            return View();
        }
        public ActionResult newemail()
        {
            this.ViewBag.Page = "newemail";
            return View();
        }


    }
}