using FirstRestApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Get()
        {
            return Ok(_context.Categories.Include(c => c.Products));
        }


        [HttpGet("{id}/{take}")]
        public async Task<IActionResult> Get(int id, int take)
        {
            var category = await _context.Categories.Include(x => x.Products).FirstOrDefaultAsync(g => g.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category.Products.Take(take));
        }
    }
}
