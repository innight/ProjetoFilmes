﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ProjetoFilmes.LIB.Models
{
    public class Utilizador : BasePessoa
    {
        [Key]
        public int UtilizadorID { get; set; }
        [Required(ErrorMessage = " Espaço e Numeros não permitidos")]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [ValidateNever]
        public ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
