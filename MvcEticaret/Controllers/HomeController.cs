using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;
using System.Collections.Generic;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>();

            products.Add(new Product() { Title = "Altera FPGA Development Board", IsSale = true, OldPrice = 1.099M, StarCount = 4, ImageUrl = "/images/AlteraFPGADevelopmentBoard.jpg", Price = 999 });
            products.Add(new Product() { Title = "Artix 7 FPGA Development Board", IsSale = true, OldPrice = 1.678M, StarCount = 5, ImageUrl = "/images/Artix7FPGADevelopmentBoard.jpg", Price = 1.550m });
            products.Add(new Product() { Title = "Nexys A7-100T FPGA Development Board", IsSale = true, OldPrice = 265, StarCount = 3, ImageUrl = "/images/NexysA7-100T-FPGADevelopmentBoard.jpg", Price = 250 });
            products.Add(new Product() { Title = "PIC Development Board", IsSale = false, OldPrice = 10, StarCount = 3, ImageUrl = "/images/PICDevelopmentBoard.jpg", Price = 30 });
            products.Add(new Product() { Title = "Arduino Uno", IsSale = false, OldPrice = 30, StarCount = 4, ImageUrl = "/images/ArduinoUno.jpg", Price = 50 });
            products.Add(new Product() { Title = "Raspberry Pi 4", IsSale = false, OldPrice = 30, StarCount = 5, ImageUrl = "/images/RaspberryPi4.jpg", Price = 50 });
            products.Add(new Product() { Title = "DJI M30 Endüstriyel Drone", IsSale = true, OldPrice = 9.125M, StarCount = 4, ImageUrl = "/images/Drone.jpeg", Price = 8.799m });
            products.Add(new Product() { Title = "RC Tank", IsSale = true, OldPrice = 1.099M, StarCount = 5, ImageUrl = "/images/RcTank.jpg", Price = 899m });

            return View(products);
        }
    }
}
