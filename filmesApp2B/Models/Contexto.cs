using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmesApp2B.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Ator> Ator { get; set; }
        public DbSet<Filme> Filme { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=filmesapp;Username=postgres;Password=postgre");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ator>().HasData(new Ator { Id = 1, Nome = "Robert Downey Jr." });
        }
    }
}
