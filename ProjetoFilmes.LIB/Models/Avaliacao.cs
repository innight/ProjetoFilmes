using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ProjetoFilmes.LIB.Models
{
    public class Avaliacao
    {
        [Key]
        public int AvaliacaoID { get; set; }
        public string Opiniao { get; set; }
        public byte Rating { get; set; }

        [ForeignKey("Filme")]
        public int FilmeID { get; set; }
        [ForeignKey("Utilizador")]
        public int UtilizadorID { get; set; }

        [ValidateNever]
        public Filme Filme { get; set; }
        [ValidateNever]
        public Utilizador Utilizador { get; set; }
    }
}
