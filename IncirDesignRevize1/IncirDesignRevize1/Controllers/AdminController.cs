using IncirDesignRevize1.DATA;
using IncirDesignRevize1.Models;
using IncirDesignRevize1.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IncirDesignRevize1.Controllers
{// ═══════════════════════════════════════════════════════════════
    // [Authorize(Roles = "Admin")] NE DEMEK?
    // ═══════════════════════════════════════════════════════════════
    // Bu controller'a SADECE "Admin" rolündeki kullanıcılar erişebilir
    // Diğer herkes AccessDenied sayfasına yönlendirilir
    //
    // CRUD bilgini kullan:
    // if (currentUser.Role != "Admin") return Unauthorized();
    // işlemini otomatik yapıyor
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        // 📌 ÜRÜN LİSTESİ (SİLME SAYFASI GİBİ)
        public IActionResult Products()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        // 📌 ÜRÜN EKLE SAYFASI
        public IActionResult AddProduct()
        {
            return View();
        }

        // 📌 ÜRÜN EKLEME POST
        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Products");
            }

            return View(model);
        }

        // 📌 AKTİF / PASİF
        public IActionResult ToggleStatus(int id)
        {
            var product = _context.Products.Find(id);

            if (product != null)
            {
                product.IsActive = !product.IsActive;
                _context.SaveChanges();
            }

            return RedirectToAction("Products");
        }


        public IActionResult Index()
        {
            var model = new AdminDashboardViewModel
            {
                Orders = new List<OrderViewModel>
                {
            new OrderViewModel
            {
                Id = 1,
                CustomerName = "Sümeyra Çaputcu",
                UrunAd="Atatürk Temalı Özel Tasarım Okey Takımı ",
                Adet=2,
                OrderDate = new DateTime(2026, 1, 27),
                TotalPrice = 5500,
                Status = "Hazırlanıyor"
            },
            new OrderViewModel
            {
                Id = 2,
                CustomerName = "Ülkü Yılmaz",
                UrunAd="Turan Özel Seri: Kurt Figürlü Özel Tasarım Okey Seti",
                Adet=1,
                OrderDate = new DateTime(2026, 4, 15),
                TotalPrice = 1500,
                Status = "Kargoda"
            },
              new OrderViewModel
            {
                Id = 2,
                CustomerName = "Hüseyin Dülger",
                UrunAd="Türkiye Temalı Özel Tasarım Okey Takımı",
                Adet=3,
                OrderDate = new DateTime(2026,3,29),
                TotalPrice = 9000,
                Status = "Teslim Edildi."
            },
                new OrderViewModel
            {
                Id = 2,
                CustomerName = "Simge Yedibela",
                UrunAd="İsim Yazılı Özel Tasarım Okey Seti",
                Adet=2,
                OrderDate = new DateTime(2026, 3,20),
                TotalPrice = 5500,
                Status = "Teslim Edildi."
            }

                },




                 Products = new List<ProductDetailViewModel>
                {
            new ProductDetailViewModel
            {
                UrunAdi ="Atatürk Temalı Özel Tasarım Okey Takımı",
                Fiyat = "2500",
                Stock = 3
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "İsim Yazılı Kişiye Özel Tasarım Okey Takımı",
                Fiyat = "2500",
                Stock = 7
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Turan Özel Seri: Kurt Figürlü Özel Tasarım Okey Seti",
                Fiyat = "2500",
                Stock = 3
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Pink Dream Serisi: Barbie Temalı Özel Tasarım Okey Takımı",
                Fiyat = "2500",
                Stock = 1
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Ötüken Serisi:Özel Tasarım Okey Takımı",
                Fiyat = "2500",
                Stock = 5
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Türkiye Temalı Özel Tasarım Okey Takımı",
                Fiyat = "2500",
                Stock=9
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Marvel Temalı Okey Takımı",
                Fiyat = "2500",
                Stock=7
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Sahil Temalı Okey Takımı",
                Fiyat = "2500",
                Stock=8
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Sünger Bob Temalı Okey Takımı",
                Fiyat = "2500",
                Stock=5
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Wednesday Okey Takımı",
                Fiyat = "2500",
                Stock=4
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Yılbaşı Özel Tasarım Okey Takımı",
                Fiyat = "2500",
                Stock=7
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "İsim Yazılı Özel Tasarım Okey Seti",
                Fiyat = "2500",
                Stock=5
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Şehir Temalı Okey Takımı(Denizli)",
                Fiyat = "2500",
                Stock=6
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Kişiye Özel Okey Takımı",
                Fiyat = "2500",
                Stock=4
            },
            new ProductDetailViewModel
            {
                 UrunAdi = "Şehir Temalı Okey Takımı(Van)",
                Fiyat = "2500",
                Stock=3
            },

                  }

            };



            return View(model);
        }
    }
}
