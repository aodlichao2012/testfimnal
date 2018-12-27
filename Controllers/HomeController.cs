using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pg.Models;

namespace pg.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Products p = new Products();
            p.pid = 111;
            p.pn = "sdfgsdgd";
            p.pp = 35000000.0;

            return View(p);
        }
        
    }
}