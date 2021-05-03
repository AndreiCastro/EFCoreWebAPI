using EFCore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        //Aqui é onde o migration ira criar as tabelas, cada atributo a baixo representa uma tabela.
        //Add-Migration initial (criar a migration)
        //Remove-Migration      (remover a dita cuja)
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Heroi> Herois { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ANDREI\SQLEXPRESS; Initial Catalog=HeroApp; Integrated Security=SSPI;");
            //optionsBuilder.UseSqlServer(@"Server=meuServidor; Database=meuBanco; Trusted_Connection=True;;");
        }
    }
}
