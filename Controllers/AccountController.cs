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

    }
}
