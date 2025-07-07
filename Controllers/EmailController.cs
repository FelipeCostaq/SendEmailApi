using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Models;
using System.Net;
using System.Net.Mail;

namespace PortfolioApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class EmailController : ControllerBase
	{
		private readonly IConfiguration _config;

		public EmailController(IConfiguration config)
		{
			_config = config;
		}

		[HttpPost("send")]
		public async Task<IActionResult> SendEmail([FromBody] EmailRequest request)
		{
			try
			{
				var smtpClient = new SmtpClient(_config["Email:SmtpHost"])
				{
					Port = int.Parse(_config["Email:SmtpPort"]),
					Credentials = new NetworkCredential(
						_config["Email:User"],
						_config["Email:Password"]
					),
					EnableSsl = true,
				};

				var mailMessage = new MailMessage
				{
					From = new MailAddress(_config["Email:User"]),
					Subject = "Novo contato do portfólio",
					Body = $"Nome: {request.Name}\nEmail: {request.Email}\nMensagem:\n{request.Message}",
					IsBodyHtml = false,
				};

				mailMessage.To.Add(_config["Email:User"]);

				await smtpClient.SendMailAsync(mailMessage);

				return Ok(new
				{
					message = "E-mail enviado."
				});
			}
			catch (Exception ex)
			{
				return StatusCode(500, new
				{
					message = "Erro ao enviar e-mail.",
					error = ex.Message
				});
			}
		}
	}
}
