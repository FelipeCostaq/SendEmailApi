using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.Models
{
    public class EmailRequest
    {
        [Required(ErrorMessage = "Nome � obrigat�rio")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Email � obrigat�rio")]
        [EmailAddress(ErrorMessage = "Email inv�lido")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Mensagem � obrigat�ria")]
        public string Message { get; set; } = "";
    }
}
