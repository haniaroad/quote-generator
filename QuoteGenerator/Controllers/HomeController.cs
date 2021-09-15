using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuoteGenerator.Models;
using QuoteGenerator.Services.GoQuotes.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IGoQuotesService _quoteService { get; set; }


        public HomeController(ILogger<HomeController> logger, IGoQuotesService quoteService)
        {
            _logger = logger;
            _quoteService = quoteService;
        }

        public IActionResult Index()
        {
            var quote = _quoteService.GetSingleQuote().Result;

            ViewBag.Quote = quote.Quotes.First().Text;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
