using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Porto_ecommerce_30_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Porto_ecommerce_30_.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortoDbContext dbcontext;
        public HomeController(PortoDbContext _dbcontext)
        {
            dbcontext = _dbcontext;
        }
        public IActionResult Index()
        {
            dbcontext.categories.ToList();
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
