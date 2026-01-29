using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tp_5.Data;
using tp_5.Models;

namespace tp_5.Controllers
{
    [Authorize]
    public class PanierController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PanierController(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            
            var userProducts = await _context.Paniers
                .Include(p => p.Produit)
                .Where(p => p.UserID == userId)
                .Select(p => p.Produit)
                .ToListAsync();
            
            return View(userProducts);
        }
    }
}