using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teste.Controllers
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

        public ActionResult Teste1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult B1_Teste1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Teste2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Teste3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Teste4()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Teste5()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult B1_Teste5()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}