using System.Diagnostics;
using IncirDesignRevize1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IncirDesignRevize1.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hakkýmýzda()
        {
            return View();
        }

        public IActionResult Alýþveriþ()
        {
            return View();
        }
        public IActionResult Ýletiþim()
        {
            return View();
        }


    }
}
