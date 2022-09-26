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
    public class DepositeamountsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public DepositeamountsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Depositeamounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Depositeamount>>> GetDepositeamount()
        {
            return await _context.Depositeamount.ToListAsync();
        }

        // GET: api/Depositeamounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Depositeamount>> GetDepositeamount(int id)
        {
            var depositeamount = await _context.Depositeamount.FindAsync(id);

            if (depositeamount == null)
            {
                return NotFound();
            }

            return depositeamount;
        }

        // PUT: api/Depositeamounts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepositeamount(int id, Depositeamount depositeamount)
        {
            if (id != depositeamount.id)
            {
                return BadRequest();
            }

            _context.Entry(depositeamount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepositeamountExists(id))
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

        // POST: api/Depositeamounts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Depositeamount>> PostDepositeamount(Depositeamount depositeamount)
        {
            _context.Depositeamount.Add(depositeamount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepositeamount", new { id = depositeamount.id }, depositeamount);
        }

        // DELETE: api/Depositeamounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Depositeamount>> DeleteDepositeamount(int id)
        {
            var depositeamount = await _context.Depositeamount.FindAsync(id);
            if (depositeamount == null)
            {
                return NotFound();
            }

            _context.Depositeamount.Remove(depositeamount);
            await _context.SaveChangesAsync();

            return depositeamount;
        }

        private bool DepositeamountExists(int id)
        {
            return _context.Depositeamount.Any(e => e.id == id);
        }
    }
}
