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
    public class HUController : ControllerBase
    {
        private readonly trial2Context _context;

        public HUController(trial2Context context)
        {
            _context = context;
        }

        // GET: api/HU
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Horario_has_Utilizador>>> GetHorarios_has_Utilizador()
        {
            return await _context.Horarios_has_Utilizador.ToListAsync();
        }

        // GET: api/HU/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Horario>>> GetHorarios_has_Utilizador(string id)
        {
            var horarios_has_Utilizador = await (from us in _context.Horarios_has_Utilizador
                                                 join c in _context.Horario on us.horario_DataInicio equals c.dataInicio
                                                 join l in _context.Horario on us.horario_DataFim equals l.dataFim
                                                 join s in _context.Horario on us.horario_Dia equals s.dia
                                                 where us.utilizador_email == id
                                                 select c).ToListAsync();

            if (horarios_has_Utilizador == null)
            {
                return NotFound();
            }

            return horarios_has_Utilizador;
        }

        // PUT: api/HU/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHorarios_has_Utilizador(DateTime id, Horario_has_Utilizador horarios_has_Utilizador)
        {
            if (id != horarios_has_Utilizador.horario_DataInicio)
            {
                return BadRequest();
            }

            _context.Entry(horarios_has_Utilizador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Horarios_has_UtilizadorExists(id))
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

        // POST: api/HU
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Horario_has_Utilizador>> PostHorarios_has_Utilizador(Horario_has_Utilizador horarios_has_Utilizador)
        {
            _context.Horarios_has_Utilizador.Add(horarios_has_Utilizador);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Horarios_has_UtilizadorExists(horarios_has_Utilizador.horario_DataInicio))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHorarios_has_Utilizador", new { id = horarios_has_Utilizador.horario_DataInicio }, horarios_has_Utilizador);
        }

        // DELETE: api/HU/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Horario_has_Utilizador>> DeleteHorarios_has_Utilizador(DateTime id)
        {
            var horarios_has_Utilizador = await _context.Horarios_has_Utilizador.FindAsync(id);
            if (horarios_has_Utilizador == null)
            {
                return NotFound();
            }

            _context.Horarios_has_Utilizador.Remove(horarios_has_Utilizador);
            await _context.SaveChangesAsync();

            return horarios_has_Utilizador;
        }

        private bool Horarios_has_UtilizadorExists(DateTime id)
        {
            return _context.Horarios_has_Utilizador.Any(e => e.horario_DataInicio == id);
        }
    }
}
