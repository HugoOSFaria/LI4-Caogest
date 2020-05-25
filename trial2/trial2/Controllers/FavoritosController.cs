using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trial2.Models;

namespace trial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritosController : ControllerBase
    {
        private readonly trial2Context _context;

        public FavoritosController(trial2Context context)
        {
            _context = context;
        }

        // GET: api/Favoritos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Favoritos>>> GetFavoritos()
        {
            return await _context.Favoritos.ToListAsync();
        }

        // GET: api/Favoritos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Cao>>> GetFavoritos(string id)
        {
            var favoritos = await (from us in _context.Favoritos
                                   join c in _context.Cao on us.cao_idCao equals c.idCao
                                   where us.utilizador_user_email == id
                                   select c).ToListAsync();

            if (favoritos == null)
            {
                return NotFound();
            }

            return favoritos;
        }

        // PUT: api/Favoritos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoritos(string id, Favoritos favoritos)
        {
            if (id != favoritos.utilizador_user_email)
            {
                return BadRequest();
            }

            _context.Entry(favoritos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoritosExists(id))
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

        // POST: api/Favoritos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Favoritos>> PostFavoritos(Favoritos favoritos)
        {
            _context.Favoritos.Add(favoritos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FavoritosExists(favoritos.utilizador_user_email))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFavoritos", new { id = favoritos.utilizador_user_email }, favoritos);
        }

        // DELETE: api/Favoritos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Favoritos>> DeleteFavoritos(string id)
        {
            var favoritos = await _context.Favoritos.FindAsync(id);
            if (favoritos == null)
            {
                return NotFound();
            }

            _context.Favoritos.Remove(favoritos);
            await _context.SaveChangesAsync();

            return favoritos;
        }

        private bool FavoritosExists(string id)
        {
            return _context.Favoritos.Any(e => e.utilizador_user_email == id);
        }
    }
}
