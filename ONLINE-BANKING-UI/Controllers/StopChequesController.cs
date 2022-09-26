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
    public class StopChequesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public StopChequesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/StopCheques
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StopCheque>>> GetStopCheque()
        {
            return await _context.StopCheque.ToListAsync();
        }

        // GET: api/StopCheques/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StopCheque>> GetStopCheque(int id)
        {
            var stopCheque = await _context.StopCheque.FindAsync(id);

            if (stopCheque == null)
            {
                return NotFound();
            }

            return stopCheque;
        }

        // PUT: api/StopCheques/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStopCheque(int id, StopCheque stopCheque)
        {
            if (id != stopCheque.id)
            {
                return BadRequest();
            }

            _context.Entry(stopCheque).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StopChequeExists(id))
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

        // POST: api/StopCheques
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StopCheque>> PostStopCheque(StopCheque stopCheque)
        {
            _context.StopCheque.Add(stopCheque);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStopCheque", new { id = stopCheque.id }, stopCheque);
        }

        // DELETE: api/StopCheques/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StopCheque>> DeleteStopCheque(int id)
        {
            var stopCheque = await _context.StopCheque.FindAsync(id);
            if (stopCheque == null)
            {
                return NotFound();
            }

            _context.StopCheque.Remove(stopCheque);
            await _context.SaveChangesAsync();

            return stopCheque;
        }

        private bool StopChequeExists(int id)
        {
            return _context.StopCheque.Any(e => e.id == id);
        }
    }
}
