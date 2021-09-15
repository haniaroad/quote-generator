using MailKit.Net.Smtp;
using MimeKit;
using QuoteGenerator.Models.GoQuotes;
using QuoteGenerator.Models.MailKit;
using QuoteGenerator.Services.MailKit.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace QuoteGenerator.Services.MailKit.Concretes
{
    public class MailKitService : IMailKitService
    {
        public void SendQuote(EmailDetails emailDetails)
        {
            var message = new MimeMessage();
          

            message.From.Add(new MailboxAddress("Derien", "derienthedev@outlook.com"));
            message.To.Add(new MailboxAddress(emailDetails.ToName, emailDetails.ToEmail));
            message.Subject = $"{emailDetails.FromName} sent you a quote!";

            message.Body = new TextPart("plain")
            {
                Text = emailDetails.Quote
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.outlook.com", 587, false);
                client.Authenticate("derienthedev@outlook.com", "DEtroit313..");
                client.Send(message);
                client.Disconnect(true);

            }
        }
    }
}
