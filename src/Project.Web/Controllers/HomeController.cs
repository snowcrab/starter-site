using System;
using Microsoft.AspNetCore.Mvc;

namespace Project.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}