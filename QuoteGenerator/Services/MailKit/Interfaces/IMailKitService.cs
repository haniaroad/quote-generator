using QuoteGenerator.Models.GoQuotes;
using QuoteGenerator.Models.MailKit;

namespace QuoteGenerator.Services.MailKit.Interfaces
{
    public interface IMailKitService
    {
        public void SendQuote(EmailDetails emailDetails);
    }
}
