using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace HelloWorldASPNET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HelloWorld = "Hello, world! in ASP.NET Core 1.0";
            return View();
        }
    }
}
