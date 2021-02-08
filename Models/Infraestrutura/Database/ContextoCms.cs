using System;
using System.IO;
using admin_cms.Models.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace admin_cms.Models.Infraestrutura.Database
{
    public class ContextoCms : DbContext
   {
       //este construtor server para quando eu for passar os options lá na minha startup
      public ContextoCms(DbContextOptions<ContextoCms> options) : base (options)
      { }
      //Já este contrutor vazio serve
      public ContextoCms() { }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         JToken jAppSettings = JToken.Parse(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "appsettings.json")));
         optionsBuilder.UseSqlServer(jAppSettings["ConexaoSql"].ToString());
      }

      public DbSet<Administrador> Administradores { get; set; }
     }
   }
 

