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
    public class StatsController : ControllerBase
    {
        private readonly trial2Context _context;

        public StatsController(trial2Context context)
        {
            _context = context;
        }

        // GET: api/Status/Users
        [HttpGet("Users")]
        public async Task<ActionResult<int>> GetStatsU()
        {
            var users = await (from u in _context.User
                               select u).ToListAsync();
            if (users == null)
            {
                return NotFound();
            }

            int count = users.Count();

            return count;
        }

        // GET: api/Status/Voluntarios
        [HttpGet("Voluntarios")]
        public async Task<ActionResult<int>> GetStatsV()
        {
            var users = await (from v in _context.Voluntarios
                               select v).ToListAsync();
            if (users == null)
            {
                return NotFound();
            }

            int count = users.Count();

            return count;
        }

        // GET: api/Status/Caes
        [HttpGet("Caes")]
        public async Task<ActionResult<int>> GetStatsC()
        {
            var users = await (from c in _context.Cao
                               select c).ToListAsync();
            if (users == null)
            {
                return NotFound();
            }

            int count = users.Count();

            return count;
        }

        // GET: api/Status/Adocoes
        [HttpGet("Adocoes")]
        public async Task<ActionResult<int>> GetStatsA()
        {
            var users = await (from a in _context.Adocao
                               where a.estado == "Aceite"
                               select a).ToListAsync();
            if (users == null)
            {
                return NotFound();
            }

            int count = users.Count();

            return count;
        }

        // GET: api/Status/Pedidos/5
        [HttpGet("Pedidos/Mes")]
        public async Task<ActionResult<List<int>>> GetStatsPM()
        {
            var users = await (from a in _context.Adocao
                               where a.estado == "Aceite"
                               select a).ToListAsync();
            
            if (users == null)
            {
                return NotFound();
            }

            List<int> valores = new List<int>();
            
            for(int i=0; i< 12; i++) valores.Add(0);

            foreach(Adocao a in users)
            {
                if (a.data.Month == 1) valores[0]++;
                else if (a.data.Month == 2) valores[1]++;
                else if (a.data.Month == 3) valores[2]++;
                else if (a.data.Month == 4) valores[3]++;
                else if (a.data.Month == 5) valores[4]++;
                else if (a.data.Month == 6) valores[5]++;
                else if (a.data.Month == 7) valores[6]++;
                else if (a.data.Month == 8) valores[7]++;
                else if (a.data.Month == 9) valores[8]++;
                else if (a.data.Month == 10) valores[9]++;
                else if (a.data.Month == 11) valores[10]++;
                else valores[11]++;
            }

            return valores;
        }

        // GET: api/Status/Pedidos/Cao
        [HttpGet("Pedidos/Cao")]
        public async Task<ActionResult<List<int>>> GetStatsPC()
        {
            var pequenos = await (from a in _context.Adocao
                                  join c in _context.Cao on a.cao_idCao equals c.idCao
                                  where a.estado == "Aceite" && c.porte == "Pequeno"
                                  select a).ToListAsync();

            var medios = await (from a in _context.Adocao
                                  join c in _context.Cao on a.cao_idCao equals c.idCao
                                  where a.estado == "Aceite" && c.porte == "Medio"
                                  select a).ToListAsync();
            
            var grandes = await (from a in _context.Adocao
                                  join c in _context.Cao on a.cao_idCao equals c.idCao
                                  where a.estado == "Aceite" && c.porte == "Grande"
                                  select a).ToListAsync();

            if (pequenos == null || medios == null || grandes == null)
            {
                return NotFound();
            }
            
            List<int> valores = new List<int>();

            valores.Add(pequenos.Count());
            valores.Add(medios.Count());
            valores.Add(grandes.Count());

            return valores;
        }
    }
}
