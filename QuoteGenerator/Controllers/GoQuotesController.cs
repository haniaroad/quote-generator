using Microsoft.AspNetCore.Mvc;
using QuoteGenerator.Services.GoQuotes.Interfaces;

namespace QuoteGenerator.Controllers
{
    public class GoQuotesController : Controller
    {
        public IGoQuotesService _quoteService { get; set; }

        public GoQuotesController(IGoQuotesService quoteService)
        {
            _quoteService = quoteService;
        }
        public IActionResult Index()
        {
            var quote = _quoteService.GetSingleQuote().Result;

            ViewBag.Quote = quote;

            return View();
        }
    }
}
