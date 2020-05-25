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
    public class AdocoesController : ControllerBase
    {
        private readonly trial2Context _context;

        public AdocoesController(trial2Context context)
        {
            _context = context;
        }

        // GET: api/Adocoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReturnAdo>>> GetAdocao()
        {
            List<Adocao> ad = await _context.Adocao.ToListAsync();

            List<ReturnAdo> adocoes = new List<ReturnAdo>();
            foreach (var a in ad)
            {
                var res = new ReturnAdo
                {
                    nPedido = a.nPedido,
                    data = a.data,
                    estado = a.estado,
                    cao_idCao = a.cao_idCao.ToString(),
                    permissao = a.permissao,
                    alergia = a.alergia,
                    descAnimais = a.descAnimais,
                    ausencia = a.ausencia,
                    habitacao = a.habitacao,
                    exterior = a.exterior,
                    tipoMoradia = a.tipoMoradia,
                    motivo = a.motivo,
                    utilizador_user_email = a.utilizador_user_email,
                    comprovativo = a.comprovativo,
                    donoAnimal = a.donoAnimal
                };

                res.utilizador_user_email = await (from us in _context.Utilizador
                                                   where us.email == a.utilizador_user_email
                                                   select us.nome).FirstOrDefaultAsync();

                res.cao_idCao = await (from us in _context.Cao
                                       where us.idCao == a.cao_idCao
                                       select us.nome).FirstOrDefaultAsync();

                res.nome_Canil = await (from us in _context.Canil
                                        join c in _context.Cao on us.email equals c.canil_user_email
                                        where c.idCao == a.cao_idCao
                                        select us.nome).FirstOrDefaultAsync();

                res.cc = await (from us in _context.Utilizador
                                where us.email == a.utilizador_user_email
                                select us.cc).FirstOrDefaultAsync();

                adocoes.Add(res);
            }
            return adocoes;
        }

        // GET: api/Adocoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReturnAdo>> GetAdocao(int id)
        {
            var adocao = await (from us in _context.Adocao
                                where us.nPedido == id
                                select us).FirstOrDefaultAsync();

            if (adocao == null)
            {
                return NotFound();
            }

            var res = new ReturnAdo
            {
                nPedido = adocao.nPedido,
                data = adocao.data,
                estado = adocao.estado,
                cao_idCao = adocao.cao_idCao.ToString(),
                permissao = adocao.permissao,
                alergia = adocao.alergia,
                descAnimais = adocao.descAnimais,
                ausencia = adocao.ausencia,
                habitacao = adocao.habitacao,
                exterior = adocao.exterior,
                tipoMoradia = adocao.tipoMoradia,
                motivo = adocao.motivo,
                utilizador_user_email = adocao.utilizador_user_email,
                comprovativo = adocao.comprovativo,
                donoAnimal = adocao.donoAnimal
            };
            res.utilizador_user_email = await (from us in _context.Utilizador
                                               where us.email == adocao.utilizador_user_email
                                               select us.nome).FirstOrDefaultAsync();

            res.cao_idCao = await (from us in _context.Cao
                                   where us.idCao == adocao.cao_idCao
                                   select us.nome).FirstOrDefaultAsync();

            res.nome_Canil = await (from us in _context.Canil
                                    join c in _context.Cao on us.email equals c.canil_user_email
                                    where c.idCao == adocao.cao_idCao
                                    select us.nome).FirstOrDefaultAsync();

            res.cc = await (from us in _context.Utilizador
                            where us.email == adocao.utilizador_user_email
                            select us.cc).FirstOrDefaultAsync();

            return res;
        }

        // PUT: api/Adocoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdocao(int id, Adocao adocao)
        {
            if (id != adocao.nPedido)
            {
                return BadRequest();
            }

            _context.Entry(adocao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdocaoExists(id))
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

        // POST: api/Adocoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Adocao>> PostAdocao(Adocao adocao)
        {
            _context.Adocao.Add(adocao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdocao", new { id = adocao.nPedido }, adocao);
        }

        // DELETE: api/Adocoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Adocao>> DeleteAdocao(int id)
        {
            var adocao = await _context.Adocao.FindAsync(id);
            if (adocao == null)
            {
                return NotFound();
            }

            _context.Adocao.Remove(adocao);
            await _context.SaveChangesAsync();

            return adocao;
        }

        private bool AdocaoExists(int id)
        {
            return _context.Adocao.Any(e => e.nPedido == id);
        }
    }
}
