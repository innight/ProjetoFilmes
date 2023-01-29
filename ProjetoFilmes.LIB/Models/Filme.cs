using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace ProjetoFilmes.LIB.Models
{

    public enum Genero
    {
        Ação, Comédia, Drama, Documentário, Suspense, Terror, Thriller, FicçãoCientífica
    }
    public class Filme
    {
        [Key]
        public int FilmeID { get; set; }
        [Required]
        [StringLength(80)]
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        //public string? Genre { get; set; }
        public short AvaliacaoAvg { get; set; } = 0;
        public Genero? Genero { get; set; }

        [ValidateNever]
        public ICollection<Ator> Atores { get; set; }

        [ValidateNever]
        public ICollection<Diretor> Diretores { get; set; }

        [ValidateNever]
        public ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}