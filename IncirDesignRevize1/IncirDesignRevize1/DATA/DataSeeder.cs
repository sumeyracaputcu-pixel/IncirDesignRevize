using IncirDesignRevize1.Models;
using Microsoft.AspNetCore.Identity;

namespace IncirDesignRevize1.DATA
{
    public static class DataSeeder
    {

        // ═══════════════════════════════════════════════════════════════
        // ROLLERİ OLUŞTUR (Mevcut kod - değişiklik yok)
        // ═══════════════════════════════════════════════════════════════
        public static async Task SeedRolesAsync(RoleManager<AppRole> roleManager)
        {
            var roles = new List<(string RoleName, string Description)>
            {
                ("Admin", "Tam yetkili sistem yöneticisi"),
                ("Uye", "Standart üye")
            };

            foreach (var (roleName, description) in roles)
            {
                var roleExists = await roleManager.RoleExistsAsync(roleName);

                if (!roleExists)
                {
                    var role = new AppRole
                    {
                        Name = roleName,
                        Aciklama = description
                    };

                    await roleManager.CreateAsync(role);
                }
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // ADMİN KULLANICISINI OLUŞTUR (Mevcut kod - değişiklik yok)
        // ═══════════════════════════════════════════════════════════════
        public static async Task SeedAdminUserAsync(
            UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager)
        {
            string adminEmail = "admin@incirdesign.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser = new AppUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    Ad = "Sistem",
                    Soyad = "Yöneticisi",
                    EmailConfirmed = true,
                    KayitTarihi = DateTime.Now
                };

                var result = await userManager.CreateAsync(adminUser, "Admin123!");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }


        // ═══════════════════════════════════════════════════════════════
        // YENİ: TEST ÜYESİ OLUŞTUR
        // ═══════════════════════════════════════════════════════════════
        public static async Task SeedTestMemberAsync(
            UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager)
        {
            string memberEmail = "uye@incirdesign.com";
            var memberUser = await userManager.FindByEmailAsync(memberEmail);

            if (memberUser == null)
            {
                memberUser = new AppUser
                {
                    UserName = memberEmail,
                    Email = memberEmail,
                    Ad = "Test",
                    Soyad = "Üye",
                    EmailConfirmed = true,
                    KayitTarihi = DateTime.Now
                };

                var result = await userManager.CreateAsync(memberUser, "Uye123!");

                if (result.Succeeded)
                {
                    // Kullanıcıyı Uye rolüne ekle
                    await userManager.AddToRoleAsync(memberUser, "Uye");
                }
            }
        }

        // ═══════════════════════════════════════════════════════════════
        // TÜM SEED İŞLEMLERİNİ ÇALIŞTIR (Güncellendi)
        // ═══════════════════════════════════════════════════════════════
        public static async Task SeedAllAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<AppRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

            // 1. Önce rolleri oluştur
            await SeedRolesAsync(roleManager);

            // 2. Admin kullanıcısını oluştur
            await SeedAdminUserAsync(userManager, roleManager);


            // 3. Test üyesini oluştur
            await SeedTestMemberAsync(userManager, roleManager);
        }
    }
}

