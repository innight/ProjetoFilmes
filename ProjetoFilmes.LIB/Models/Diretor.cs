using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFilmes.LIB.Models
{
    public class Diretor : BasePessoa
    {
        [Key]
        public int DiretorID { get; set; }

        [ForeignKey("Filme")]
        public int FilmeID { get; set; }
        public Filme Filme { get; set; }
    }
}
