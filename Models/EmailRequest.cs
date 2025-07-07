using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Models
{
    public class EmailRequest
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Mensagem é obrigatória")]
        public string Message { get; set; } = "";
    }
}
