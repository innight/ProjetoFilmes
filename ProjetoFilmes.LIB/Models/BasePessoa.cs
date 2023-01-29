using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFilmes.LIB.Models
{
    public class BasePessoa
    {
        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        [StringLength(80)]
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public Boolean Genero { get; set; }
    }
}
