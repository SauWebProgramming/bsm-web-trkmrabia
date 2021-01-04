using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PatiShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PatiShop.Controllers
{
    public class RegisterController: Controller
    {
        private readonly AppDBContext _context;
        public RegisterController(AppDBContext context)
        {
          _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View("Register", new Register() { BirthDate = DateTime.Now });
        }


        [HttpPost]
        public IActionResult Register(Register model)
        {

            if (!model.TermsAccepted)
            {
                ModelState.AddModelError(nameof(model.TermsAccepted), "Kullanıcı koşullarını kabul etmelisiniz.");
            }
            if (ModelState.IsValid)
            {
                _context.Add(model);
                _context.SaveChanges();
                return View("Completed", model);
            }
            else
            {
                return View("Register", model);
            }

        }
    }
}
