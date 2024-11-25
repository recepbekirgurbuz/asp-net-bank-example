using Microsoft.AspNetCore.Mvc;

namespace asp_net_restful_api.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
