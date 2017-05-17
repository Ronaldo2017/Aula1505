using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula1505.Models
{
    public class Projeto
    {
        [Key]
        public int ProjetoID { get; set; }
        [Required,StringLength(20)]//required- identifica no banco q não pode ser nulo, stringlength-tamnho(caracteres)
        public string Nome { get; set; }
        [Display(Name ="Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}