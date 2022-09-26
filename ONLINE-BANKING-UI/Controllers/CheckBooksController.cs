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
    public class CheckBooksController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CheckBooksController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/CheckBooks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CheckBook>>> GetCheckBook()
        {
            return await _context.CheckBook.ToListAsync();
        }

        // GET: api/CheckBooks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CheckBook>> GetCheckBook(int id)
        {
            var checkBook = await _context.CheckBook.FindAsync(id);

            if (checkBook == null)
            {
                return NotFound();
            }

            return checkBook;
        }

        // PUT: api/CheckBooks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCheckBook(int id, CheckBook checkBook)
        {
            if (id != checkBook.Id)
            {
                return BadRequest();
            }

            _context.Entry(checkBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheckBookExists(id))
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

        // POST: api/CheckBooks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CheckBook>> PostCheckBook(CheckBook checkBook)
        {
            _context.CheckBook.Add(checkBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCheckBook", new { id = checkBook.Id }, checkBook);
        }

        // DELETE: api/CheckBooks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CheckBook>> DeleteCheckBook(int id)
        {
            var checkBook = await _context.CheckBook.FindAsync(id);
            if (checkBook == null)
            {
                return NotFound();
            }

            _context.CheckBook.Remove(checkBook);
            await _context.SaveChangesAsync();

            return checkBook;
        }

        private bool CheckBookExists(int id)
        {
            return _context.CheckBook.Any(e => e.Id == id);
        }
    }
}
