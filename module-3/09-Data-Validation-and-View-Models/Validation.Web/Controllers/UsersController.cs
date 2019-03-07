using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation.Web.Models;


namespace Validation.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: User/Login
        // Return the empty login view
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        // POST: User/Login  
        // Validate the model and redirect to confirmation (if successful) or return the 
        // login view (if validation fails)
        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), model);
            }

            return RedirectToAction("LoginConfirmation", "Users");
        }

        // GET: User/Confirmation
        // Return the confirmation view
        [HttpGet]
        public IActionResult LoginConfirmation()
        {
            return View();
        }

        // GET: User/Register
        // Return the empty registration view
        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        // POST: User/Register
        // Validate the model and redirect to confirmation (if successful) or return the 
        // registration view (if validation fails)        
        [HttpPost]
        public IActionResult RegisterUser(RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(RegisterUser), model);
            }

            return RedirectToAction(nameof(RegistrationConfirmation), "Users");
        }

        [HttpGet]
        public IActionResult RegistrationConfirmation()
        {
            return View();
        }







    }
}