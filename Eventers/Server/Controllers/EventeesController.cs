using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eventers.Server.Data;
using Eventers.Shared.Domain;

namespace Eventers.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventeesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Eventees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eventee>>> GetEventees()
        {
            return await _context.Eventees.ToListAsync();
        }

        // GET: api/Eventees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eventee>> GetEventee(int id)
        {
            var eventee = await _context.Eventees.FindAsync(id);

            if (eventee == null)
            {
                return NotFound();
            }

            return eventee;
        }

        // PUT: api/Eventees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventee(int id, Eventee eventee)
        {
            if (id != eventee.Id)
            {
                return BadRequest();
            }

            _context.Entry(eventee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventeeExists(id))
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

        // POST: api/Eventees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Eventee>> PostEventee(Eventee eventee)
        {
            _context.Eventees.Add(eventee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventee", new { id = eventee.Id }, eventee);
        }

        // DELETE: api/Eventees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventee(int id)
        {
            var eventee = await _context.Eventees.FindAsync(id);
            if (eventee == null)
            {
                return NotFound();
            }

            _context.Eventees.Remove(eventee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventeeExists(int id)
        {
            return _context.Eventees.Any(e => e.Id == id);
        }
    }
}
