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
    public class ChangePinsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ChangePinsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/ChangePins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChangePin>>> GetChangePin()
        {
            return await _context.ChangePin.ToListAsync();
        }

        // GET: api/ChangePins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChangePin>> GetChangePin(int id)
        {
            var changePin = await _context.ChangePin.FindAsync(id);

            if (changePin == null)
            {
                return NotFound();
            }

            return changePin;
        }

        // PUT: api/ChangePins/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChangePin(int id, ChangePin changePin)
        {
            if (id != changePin.id)
            {
                return BadRequest();
            }

            _context.Entry(changePin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChangePinExists(id))
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

        // POST: api/ChangePins
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChangePin>> PostChangePin(ChangePin changePin)
        {
            _context.ChangePin.Add(changePin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChangePin", new { id = changePin.id }, changePin);
        }

        // DELETE: api/ChangePins/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChangePin>> DeleteChangePin(int id)
        {
            var changePin = await _context.ChangePin.FindAsync(id);
            if (changePin == null)
            {
                return NotFound();
            }

            _context.ChangePin.Remove(changePin);
            await _context.SaveChangesAsync();

            return changePin;
        }

        private bool ChangePinExists(int id)
        {
            return _context.ChangePin.Any(e => e.id == id);
        }
    }
}
