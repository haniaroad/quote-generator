namespace QuoteGenerator.Models.MailKit
{
    public class EmailDetails
    {
        public EmailDetails()
        {
        }

        public EmailDetails(string toName, string toEmail, string fromName, string quote)
        {
            ToName = toName;
            ToEmail = toEmail;
            FromName = fromName;
            Quote = quote;
        }
        public string ToName { get; set; }
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string FromName { get; set; }
        public string Quote { get; set; }
    }
}
