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

namespace Eventersers.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventerssController : ControllerBase
    {
        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private IUnitOfWork unitOfWork;

        public EventerssController(ApplicationDbContext context)
        {
            //Refractored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Eventerss
        [HttpGet]
        //Refractored
        //public async Task<ActionResult<IEnumerable<Eventers>>> GetEventerss()
        public async Task<IActionResult> GetEventerss()
        {
            //return await _context.Eventerss.ToListAsync();
            var Eventers = await _unitOfWork.Eventers.GetAll();
            return Ok(Eventers);
        }

        // GET: api/Eventerss/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Eventers>> GetEventers(int id)
        public async Task<IActionResult> GetEventers(int id)
        {
            //var Eventersee = await _context.Eventerss.FindAsync(id);
            var Eventersee = await _unitOfWork.Eventers.Get(q => q.Id == id);

            if (Eventersee == null)
            {
                return NotFound();
            }

            return Ok(Eventersee);
        }

        // PUT: api/Eventers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventers(int id, Eventers Eventers)
        {
            if (id != Eventers.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Eventersee).State = EntityState.Modified;
            _unitOfWork.Eventers.Update(Eventers);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!EventerseeExists(id))
                if (!await EventerseeExists(id))
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

        // POST: api/Eventersees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Eventersee>> PostEventersee(Eventersee Eventersee)
        {
            //_context.Eventersees.Add(Eventersee);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Eventersees.Insert(Eventersee);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetEventersee", new { id = Eventersee.Id }, Eventersee);
        }

        // DELETE: api/Eventersees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventersee(int id)
        {
            //var Eventersee = await _context.Eventersees.FindAsync(id);
            var Eventersee = await _unitOfWork.Eventersees.Get(q => q.Id == id);
            if (Eventersee == null)
            {
                return NotFound();
            }

            //_context.Eventersees.Remove(Eventersee);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Eventersees.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool EventerseeExists(int id)
        private async Task<bool> EventerseeExists(int id)
        {
            //return _context.Eventersees.Any(e => e.Id == id);
            var Eventersee = await _unitOfWork.Eventersees.Get(q => q.Id == id);
            return Eventersee != null;
        }
    }
}
