using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;
using System.Collections.Generic;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public IActionResult Index()
        {
            var products = GetProducts(); // Ürünleri almak için bir metot çağırılıyor
            return View(products);
        }

        private List<Product> GetProducts()
        {
            // Burada ürün listesini oluşturmanız gerekiyor
            // Örnek olarak, 8 adet ürün oluşturup döndürüyoruz
            var products = new List<Product>
            {
                new Product
                {
                    Title = "Fancy Product",
                    StartCount = "40.00",
                    OldPrice = "80.00",
                    Price = "40.00",
                    ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg",
                    IsSale = false
                },
                new Product
                {
                    Title = "Special Item",
                    StartCount = "20.00",
                    OldPrice = "20.00",
                    Price = "18.00",
                    ImageUrl = "https://dummyimage.com/450x300/dee2e6/6c757d.jpg",
                    IsSale = true
                },
                // Diğer ürünler...
            };

            return products;
        }
    }
    //public class HomeController : Controller
    //{
    //    private readonly ILogger<HomeController> _logger;

    //    public HomeController(ILogger<HomeController> logger)
    //    {
    //        _logger = logger;
    //    }

    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    public IActionResult Privacy()
    //    {
    //        return View();
    //    }

    //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }


}
