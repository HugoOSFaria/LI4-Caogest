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
    public class AdocoesCanilController : ControllerBase
    {
        private readonly trial2Context _context;

        public AdocoesCanilController(trial2Context context)
        {
            _context = context;
        }

      
        // GET: api/AdocoesCanil/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<ReturnAdo>>> GetAdocao(string id)
        {
            var adocao = await (from us in _context.Cao
                                join c in _context.Adocao on us.idCao equals c.cao_idCao
                                where us.canil_user_email == id
                                select c).ToListAsync();

            if (adocao == null)
            {
                return NotFound();
            }

            var AdReturn = new List<ReturnAdo>();

            foreach (var ad in adocao)
            {
                var res = new ReturnAdo
                {
                    nPedido = ad.nPedido,
                    data = ad.data,
                    estado = ad.estado,
                    cao_idCao = ad.cao_idCao.ToString(),
                    permissao = ad.permissao,
                    alergia = ad.alergia,
                    descAnimais = ad.descAnimais,
                    ausencia = ad.ausencia,
                    habitacao = ad.habitacao,
                    exterior = ad.exterior,
                    tipoMoradia = ad.tipoMoradia,
                    motivo = ad.motivo,
                    utilizador_user_email = ad.utilizador_user_email,
                    comprovativo = ad.comprovativo,
                    donoAnimal = ad.donoAnimal
                };
                res.utilizador_user_email = await (from us in _context.Utilizador
                                                   where us.email == ad.utilizador_user_email
                                                   select us.nome).FirstOrDefaultAsync();

                res.cao_idCao = await (from us in _context.Cao
                                       where us.idCao == ad.cao_idCao
                                       select us.nome).FirstOrDefaultAsync();

                res.nome_Canil = await (from us in _context.Canil
                                        join c in _context.Cao on us.email equals c.canil_user_email
                                        where c.idCao == ad.cao_idCao
                                        select us.nome).FirstOrDefaultAsync();

                res.cc = await (from us in _context.Utilizador
                                where us.email == ad.utilizador_user_email
                                select us.cc).FirstOrDefaultAsync();

                AdReturn.Add(res);
            };
            return AdReturn;
        }
    }
}