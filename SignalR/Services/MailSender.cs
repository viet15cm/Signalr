using Microsoft.AspNetCore.Identity.UI.Services;

namespace SignalR.Services
{
    public class MailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }
    }
}
