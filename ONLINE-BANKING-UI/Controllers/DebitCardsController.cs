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
    public class DebitCardsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public DebitCardsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/DebitCards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DebitCard>>> GetDebitCard()
        {
            return await _context.DebitCard.ToListAsync();
        }

        // GET: api/DebitCards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DebitCard>> GetDebitCard(Guid id)
        {
            var debitCard = await _context.DebitCard.FindAsync(id);

            if (debitCard == null)
            {
                return NotFound();
            }

            return debitCard;
        }

        // PUT: api/DebitCards/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDebitCard(Guid id, DebitCard debitCard)
        {
            if (id != debitCard.Id)
            {
                return BadRequest();
            }

            _context.Entry(debitCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DebitCardExists(id))
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

        // POST: api/DebitCards
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DebitCard>> PostDebitCard(DebitCard debitCard)
        {
            _context.DebitCard.Add(debitCard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDebitCard", new { id = debitCard.Id }, debitCard);
        }

        // DELETE: api/DebitCards/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DebitCard>> DeleteDebitCard(Guid id)
        {
            var debitCard = await _context.DebitCard.FindAsync(id);
            if (debitCard == null)
            {
                return NotFound();
            }

            _context.DebitCard.Remove(debitCard);
            await _context.SaveChangesAsync();

            return debitCard;
        }

        private bool DebitCardExists(Guid id)
        {
            return _context.DebitCard.Any(e => e.Id == id);
        }
    }
}
