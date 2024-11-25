using Microsoft.AspNetCore.Mvc;

namespace asp_net_restful_api.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
