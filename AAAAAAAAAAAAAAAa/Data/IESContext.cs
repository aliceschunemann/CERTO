using AAAAAAAAAAAAAAAa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Modelo.Cadastros;

namespace AAAAAAAAAAAAAAAa.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions<IESContext> options) : base(options)
        { }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Departamento>().ToTable("Departamento");
            modelBuilder.Entity<Instituicao>().ToTable("Instituicoes");
        }
    }
}
