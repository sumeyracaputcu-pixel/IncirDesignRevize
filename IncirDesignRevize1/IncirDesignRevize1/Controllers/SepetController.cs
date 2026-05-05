using IncirDesignRevize1.DATA;
using IncirDesignRevize1.Models;
using Microsoft.AspNetCore.Mvc;

public class SepetController : Controller
{
    private readonly AppDbContext _context;

    public SepetController(AppDbContext context)
    {
        _context = context;
    }

    // 🛒 Sepeti göster
    public IActionResult Index()
    {
        var cart = HttpContext.Session.GetObject<List<SessionCartItem>>("cart");

        if (cart == null)
        {
            cart = new List<SessionCartItem>();
        }

        return View(cart);
    }

    // ➕ Sepete ekle
    public IActionResult Ekle(int productId, string name, decimal price)
    {
        var cart = HttpContext.Session.GetObject<List<SessionCartItem>>("cart");

        if (cart == null)
        {
            cart = new List<SessionCartItem>();
        }

        var item = cart.FirstOrDefault(x => x.ProductId == productId);

        if (item != null)
        {
            item.Quantity++;
        }
        else
        {
            cart.Add(new SessionCartItem
            {
                ProductId = productId,
                Name = name,
                Price = price,
                Quantity = 1
            });
        }

        HttpContext.Session.SetObject("cart", cart);

        return RedirectToAction("Index");
    }
    public IActionResult Arttir(int productId)
    {
        var cart = HttpContext.Session.GetObject<List<SessionCartItem>>("cart");

        var item = cart.FirstOrDefault(x => x.ProductId == productId);

        if (item != null)
        {
            item.Quantity++;
        }

        HttpContext.Session.SetObject("cart", cart);

        return RedirectToAction("Index");
    }

    public IActionResult Azalt(int productId)
    {
        var cart = HttpContext.Session.GetObject<List<SessionCartItem>>("cart");

        var item = cart.FirstOrDefault(x => x.ProductId == productId);

        if (item != null)
        {
            item.Quantity--;

            if (item.Quantity <= 0)
            {
                cart.Remove(item);
            }
        }

        HttpContext.Session.SetObject("cart", cart);

        return RedirectToAction("Index");
    }
}