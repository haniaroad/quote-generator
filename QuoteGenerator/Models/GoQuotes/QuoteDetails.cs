namespace QuoteGenerator.Models.GoQuotes
{
    public class QuoteDetails
    {
        public QuoteDetails(string text, string author, string tag)
        {
            Text = text;
            Author = author;
            Tag = tag;
        }
        public string Text { get; set; }

        public string Author { get; set; }

        public string Tag { get; set; }
    }
}
