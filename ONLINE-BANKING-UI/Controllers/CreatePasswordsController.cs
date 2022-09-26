using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ONLINE_BANKING_UI.Models;

namespace ONLINE_BANKING_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatePasswordsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CreatePasswordsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/CreatePasswords
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CreatePassword>>> GetCreatePassword()
        {
            return await _context.CreatePassword.ToListAsync();
        }

        // GET: api/CreatePasswords/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CreatePassword>> GetCreatePassword(int id)
        {
            var createPassword = await _context.CreatePassword.FindAsync(id);

            if (createPassword == null)
            {
                return NotFound();
            }

            return createPassword;
        }

        // PUT: api/CreatePasswords/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCreatePassword(int id, CreatePassword createPassword)
        {
            if (id != createPassword.id)
            {
                return BadRequest();
            }

            _context.Entry(createPassword).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreatePasswordExists(id))
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

        // POST: api/CreatePasswords
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CreatePassword>> PostCreatePassword(CreatePassword createPassword)
        {
            _context.CreatePassword.Add(createPassword);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCreatePassword", new { id = createPassword.id }, createPassword);
        }

        // DELETE: api/CreatePasswords/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CreatePassword>> DeleteCreatePassword(int id)
        {
            var createPassword = await _context.CreatePassword.FindAsync(id);
            if (createPassword == null)
            {
                return NotFound();
            }

            _context.CreatePassword.Remove(createPassword);
            await _context.SaveChangesAsync();

            return createPassword;
        }

        private bool CreatePasswordExists(int id)
        {
            return _context.CreatePassword.Any(e => e.id == id);
        }
    }
}
