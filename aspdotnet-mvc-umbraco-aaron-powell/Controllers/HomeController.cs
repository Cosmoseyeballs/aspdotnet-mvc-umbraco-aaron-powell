using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;

namespace aspdotnet_mvc_umbraco_aaron_powell.Controllers
{
    public class HomeController : Controller
    {
        private readonly Umbraco.Web.UmbracoContext UC;

        public ActionResult Index()
        {
            return View();
        }
    }
}