﻿using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}