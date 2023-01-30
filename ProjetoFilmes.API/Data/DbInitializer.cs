using System.Diagnostics;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using ProjetoFilmes.LIB.Models;

namespace ProjetoFilmes.API.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _builder;

        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            _builder.Entity<Filme>().HasData(
                new Filme { FilmeID = 1, Titulo = "The Last of Us", DataLancamento = DateTime.Parse("2023-01-15"), Genero = Genero.Drama, Descricao = "After a global pandemic destroys civilization, a hardened survivor takes charge of a 14-year-old girl who may be humanity's last hope." },
                new Filme { FilmeID = 2, Titulo = "Game of Thrones", DataLancamento = DateTime.Parse("2011-04-17"), Genero = Genero.Drama, Descricao= "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia." },
                new Filme { FilmeID = 3, Titulo = "Avatar: The Way of Water", DataLancamento = DateTime.Parse("2022-12-15"), Genero = Genero.FicçãoCientífica, Descricao = "Jake Sully lives with his newfound family formed on the extrasolar moon Pandora." }
                );

            _builder.Entity<Ator>().HasData(
                new Ator { AtorID = 1, Nome = "Pedro Pascal", FilmeID = 1 },
                new Ator { AtorID = 2, Nome = "Emilia Clarke", FilmeID = 2 },
                new Ator { AtorID = 3, Nome = "Matt Smith", FilmeID = 3 }
                );

            _builder.Entity<Utilizador>().HasData(
                new Utilizador { UtilizadorID = 1, Nome = "Joao", UserName = "UserOne" },
                new Utilizador { UtilizadorID = 2, Nome = "Semedo", UserName = "UserTwo" }
                );

            _builder.Entity<Avaliacao>().HasData(
                 new Avaliacao { AvaliacaoID = 1, FilmeID = 1, UtilizadorID = 1, Rating = 4, Opiniao = "interessante" },
                new Avaliacao { AvaliacaoID = 2, FilmeID = 2, UtilizadorID = 1, Rating = 4, Opiniao = "bom" }
                );
        }
    }
}

