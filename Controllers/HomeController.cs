using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("{email?}")]
        public IActionResult Index(string email)
        {
            ViewData["Email"] = email;

            return View();
        }
    }
}
