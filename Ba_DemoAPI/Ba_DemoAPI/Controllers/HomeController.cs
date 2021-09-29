using Ba_DemoAPI.Confixdb;
using Ba_DemoAPI.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ba_DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly DBconnect _context;
        public HomeController(DBconnect context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Nhanvien> Get()
        {
            return _context.Nhanviens;
        }
        //Get: api/Home/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nhanvien>> GetUsers(int id)
        {
            var nhanviens = await _context.Nhanviens.FindAsync(id);
            if(nhanviens == null)
            {
                return NotFound();
            }
            return nhanviens;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int id, Nhanvien nhanvien)
        {
            if(id != nhanvien.ID)
            {
                return BadRequest();
            }
            _context.Entry(nhanvien).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch( DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Nhanvien>> Creat(Nhanvien nhanvien)
        {
            _context.Nhanviens.Add(nhanvien);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsers), new { id = nhanvien.ID }, nhanvien);
        }

        // DELETE: api/Home/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Nhanvien>> DeleteProducts(int id)
        {
            var products = await _context.Nhanviens.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }

            _context.Nhanviens.Remove(products);
            await _context.SaveChangesAsync();

            return products;
        }

        private bool UsersExists(int id)
        {
            return _context.Nhanviens.Any(e => e.ID == id);
        }
    }
}
