using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ProjetoFilmes.LIB.Models
{
    public class Ator : BasePessoa
    {
        [Key]
        public int AtorID { get; set; }
        [ForeignKey("Filme")]
        public int FilmeID { get; set; }
        [ValidateNever]
        public Filme Filme { get; set; }
    }
}
