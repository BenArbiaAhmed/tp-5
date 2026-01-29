using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using tp_5.Models;

namespace tp_5.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult UserList()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
    }
}