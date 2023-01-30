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
        [Required(ErrorMessage = "Preencha o titulo")]
        [StringLength(80)]
        public string Titulo { get; set; } = null!;

        [Required(ErrorMessage = "Preencha a Data Lançamento")]
        [DataType(DataType.Date)]
        [Display(Name = "Data Lancamento")]
       
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Preencha Descricão")]
        [DataType(DataType.Text)]
        [MaxLength(250)]
        public string? Descricao { get; set; }

        public short AvaliacaoAvg { get; set; } = 0;
        [Required]
        [Range(1, 7, ErrorMessage = "Preencha Genero 1 - 7")]
        public Genero? Genero { get; set; }

        [ValidateNever]
        public ICollection<Ator>? Atores { get; set; }

        [ValidateNever]
        public ICollection<Diretor>? Diretores { get; set; }

        [ValidateNever]
        public ICollection<Avaliacao>? Avaliacoes { get; set; }
    }
}