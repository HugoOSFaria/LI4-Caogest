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
    public class DonativosController : ControllerBase
    {
        private readonly trial2Context _context;

        public DonativosController(trial2Context context)
        {
            _context = context;
        }

        // GET: api/Donativos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donativos>>> GetDonativos()
        {
            var donativos = await _context.Donativos.ToListAsync();


            foreach (var don in donativos)
            {
                don.utilizador_user_email = await (from d in _context.Utilizador
                                                   where d.email == don.utilizador_user_email
                                                   select d.nome).FirstOrDefaultAsync();
                don.utilizador_user_email = Encriptar.Decrypt(don.utilizador_user_email, "1c2b3a");

                don.canil_user_email = await (from us in _context.Canil
                                              where us.email == don.canil_user_email
                                              select us.nome).FirstOrDefaultAsync();
                don.canil_user_email = Encriptar.Decrypt(don.canil_user_email, "bac321");
            }

            if (donativos == null)
            {
                return NotFound();
            }

            return donativos;
        }

        // GET: api/Donativos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Donativos>>> GetDonativos(string id)
        {
            var donativos = await (from d in _context.Donativos
                                   where d.canil_user_email == id
                                   select d).ToListAsync();

            foreach (var don in donativos)
            {
                don.utilizador_user_email = await (from d in _context.Utilizador
                                                   where d.email == don.utilizador_user_email
                                                   select d.nome).FirstOrDefaultAsync();
                don.utilizador_user_email = Encriptar.Decrypt(don.utilizador_user_email, "1c2b3a");

                don.canil_user_email = await (from us in _context.Canil
                                              where us.email == don.canil_user_email
                                              select us.nome).FirstOrDefaultAsync();
                don.canil_user_email = Encriptar.Decrypt(don.canil_user_email, "bac321");
            }

            if (donativos == null)
            {
                return NotFound();
            }

            return donativos;
        }

        // PUT: api/Donativos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonativos(int id, Donativos donativos)
        {
            if (id != donativos.id)
            {
                return BadRequest();
            }

            _context.Entry(donativos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonativosExists(id))
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

        // POST: api/Donativos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Donativos>> PostDonativos(Donativos donativos)
        {
            _context.Donativos.Add(donativos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DonativosExists(donativos.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDonativos", new { id = donativos.id }, donativos);
        }

        // DELETE: api/Donativos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Donativos>> DeleteDonativos(int id)
        {
            var donativos = await _context.Donativos.FindAsync(id);
            if (donativos == null)
            {
                return NotFound();
            }

            _context.Donativos.Remove(donativos);
            await _context.SaveChangesAsync();

            return donativos;
        }

        private bool DonativosExists(int id)
        {
            return _context.Donativos.Any(e => e.id == id);
        }
    }
}
