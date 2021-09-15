using QuoteGenerator.Models.GoQuotes;
using System.Threading.Tasks;

namespace QuoteGenerator.Services.GoQuotes.Interfaces
{
    public interface IGoQuotesService
    {
        public Task<Quote> GetSingleQuote();
    }
}
