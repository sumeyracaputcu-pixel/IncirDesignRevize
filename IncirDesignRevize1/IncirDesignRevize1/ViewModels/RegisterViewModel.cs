using System.ComponentModel.DataAnnotations;

namespace IncirDesignRevize1.ViewModels
{
    

        // Üye Ol formundan gelen verileri taşıyacak sınıf
        public class RegisterViewModel
        {
            // ─────────────────────────────────────────────────────────
            // AD ALANI
            // ─────────────────────────────────────────────────────────
            [Required(ErrorMessage = "Ad alanı zorunludur")]
            [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olabilir")]
            [Display(Name = "Adınız")]
            public string Ad { get; set; } = string.Empty;

            // ─────────────────────────────────────────────────────────
            // SOYAD ALANI
            // ─────────────────────────────────────────────────────────
            [Required(ErrorMessage = "Soyad alanı zorunludur")]
            [StringLength(50, ErrorMessage = "Soyad en fazla 50 karakter olabilir")]
            [Display(Name = "Soyadınız")]
            public string Soyad { get; set; } = string.Empty;

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
            [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifre en az 6 karakter olmalıdır")]
            [DataType(DataType.Password)]
            [Display(Name = "Şifre")]
            public string Password { get; set; } = string.Empty;

            // ─────────────────────────────────────────────────────────
            // ŞİFRE TEKRAR ALANI
            // ─────────────────────────────────────────────────────────
            [Required(ErrorMessage = "Şifre tekrar alanı zorunludur")]
            [DataType(DataType.Password)]
            [Display(Name = "Şifre Tekrar")]
            [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor")]
            public string ConfirmPassword { get; set; } = string.Empty;
        }
    }

