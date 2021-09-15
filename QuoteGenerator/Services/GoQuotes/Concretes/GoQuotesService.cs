using Newtonsoft.Json;
using QuoteGenerator.Models.GoQuotes;
using QuoteGenerator.Services.GoQuotes.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuoteGenerator.Services.GoQuotes.Concretes
{
    public class GoQuotesService : IGoQuotesService
    {
        public async Task<Quote> GetSingleQuote()
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync(new Uri($"https://goquotes-api.herokuapp.com/api/v1/random?count=1")).Result;

                var response = result.Content.ReadAsStringAsync().Result;

                Quote quote = JsonConvert.DeserializeObject<Quote>(response);

                return quote;

            }
        }
    }
}
