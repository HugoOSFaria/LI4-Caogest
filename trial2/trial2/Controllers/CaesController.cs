using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trial2.Models;
using trial2.Results;

namespace trial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaesController : ControllerBase
    {
        private readonly trial2Context _context;

        public CaesController(trial2Context context)
        {
            _context = context;
        }

        // GET: api/Caes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReturnCao>>> GetCao()
        {
            List<ReturnCao> result = new List<ReturnCao>();
            
            var caes = await _context.Cao.ToListAsync();
            
            foreach(Cao cao in caes)
            {
                ReturnCao res = new ReturnCao();

                res.idCao = cao.idCao;
                res.nome = cao.nome;
                res.sexo = cao.sexo;
                res.descricao = cao.descricao;
                res.estado = cao.estado;
                res.raca = cao.raca;
                res.cor = cao.cor;
                res.idade = cao.idade;
                res.esterilizacao = cao.esterilizacao;
                res.porte = cao.porte;

                var fotos = await (from f in _context.Fotografia
                                   where f.cao_idCao == cao.idCao
                                   select f).ToListAsync();

                foreach (Fotografia f in fotos)
                {
                    res.fotos.Add(f);
                }

                result.Add(res);
            }
            
            return result;
        }

        // GET: api/Caes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReturnCao>> GetCao(int id)
        {
            var cao = await (from ca in _context.Cao
                             where ca.idCao == id
                             select ca).FirstOrDefaultAsync();
            
            if (cao == null)
            {
                return NotFound();
            }

            var fotos = await (from f in _context.Fotografia
                               where f.cao_idCao == id
                               select f).ToListAsync();

            ReturnCao res = new ReturnCao();

            res.idCao = cao.idCao;
            res.nome = cao.nome;
            res.sexo = cao.sexo;
            res.descricao = cao.descricao;
            res.estado = cao.estado;
            res.raca = cao.raca;
            res.cor = cao.cor;
            res.idade = cao.idade;
            res.esterilizacao = cao.esterilizacao;
            res.porte = cao.porte;
            foreach(Fotografia f in fotos)
            {
                res.fotos.Add(f);
            }

            return res;
        }

        // PUT: api/Caes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCao(int id, Cao cao)
        {
            if (id != cao.idCao)
            {
                return BadRequest();
            }

            _context.Entry(cao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaoExists(id))
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

        // POST: api/Caes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cao>> PostCao(Cao cao)
        {
            _context.Cao.Add(cao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCao", new { id = cao.idCao }, cao);
        }

        // DELETE: api/Caes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cao>> DeleteCao(int id)
        {
            var cao = await _context.Cao.FindAsync(id);
            if (cao == null)
            {
                return NotFound();
            }

            _context.Cao.Remove(cao);
            await _context.SaveChangesAsync();

            return cao;
        }

        private bool CaoExists(int id)
        {
            return _context.Cao.Any(e => e.idCao == id);
        }
    }
}
