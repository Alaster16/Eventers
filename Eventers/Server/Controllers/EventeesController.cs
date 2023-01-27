using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eventers.Server.Data;
using Eventers.Shared.Domain;
using Eventers.Server.IRepository;

namespace Eventers.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventeesController : ControllerBase
    {
        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public EventeesController(ApplicationDbContext context)
        {
            //Refractored
            //_context = context;
            _unitOfWork = _unitOfWork;
        }

        // GET: api/Eventees
        [HttpGet]
        //Refractored
        //public async Task<ActionResult<IEnumerable<Eventee>>> GetEventees()
        public async Task<IActionResult> GetEventees()
        {
            //return await _context.Eventees.ToListAsync();
            var eventees = await _unitOfWork.Eventees.GetAll();
            return Ok(eventees);
        }

        // GET: api/Eventees/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Eventee>> GetEventee(int id)
        public async Task<IActionResult> GetEventee(int id)
        {
            //var eventee = await _context.Eventees.FindAsync(id);
            var eventee = await _unitOfWork.Eventees.Get(q => q.Id == id);

            if (eventee == null)
            {
                return NotFound();
            }

            return Ok(eventee);
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

            //_context.Entry(eventee).State = EntityState.Modified;
            _unitOfWork.Eventees.Update(eventee);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!EventeeExists(id))
                if (!await EventeeExists(id))
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
            //_context.Eventees.Add(eventee);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Eventees.Insert(eventee);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetEventee", new { id = eventee.Id }, eventee);
        }

        // DELETE: api/Eventees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventee(int id)
        {
            //var eventee = await _context.Eventees.FindAsync(id);
            var eventee = await _unitOfWork.Eventees.Get(q => q.Id == id);
            if (eventee == null)
            {
                return NotFound();
            }

            //_context.Eventees.Remove(eventee);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Eventees.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool EventeeExists(int id)
        private async Task<bool> EventeeExists(int id)
        {
            //return _context.Eventees.Any(e => e.Id == id);
            var eventee = await _unitOfWork.Eventees.Get(q => q.Id == id);
            return eventee != null;
        }
    }
}
