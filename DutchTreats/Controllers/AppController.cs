using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchTreats.Data;
using DutchTreats.Services;
using DutchTreats.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreats.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IDutchRepository _repository;

        public AppController(IMailService mailService, IDutchRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
        }

        // INDEX

        public IActionResult Index()
        {
            return View();
        }

        // CONTACT

        // contact will be at the root of the site (=> more discoverable)
        // localhost/contact , not localhost/app/contact
        [HttpGet("contact")]
        public IActionResult Contact()
        {

            return View();
        }

        // data sending from the server to the user
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send the email
                _mailService.SendMessage("andreea@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Message Sent!";
                ModelState.Clear(); // clear the fields if the message was sent
            }
            //else
            //{
            //    // Show the error
            //}
            return View();
        }

 
        // ABOUT

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        // SHOP
        public IActionResult Shop()
        {
            return View();

            //var results = _repository.GetAllProducts();

            // we're passing the data to the view
            //return View(results);

            //var results = _ctx.Products
            //    .OrderBy(p => p.Category);

            // var results = from p in _context.Products
            //              orderby p.Category
            //              select p;
            // return View(results.ToList());

        }
    }
}
