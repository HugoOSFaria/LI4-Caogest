using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trial2.Models;
using trial2.Results;

namespace trial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Cookies,Bearer")]
    public class FotografiasController : ControllerBase
    {
        private readonly trial2Context _context;

        public FotografiasController(trial2Context context)
        {
            _context = context;
        }

        // GET: api/Fotografias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fotografia>>> GetFotografia()
        {
            return await _context.Fotografia.ToListAsync();
        }

        // GET: api/Fotografias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fotografia>> GetFotografia(int id)
        {
            var fotografia = await (from f in _context.Fotografia
                                    where f.idFotografia == id
                                    select f).FirstOrDefaultAsync(); ;

            if (fotografia == null)
            {
                return NotFound();
            }

            return fotografia;
        }

        // PUT: api/Fotografias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFotografia(int id, Fotografia fotografia)
        {
            if (id != fotografia.idFotografia)
            {
                return BadRequest();
            }

            _context.Entry(fotografia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FotografiaExists(id))
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

        // POST: api/Fotografias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<string>> PostFotografia(RecieveFoto fotografia)
        {
            var foto = new Fotografia();
            var fotos = await (from f in _context.Fotografia
                               select f).ToListAsync();
            if (fotos == null)
            {
                foto.idFotografia = 1;
            }
            else
            {
                foto.idFotografia = fotos.Count() + 1;
            }
            foto.path = fotografia.path;
            foto.cao_idCao = fotografia.cao_idCao;
            string file = "C:\\Users\\Pedro Duarte\\Desktop\\"+ foto.path;
            using (var stream = System.IO.File.Create(file))
            {

                await fotografia.file.Files[0].CopyToAsync(stream);
            }
            _context.Fotografia.Add(foto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFotografia", new { id = foto.idFotografia }, fotografia);
        }


        // POST: api/Fotografias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("File")]
        public async Task<ActionResult<string>> PostFotografiaFile(IFormCollection fotografia)
        {
            string file = "C:\\Users\\Pedro Duarte\\Desktop\\aaaa.jpg";
            using (var stream = System.IO.File.Create(file))
            {

                await fotografia.Files[0].CopyToAsync(stream);
            }
            return "Complete";
        }

        // DELETE: api/Fotografias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fotografia>> DeleteFotografia(int id)
        {
            var fotografia = await _context.Fotografia.FindAsync(id);
            if (fotografia == null)
            {
                return NotFound();
            }

            _context.Fotografia.Remove(fotografia);
            await _context.SaveChangesAsync();

            return fotografia;
        }

        private bool FotografiaExists(int id)
        {
            return _context.Fotografia.Any(e => e.idFotografia == id);
        }
    }
}
