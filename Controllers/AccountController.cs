using asp_net_restful_api.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace asp_net_restful_api.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/loginPost")]
        public IActionResult LoginPost(string username, string password)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                return Content($"Hoş geldiniz, {user.Name} {user.Surname}!");
            }

            ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı.");
            return View();
        }
    }
}
