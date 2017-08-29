using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            //return View();
            return "Default action";
        }

        public string Welcome(string name, short id)
        {
            return HttpUtility.HtmlEncode(string.Format("Welcome method {0}, id {1}", name, id));
        }
    }
}