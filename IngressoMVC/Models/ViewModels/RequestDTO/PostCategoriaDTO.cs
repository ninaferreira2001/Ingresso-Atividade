using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.RequestDTO
{
    public class PostCategoriaDTO
    {
        [Required, StringLength(50, MinimumLength = 1, ErrorMessage = "Campo Obrigatório")]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Bio { get; set; }
    }
}
