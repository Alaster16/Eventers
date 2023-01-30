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
    public class EventersController : ControllerBase
    {
        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public EventersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET: api/Eventers
        [HttpGet]
        //Refractored
        //public async Task<ActionResult<IEnumerable<Eventer>>> GetEventers()
        public async Task<IActionResult> GetEventers()
        {
            //return await _context.Eventers.ToListAsync();
            var eventers = await _unitOfWork.EVENTERS.GetAll(includes: q => q.Include(x => x.Company).Include(x => x.Staff));
            return Ok(eventers);
        }

        // GET: api/Eventers/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Eventer>> GetEventer(int id)
        public async Task<IActionResult> GetEventer(int id)
        {
            //var Eventer = await _context.Eventers.FindAsync(id);
            var eventer = await _unitOfWork.EVENTERS.Get(q => q.Id == id);

            if (eventer == null)
            {
                return NotFound();
            }

            return Ok(eventer);
        }

        // PUT: api/Eventers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventer(int id, EVENTER eventer)
        {
            if (id != eventer.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Eventer).State = EntityState.Modified;
            _unitOfWork.EVENTERS.Update(eventer);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!EventerExists(id))
                if (!await EventerExists(id))
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

        // POST: api/Eventers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EVENTER>> PostEventer(EVENTER eventer)
        {
            //_context.Eventers.Add(Eventer);
            //await _context.SaveChangesAsync();
            await _unitOfWork.EVENTERS.Insert(eventer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetEventer", new { id = eventer.Id }, eventer);
        }

        // DELETE: api/Eventers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventer(int id)
        {
            //var Eventer = await _context.Eventers.FindAsync(id);
            var eventer = await _unitOfWork.EVENTERS.Get(q => q.Id == id);
            if (eventer == null)
            {
                return NotFound();
            }

            //_context.Eventers.Remove(Eventer);
            //await _context.SaveChangesAsync();
            await _unitOfWork.EVENTERS.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool EventerExists(int id)
        private async Task<bool> EventerExists(int id)
        {
            //return _context.Eventers.Any(e => e.Id == id);
            var eventer = await _unitOfWork.EVENTERS.Get(q => q.Id == id);
            return eventer != null;
        }
    }
}
