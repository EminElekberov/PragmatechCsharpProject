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
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("category is not valid");
            }

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return Created($"/api/categories/{category.Id}", category);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _context.Categories.Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return Ok("Deleted Succesfully");
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] Category category)
        {
            var categorydb = await _context.Categories.Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == category.Id);
            if (categorydb == null)
            {
                return NotFound();
            }
            categorydb.Name = category.Name;
            _context.Update(categorydb);
            await _context.SaveChangesAsync();
            return Ok($"Edit Succesfully {category.Name}");
        }
    }
}
