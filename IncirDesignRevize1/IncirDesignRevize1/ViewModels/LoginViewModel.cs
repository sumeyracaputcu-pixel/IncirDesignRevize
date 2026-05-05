using System.ComponentModel.DataAnnotations;

namespace IncirDesignRevize1.ViewModels
{
        // Giriş Yap formundan gelen verileri taşıyacak sınıf
        public class LoginViewModel
        {
            // ─────────────────────────────────────────────────────────
            // E-POSTA ALANI
            // ─────────────────────────────────────────────────────────
            [Required(ErrorMessage = "E-posta alanı zorunludur")]
            [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]
            [Display(Name = "E-posta")]
            public string Email { get; set; } = string.Empty;

            // ─────────────────────────────────────────────────────────
            // ŞİFRE ALANI
            // ─────────────────────────────────────────────────────────
            [Required(ErrorMessage = "Şifre alanı zorunludur")]
            [DataType(DataType.Password)]
            [Display(Name = "Şifre")]
            public string Password { get; set; } = string.Empty;

            // ─────────────────────────────────────────────────────────
            // BENİ HATIRLA
            // ─────────────────────────────────────────────────────────
            [Display(Name = "Beni Hatırla")]
            public bool RememberMe { get; set; }
        }
    }

