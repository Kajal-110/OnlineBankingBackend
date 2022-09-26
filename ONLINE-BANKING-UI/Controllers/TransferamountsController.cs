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
    public class TransferamountsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public TransferamountsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Transferamounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transferamount>>> GetTransferamount()
        {
            return await _context.Transferamount.ToListAsync();
        }

        // GET: api/Transferamounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transferamount>> GetTransferamount(int id)
        {
            var transferamount = await _context.Transferamount.FindAsync(id);

            if (transferamount == null)
            {
                return NotFound();
            }

            return transferamount;
        }

        // PUT: api/Transferamounts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransferamount(int id, Transferamount transferamount)
        {
            if (id != transferamount.id)
            {
                return BadRequest();
            }

            _context.Entry(transferamount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransferamountExists(id))
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

        // POST: api/Transferamounts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Transferamount>> PostTransferamount(Transferamount transferamount)
        {
            _context.Transferamount.Add(transferamount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransferamount", new { id = transferamount.id }, transferamount);
        }

        // DELETE: api/Transferamounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Transferamount>> DeleteTransferamount(int id)
        {
            var transferamount = await _context.Transferamount.FindAsync(id);
            if (transferamount == null)
            {
                return NotFound();
            }

            _context.Transferamount.Remove(transferamount);
            await _context.SaveChangesAsync();

            return transferamount;
        }

        private bool TransferamountExists(int id)
        {
            return _context.Transferamount.Any(e => e.id == id);
        }
    }
}
