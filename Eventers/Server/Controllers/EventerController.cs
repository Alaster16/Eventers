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
        private IUnitOfWork unitOfWork;

        public EventersController(ApplicationDbContext context)
        {
            //Refractored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Eventers
        [HttpGet]
        //Refractored
        //public async Task<ActionResult<IEnumerable<Eventer>>> GetEventers()
        public async Task<IActionResult> GetEventers()
        {
            //return await _context.Eventers.ToListAsync();
            var Eventers = await _unitOfWork.Eventers.GetAll();
            return Ok(Eventers);
        }

        // GET: api/Eventers/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Eventer>> GetEventer(int id)
        public async Task<IActionResult> GetEventer(int id)
        {
            //var Eventer = await _context.Eventers.FindAsync(id);
            var Eventer = await _unitOfWork.Eventers.Get(q => q.Id == id);

            if (Eventer == null)
            {
                return NotFound();
            }

            return Ok(Eventer);
        }

        // PUT: api/Eventers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventer(int id, Eventer Eventer)
        {
            if (id != Eventer.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Eventer).State = EntityState.Modified;
            _unitOfWork.Eventers.Update(Eventer);

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
        public async Task<ActionResult<Eventer>> PostEventer(Eventer Eventer)
        {
            //_context.Eventers.Add(Eventer);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Eventers.Insert(Eventer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetEventer", new { id = Eventer.Id }, Eventer);
        }

        // DELETE: api/Eventers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventer(int id)
        {
            //var Eventer = await _context.Eventers.FindAsync(id);
            var Eventer = await _unitOfWork.Eventers.Get(q => q.Id == id);
            if (Eventer == null)
            {
                return NotFound();
            }

            //_context.Eventers.Remove(Eventer);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Eventers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool EventerExists(int id)
        private async Task<bool> EventerExists(int id)
        {
            //return _context.Eventers.Any(e => e.Id == id);
            var Eventer = await _unitOfWork.Eventers.Get(q => q.Id == id);
            return Eventer != null;
        }
    }
}
