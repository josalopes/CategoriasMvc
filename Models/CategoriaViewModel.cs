using System.ComponentModel.DataAnnotations;

namespace CategoriasMvc.Models
{
    public class CategoriaViewModel
    {
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "O nome da cateria é obrigatório")]
        public string? Nome { get; set; }
        
        [Display(Name = "Imagem")]
        public string? ImagemUrl { get; set; }
    }
}
