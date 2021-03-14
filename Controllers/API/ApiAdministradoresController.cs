using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using admin_cms.Models.Dominio.Entidades;
using admin_cms.Models.Infraestrutura.Database;
using admin_cms.Models.Infraestrutura.Autenticacao;

namespace admin_cms.Controllers.API
{
    
    public class ApiAdministradoresController : ControllerBase
    {
        private readonly ContextoCms _context;

        public ApiAdministradoresController(ContextoCms context)
        {
            _context = context;
        }
        
        
        // GET: Administradores
        [HttpGet]
        [Route("/api/administradores.json")]  
        public async Task<IActionResult> Index()
        {
            //este (StatusCode) seria a mesma coisa de retornar uma (View) => veja que ele retonara uma lista de adminstradores
            //Estamos usando (StatusCode) porque nesta API estou usando o (ControllerBase) e não Controller
            //A(ControllerBase) é a mesma coisa do projeto do serviço (BaseController)
            //LEMBRANDO QUE USAR O (StatusCode) É TOTALMENTE INSERGURO => ESTA SENDO USADO APENAS COMO EXEMPLO
            return StatusCode(200, await _context.Administradores.ToListAsync());
        }

       
    }
}
