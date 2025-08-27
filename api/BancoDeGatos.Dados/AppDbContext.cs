using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BancoDeGatos.Dados.Models; 

namespace BancoDeGatos.Dados
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // define uma prop DbSet para a nossa classe  Gatos permitindo que o EF Core realize operações (CRUD) na tabela. 
        public DbSet<Gato> Gatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}