using System.ComponentModel.DataAnnotations;

namespace Aula1406_MVC.Models
{
    public class Categoria
    {
        [Key, ScaffoldColumn(false)]//reforçar 
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(10, ErrorMessage = "Não pode exceder o tamanho de 10 caracteres!")]
        public string Nome { get; set; }

        [Display(Name = "Descrição"), DataType(DataType.MultilineText)]//modifica o nome e a caixa de texto fica maior
        public string Descricao { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}