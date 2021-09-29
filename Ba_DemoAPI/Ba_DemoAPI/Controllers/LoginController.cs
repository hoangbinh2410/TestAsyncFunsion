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
    public class LoginController : Controller
    {
        private readonly DBconnect _context;
        public LoginController(DBconnect context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Password> Get()
        {
            return _context.Passwords;
        }
        // Get id password
        [HttpGet("{id}")]
        public async Task<ActionResult<Password>> GetPass(int id)
        {
            var pass = await _context.Passwords.FindAsync(id);
            if (pass == null)
            {
                return NotFound();
            }
            return pass;
        // Put pass
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPass(int id, Password password)
        {
            if (id != password.ID)
            {
                return BadRequest();
            }
            _context.Entry(password).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
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
        //Post pass

        [HttpPost]
        public async Task<ActionResult<Password>> Creat(Password password)
        {
            _context.Passwords.Add(password);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPass), new { id = password.ID }, password);
        }
        private bool UsersExists(int id)
        {
            return _context.Nhanviens.Any(e => e.ID == id);
        }

    }
}
