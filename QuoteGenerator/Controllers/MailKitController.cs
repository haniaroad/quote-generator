using Microsoft.AspNetCore.Mvc;
using QuoteGenerator.Models.MailKit;
using QuoteGenerator.Services.MailKit.Interfaces;
using System;

namespace QuoteGenerator.Controllers
{
    public class MailKitController : Controller
    {
        public IMailKitService _mailKitService { get; set; }

        public MailKitController(IMailKitService mailKitService)
        {
            _mailKitService = mailKitService;
        }

        [HttpPost]
        public IActionResult SendSingleQuote(EmailDetails emailDetails)
        {
            try
            {
                _mailKitService.SendQuote(emailDetails);

                return RedirectToAction("Index", "Home");
            }

            catch(Exception ex)
            {
                return View("Error");
            }
        }
    }
}
