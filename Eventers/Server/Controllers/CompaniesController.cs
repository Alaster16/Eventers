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
    public class CompaniesController : ControllerBase
    {
        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private IUnitOfWork unitOfWork;

        public CompaniesController(ApplicationDbContext context)
        {
            //Refractored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Companies
        [HttpGet]
        //Refractored
        //public async Task<ActionResult<IEnumerable<company>>> GetCompanies()
        public async Task<IActionResult> GetCompanies()
        {
            //return await _context.Companies.ToListAsync();
            var companies = await _unitOfWork.Companies.GetAll();
            return Ok(companies);
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<company>> Getcompany(int id)
        public async Task<IActionResult> GetCompany(int id)
        {
            //var company = await _context.Companies.FindAsync(id);
            var company = await _unitOfWork.Companies.Get(q => q.Id == id);

            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        // PUT: api/Companies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcompany(int id, Company company)
        {
            if (id != company.Id)
            {
                return BadRequest();
            }

            //_context.Entry(company).State = EntityState.Modified;
            _unitOfWork.Companies.Update(company);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!companyExists(id))
                if (!await companyExists(id))
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

        // POST: api/Companies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Company>> Postcompany(Company company)
        {
            //_context.Companies.Add(company);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Companies.Insert(company);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Getcompany", new { id = company.Id }, company);
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletecompany(int id)
        {
            //var company = await _context.Companies.FindAsync(id);
            var company = await _unitOfWork.Companies.Get(q => q.Id == id);
            if (company == null)
            {
                return NotFound();
            }

            //_context.Companies.Remove(company);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Companies.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool companyExists(int id)
        private async Task<bool> companyExists(int id)
        {
            //return _context.Companies.Any(e => e.Id == id);
            var company = await _unitOfWork.Companies.Get(q => q.Id == id);
            return company != null;
        }
    }
}
