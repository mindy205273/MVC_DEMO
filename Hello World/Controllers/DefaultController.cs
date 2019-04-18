using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello_World.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Models.HelloApplication hello = new Models.HelloApplication();

            //ViewBag.Label = "Hello World";
            ViewBag.Label = hello.GetLabelText();
            return View();
        }
    }
}