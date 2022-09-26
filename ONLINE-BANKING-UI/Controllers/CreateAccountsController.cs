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
    public class CreateAccountsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CreateAccountsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/CreateAccounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CreateAccount>>> GetCreateAccount()
        {
            return await _context.CreateAccount.ToListAsync();
        }

        // GET: api/CreateAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CreateAccount>> GetCreateAccount(int id)
        {
            var createAccount = await _context.CreateAccount.FindAsync(id);

            if (createAccount == null)
            {
                return NotFound();
            }

            return createAccount;
        }

        // PUT: api/CreateAccounts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCreateAccount(int id, CreateAccount createAccount)
        {
            if (id != createAccount.Id)
            {
                return BadRequest();
            }

            _context.Entry(createAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreateAccountExists(id))
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

        // POST: api/CreateAccounts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CreateAccount>> PostCreateAccount(CreateAccount createAccount)
        {
            _context.CreateAccount.Add(createAccount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCreateAccount", new { id = createAccount.Id }, createAccount);
        }

        // DELETE: api/CreateAccounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CreateAccount>> DeleteCreateAccount(int id)
        {
            var createAccount = await _context.CreateAccount.FindAsync(id);
            if (createAccount == null)
            {
                return NotFound();
            }

            _context.CreateAccount.Remove(createAccount);
            await _context.SaveChangesAsync();

            return createAccount;
        }

        private bool CreateAccountExists(int id)
        {
            return _context.CreateAccount.Any(e => e.Id == id);
        }
    }
}
