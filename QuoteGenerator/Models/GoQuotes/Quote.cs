using System.Collections.Generic;

namespace QuoteGenerator.Models.GoQuotes
{
    public class Quote
    {
        public Quote(int status, string message, int count, IEnumerable<QuoteDetails> quotes)
        {
            Status = status;
            Message = message;
            Count = count;
            Quotes = quotes;

        }
        public int Status { get; set; }

        public string Message { get; set; }

        public int Count { get; set; }

        public IEnumerable<QuoteDetails> Quotes { get; set; }
    }
}
