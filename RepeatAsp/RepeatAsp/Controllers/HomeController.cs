using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RepeatAsp.Models;
using RepeatAsp.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RepeatAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly PotroDb potroDb;

        public HomeController(PotroDb _porto)
        {
            potroDb =_porto;
        }

        public async Task<IActionResult> Index()
        {
            HomeVm vm = new HomeVm
            {
                categories = await potroDb.Categories.ToListAsync(),
                sliders=await potroDb.Slider.ToListAsync()
            };
            return View(vm);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
