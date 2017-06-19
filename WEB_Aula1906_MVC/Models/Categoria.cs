using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required (ErrorMessage ="*")]
        [StringLength(10,ErrorMessage ="Tamanho máximo 10 caracteres")]
        public string Nome { get; set; }

        [Display(Name ="Descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}
