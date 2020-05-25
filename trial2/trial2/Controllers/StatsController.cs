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
        public async Task<ActionResult<int>> GetStatsÃ()
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
    }
}
