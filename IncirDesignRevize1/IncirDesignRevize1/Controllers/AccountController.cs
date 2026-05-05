using IncirDesignRevize1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using IncirDesignRevize1.ViewModels;



namespace IncirDesignRevize1.Controllers
{
    public class AccountController : Controller
    {
        // ═══════════════════════════════════════════════════════════════
        // DEPENDENCY INJECTION (Bağımlılık Enjeksiyonu)
        // ═══════════════════════════════════════════════════════════════
        // Bu sınıfları Constructor'da alıyoruz
        // Hatırla: Biz kullanıcı tablosuna direkt erişmiyoruz
        // Bu sınıflar bizim yerimize güvenli işlem yapıyor

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        // Constructor
        public AccountController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // ═══════════════════════════════════════════════════════════════
        // ÜYE OL (REGISTER) - GET
        // ═══════════════════════════════════════════════════════════════
        // Kullanıcı /Account/Register adresine geldiğinde bu metot çalışır
        // Boş bir form gösteriyoruz
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // ═══════════════════════════════════════════════════════════════
        // ÜYE OL (REGISTER) - POST
        // ═══════════════════════════════════════════════════════════════
        // Form doldurulup gönderildiğinde bu metot çalışır
        [HttpPost]
        [ValidateAntiForgeryToken]  // CSRF saldırılarına karşı koruma
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            // Form doğrulaması başarılı mı?
            if (ModelState.IsValid)
            {
                // ─────────────────────────────────────────────────────────
                // ADIM 1: Yeni kullanıcı nesnesi oluştur
                // ─────────────────────────────────────────────────────────
                // CRUD'da şöyle yapardık: var user = new User { ... };
                // Identity'de de benzer, sadece sınıf adı farklı
                var user = new AppUser
                {
                    UserName = model.Email,      // Kullanıcı adı olarak e-posta
                    Email = model.Email,
                    Ad = model.Ad,
                    Soyad = model.Soyad,
                    KayitTarihi = DateTime.Now
                };

                // ─────────────────────────────────────────────────────────
                // ADIM 2: Kullanıcıyı veritabanına kaydet
                // ─────────────────────────────────────────────────────────
                // CRUD'da: _context.Users.Add(user); _context.SaveChanges();
                // Identity'de: _userManager.CreateAsync(user, şifre);
                // 
                // CreateAsync ne yapıyor?
                // 1. Şifreyi hash'liyor (şifreliyor)
                // 2. Kullanıcıyı veritabanına kaydediyor
                // 3. Sonucu IdentityResult olarak döndürüyor
                var result = await _userManager.CreateAsync(user, model.Password);

                // ─────────────────────────────────────────────────────────
                // ADIM 3: Sonucu kontrol et
                // ─────────────────────────────────────────────────────────
                if (result.Succeeded)
                {
                    // Başarılı! Kullanıcıyı "Üye" rolüne ekle
                    await _userManager.AddToRoleAsync(user, "Uye");

                    // Otomatik giriş yap
                    // isPersistent: false = Tarayıcı kapanınca oturum kapansın
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    // Ana sayfaya yönlendir
                    return RedirectToAction("Index", "Home");
                }

                // ─────────────────────────────────────────────────────────
                // HATA DURUMU
                // ─────────────────────────────────────────────────────────
                // Kayıt başarısız olduysa hataları ModelState'e ekle
                // Bu hatalar View'da görünecek
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // Hata varsa formu tekrar göster
            return View(model);
        }

        // ═══════════════════════════════════════════════════════════════
        // GİRİŞ YAP (LOGIN) - GET
        // ═══════════════════════════════════════════════════════════════
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            // returnUrl: Kullanıcı korumalı sayfaya gitmeye çalıştıysa
            // giriş yaptıktan sonra o sayfaya yönlendirmek için kullanılır
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        // ═══════════════════════════════════════════════════════════════
        // GİRİŞ YAP (LOGIN) - POST
        // ═══════════════════════════════════════════════════════════════
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                // ─────────────────────────────────────────────────────────
                // GİRİŞ DENEMESİ
                // ─────────────────────────────────────────────────────────
                // PasswordSignInAsync ne yapıyor?
                // 1. E-posta ile kullanıcıyı bulur
                // 2. Şifreyi hash'leyip karşılaştırır
                // 3. Başarılıysa cookie oluşturur
                // 4. Başarısızsa hata döndürür
                //
                // Parametreler:
                // - model.Email: Kullanıcı adı (bizde e-posta)
                // - model.Password: Girilen şifre
                // - model.RememberMe: Beni hatırla seçeneği
                // - lockoutOnFailure: Başarısız girişte hesabı kilitle
                var result = await _signInManager.PasswordSignInAsync(
                    model.Email,
                    model.Password,
                    model.RememberMe,
                    lockoutOnFailure: true  // 5 yanlış girişte hesap kilitlenir
                );

                if (result.Succeeded)
                {
                    // Giriş başarılı!
                    // returnUrl varsa oraya, yoksa ana sayfaya git
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }

                if (result.IsLockedOut)
                {
                    // Hesap kilitlendi
                    ModelState.AddModelError(string.Empty,
                        "Hesabınız geçici olarak kilitlendi. Lütfen 5 dakika sonra tekrar deneyin.");
                }
                else
                {
                    // Şifre veya e-posta yanlış
                    ModelState.AddModelError(string.Empty,
                        "Geçersiz giriş denemesi. E-posta veya şifre hatalı.");
                }
            }

            return View(model);
        }

        // ═══════════════════════════════════════════════════════════════
        // ÇIKIŞ YAP (LOGOUT)
        // ═══════════════════════════════════════════════════════════════
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // SignOutAsync ne yapıyor?
            // 1. Cookie'yi siler
            // 2. Oturumu sonlandırır
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        // ═══════════════════════════════════════════════════════════════
        // YETKİ YOK SAYFASI (ACCESS DENIED)
        // ═══════════════════════════════════════════════════════════════
        // Kullanıcı yetkisi olmayan sayfaya gitmeye çalışırsa buraya yönlendirilir
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }

}
