﻿using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
