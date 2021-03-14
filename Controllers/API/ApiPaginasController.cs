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
    
    public class ApiPaginasController : ControllerBase
    {
        private readonly ContextoCms _context;

        public ApiPaginasController(ContextoCms context)
        {
            _context = context;
        }

        // GET: Paginas
        [HttpGet]
        [Route("/")]
        public IActionResult Root()
        {
            return StatusCode(200, new { Mensagem = "Bem vindo a API"});
        }

        // GET: Paginas
        [HttpGet]
        [Route("/api/paginas.json")]
        public async Task<IActionResult> Index()
        {
            return StatusCode(200, await _context.Paginas.ToListAsync());
        }

         [HttpPost]
         [Route("/api/paginas.json")]
         //o método Create é o cadastrar
        public async Task<IActionResult> Create([FromBody] Pagina pagina)
        {
            
                _context.Add(pagina);
                await _context.SaveChangesAsync();
                //Quando digo (StatusCode(201)), estou querendo dizer que foi criado
                return StatusCode(201);
            
        }      

         [HttpPut]
         [Route("/api/paginas/{id}.json")]
         //o método Create é o cadastrar
        public async Task<IActionResult> Update(int id, [FromBody] Pagina pagina)
        {
                //para garantir que o pagina.id do objeto é o id que eu passei
                pagina.Id = id;
                _context.Update(pagina);
                await _context.SaveChangesAsync();
                //Quando digo (StatusCode(201)), estou querendo dizer que foi criado
                return StatusCode(200);
            
        }      

         [HttpDelete]
         [Route("/api/paginas/{id}.json")]
         //o método Create é o cadastrar
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
               return StatusCode(400, new {Mensagem = "O Id é obrigátorio" });
            }
                var pagina = await _context.Paginas.FirstOrDefaultAsync(m => m.Id == id);
                if (pagina == null)
                {
                  return StatusCode(404, new {Mensagem = "A página não foi encontrada"});
                }
               
                _context.Paginas.Remove(pagina);
                await _context.SaveChangesAsync();
                //este 204 => sgnifica não tenho conteudo nenhum
                return StatusCode(204);
            
        }      

    }
}
