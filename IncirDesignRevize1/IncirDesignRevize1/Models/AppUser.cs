using Microsoft.AspNetCore.Identity;

namespace IncirDesignRevize1.Models
{
    public class AppUser:IdentityUser

    {
        // Kullanıcının adı
        public string Ad { get; set; } = string.Empty;

        // Kullanıcının soyadı
        public string Soyad { get; set; } = string.Empty;

        // Hesabın oluşturulma tarihi
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
       

    }
}
