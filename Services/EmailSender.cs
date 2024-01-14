using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace BookStoreMVCWeb.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromEmail = "bakhaipth@gmail.com";
            var frompassword = "Bakhai240202";
            MailMessage message = new();
            message.From = new MailAddress(fromEmail);
            message.To.Add(new MailAddress(email));
            message.Subject = subject;
            message.Body = htmlMessage;
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient()
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, frompassword),
                EnableSsl=true
            };
            smtpClient.Send(message);
        }
    }
}
