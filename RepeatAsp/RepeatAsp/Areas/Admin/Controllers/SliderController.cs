using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepeatAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepeatAsp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly PotroDb dbContext;
        public SliderController(PotroDb _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            return View(dbContext.Slider.ToList());
        }
        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IFormFile photo, int price, string trend, string discount, string cloth)
        {
            Slider slider = new Slider
            {
                TrendWord = trend,
                ClothType = cloth,
                Price = price,
                DisCount = discount,
                Image = photo.FileName
            };
            dbContext.Slider.Add(slider);
            dbContext.SaveChanges();

            return Redirect("Index");
        }
    }
}
