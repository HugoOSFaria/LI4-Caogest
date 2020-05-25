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
    public class CaesEmailCanilController : ControllerBase
    {
        private readonly trial2Context _context;

        public CaesEmailCanilController(trial2Context context)
        {
            _context = context;
        }

        // GET: api/Caes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Cao>>> GetCao(string id)
        {
            var cao = await (from ca in _context.Cao
                             where ca.canil_user_email == id
                             select ca).ToListAsync();

            if (cao == null)
            {
                return NotFound();
            }

            return cao;
        }
    }
}