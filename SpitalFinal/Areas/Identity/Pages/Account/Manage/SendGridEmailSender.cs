using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace SpitalFinal.Areas.Identity.Pages.Account.Manage
{
    public class SendGridEmailSender : IEmailSender
    {
        private readonly string apiKey;

        public SendGridEmailSender(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("from@example.com", "Your Name"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));
            return client.SendEmailAsync(msg);
        }
    }
}