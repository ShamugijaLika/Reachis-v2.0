﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reachis.Models;

namespace Reachis.Controllers
{
    public class LoginController : Controller
    {
        public ViewResult LogIn()
        {
            return View("LoginUI");
        }

        [HttpGet]
        public ViewResult Registration()
        {
            return View("RegistrationUI");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}