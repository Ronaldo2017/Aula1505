
using System.ComponentModel.DataAnnotations;

namespace Aula1206_MVC_2.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Required(ErrorMessage ="*")]
        public string Nome { get; set; }
        [Display(Name ="Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}