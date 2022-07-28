using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Core.Application.Helpers;
using RestauranteAPI.Core.Application.DTOS.Account;
using RestauranteAPI.Core.Application.Interfaces.Services;
using RestauranteAPI.Core.Application.ViewModel.User;
using RestauranteAPI.WebApp.Middlewares;
using System.Linq;

namespace RestauranteAPI.WebApi.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserServices _userServices;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ValidateUserSession _validateUserSession;        
        private readonly IMapper _mapper;
        public AccountController(IUserServices services, RoleManager<IdentityRole> roleManager, ValidateUserSession validateUserSession, IMapper mapper)
        {
            _userServices = services;
            _roleManager = roleManager;
            _validateUserSession = validateUserSession;
            
            _mapper = mapper;
        }
        public IActionResult Login()
        {
            if (_validateUserSession.IsLogin())
            {
                var user = HttpContext.Session.Get<AuthenticationResponse>("user");
                return RedirectToRoute(new { action = user.Roles.Any(r => r == "ADMINISTRATOR") ? "DashBoard" : "Client", controller = "Home" });
            }

            return View(new LoginViewModel());
        }
    }
}
