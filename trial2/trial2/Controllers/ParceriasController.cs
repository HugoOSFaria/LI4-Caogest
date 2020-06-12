using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trial2.Models;

namespace trial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ParceriasController : ControllerBase
    {
        private readonly trial2Context _context;

        public ParceriasController(trial2Context context)
        {
            _context = context;
        }

        // GET: api/Parcerias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parceria>>> GetParceria()
        {
            return await _context.Parceria.ToListAsync();
        }

        // GET: api/Parcerias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Parceria>> GetParceria(int id)
        {
            var parceria = await (from us in _context.Parceria
                                  where us.identificacao == id
                                  select us).FirstOrDefaultAsync();

            if (parceria == null)
            {
                return NotFound();
            }

            return parceria;
        }

  

        // PUT: api/Parcerias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParceria(int id, Parceria parceria)
        {
            if (id != parceria.identificacao)
            {
                return BadRequest();
            }

            _context.Entry(parceria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParceriaExists(id))
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

        // POST: api/Parcerias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Parceria>> PostParceria(Parceria parceria)
        {
            _context.Parceria.Add(parceria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParceria", new { id = parceria.identificacao }, parceria);
        }

        // DELETE: api/Parcerias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Parceria>> DeleteParceria(int id)
        {
            var parceria = await _context.Parceria.FindAsync(id);
            if (parceria == null)
            {
                return NotFound();
            }

            _context.Parceria.Remove(parceria);
            await _context.SaveChangesAsync();

            return parceria;
        }

        private bool ParceriaExists(int id)
        {
            return _context.Parceria.Any(e => e.identificacao == id);
        }
    }
}
