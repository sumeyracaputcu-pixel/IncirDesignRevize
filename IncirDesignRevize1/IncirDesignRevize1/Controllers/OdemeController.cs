using IncirDesignRevize1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace IncirDesignRevize1.Controllers
{
    [Authorize]
    public class OdemeController : Controller
    {
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObject<List<SessionCartItem>>("cart");

            if (cart == null || cart.Count == 0)
            {
                return RedirectToAction("Index", "Sepet");
            }

            return View(cart);
        }
    }

}
