using Microsoft.AspNetCore.Identity;

namespace IncirDesignRevize1.Models
{
    public class AppRole:IdentityRole
    {
        // Rolün açıklaması (opsiyonel)
        public string? Aciklama { get; set; }
    }
}
