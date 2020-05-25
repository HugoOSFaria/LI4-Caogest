using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trial2.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace trial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly trial2Context _context;

        public LoginController(trial2Context context)
        {
            _context = context;
        }

        // POST: api/Login
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<string>> LoginUser(User user)
        {
            var check = await (from u in _context.User
                               where u.email == user.email
                               select u).FirstOrDefaultAsync();

            if (check != null)
            {
                if (check.password != user.password)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.email)
                    };
                    ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);
                    return "Password errada";
                }
                else
                {
                    return "Correto";
                }
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<string> Logout()
        {
            await HttpContext.SignOutAsync();
            return "Logout";
        }
    }
}
