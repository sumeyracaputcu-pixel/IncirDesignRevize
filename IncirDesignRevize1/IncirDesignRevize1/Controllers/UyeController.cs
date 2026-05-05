using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IncirDesignRevize1.Controllers
{
    // Giriş yapmış TÜM kullanıcılar erişebilir
    // Rol belirtmedik, sadece [Authorize] dedik
    [Authorize]
    public class UyeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profil()
        {
            return View();
        }
    }
}
