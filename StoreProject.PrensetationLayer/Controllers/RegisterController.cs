using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StoreProject.EntityLayer.Concrete;
using StoreProject.PrensetationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.PrensetationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            AppUser appUser = new AppUser
            {
                Email = model.Mail,
                UserName = model.Username,
                Name = model.Name,
                Surname = model.Surname
            };
            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.message = "Hatalı bir şeyler var";
                return View();
            }
        }
    }
}
