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
    public class StaffsController : ControllerBase
    {
        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private IUnitOfWork unitOfWork;

        public StaffsController(ApplicationDbContext context)
        {
            //Refractored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Staffs
        [HttpGet]
        //Refractored
        //public async Task<ActionResult<IEnumerable<Staff>>> GetStaffs()
        public async Task<IActionResult> GetStaffs()
        {
            //return await _context.Staffs.ToListAsync();
            var Staffs = await _unitOfWork.Staffs.GetAll();
            return Ok(Staffs);
        }

        // GET: api/Staffs/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Staff>> GetStaff(int id)
        public async Task<IActionResult> GetStaff(int id)
        {
            //var Staff = await _context.Staffs.FindAsync(id);
            var Staff = await _unitOfWork.Staffs.Get(q => q.Id == id);

            if (Staff == null)
            {
                return NotFound();
            }

            return Ok(Staff);
        }

        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff Staff)
        {
            if (id != Staff.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Staff).State = EntityState.Modified;
            _unitOfWork.Staffs.Update(Staff);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!StaffExists(id))
                if (!await StaffExists(id))
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

        // POST: api/Staffs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff Staff)
        {
            //_context.Staffs.Add(Staff);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Staffs.Insert(Staff);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = Staff.Id }, Staff);
        }

        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            //var Staff = await _context.Staffs.FindAsync(id);
            var Staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            if (Staff == null)
            {
                return NotFound();
            }

            //_context.Staffs.Remove(Staff);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool StaffExists(int id)
        private async Task<bool> StaffExists(int id)
        {
            //return _context.Staffs.Any(e => e.Id == id);
            var Staff = await _unitOfWork.Staffs.Get(q => q.Id == id);
            return Staff != null;
        }
    }
}
