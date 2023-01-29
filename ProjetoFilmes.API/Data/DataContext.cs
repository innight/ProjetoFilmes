using Microsoft.EntityFrameworkCore;
using ProjetoFilmes.LIB.Models;

namespace ProjetoFilmes.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Ator> Atores { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Diretor> Diretores { get; set; }
        public DbSet<Filme> Filmes { get; set; } = default!;
        public DbSet<Utilizador> Utilizadores { get; set; }

        //SEEDING:

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed database with authors and books for demo
            new DbInitializer(modelBuilder).Seed();
        }


    }
}
