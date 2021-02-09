﻿
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using admin_cms.Models;
using Microsoft.AspNetCore.Http;
using admin_cms.Models.Infraestrutura.Autenticacao;

namespace admin_cms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Logado]
        public IActionResult Index()
        {
            
            return View();
        }
        
        //neste momento vou remover o cookies
        public IActionResult Sair()
        {
            this.HttpContext.Response.Cookies.Delete("adm_cms");
            return Redirect("/login");
        }

        public IActionResult Privacy()
        {
           
         return View();   
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
