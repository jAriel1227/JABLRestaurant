using Microsoft.AspNetCore.Mvc;

namespace RestauranteAPI.WebApi.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
