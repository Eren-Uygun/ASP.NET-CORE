using IdentityDemo.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private IPasswordHasher<AppUser> _passwordHasser;



        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IPasswordHasher<AppUser> passwordHasher)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _passwordHasser = passwordHasher;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {

            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");


        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            var model = new LoginVM { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser mailcheck = await _userManager.FindByEmailAsync(model.Email);
                if (mailcheck == null)
                {
                    if (!await _userManager.IsEmailConfirmedAsync(mailcheck))
                    {
                        // Email isn't confirmed.
                    }

                    if (!await _userManager.IsPhoneNumberConfirmedAsync(mailcheck))
                    {
                        // Phone Number isn't confirmed.
                    }
                }

                var task = await _userManager.CheckPasswordAsync(mailcheck, model.Password);
                if (task == false /*await _userManager.CheckPasswordAsync(loginResult, login.Password) == false*/)
                {
                    ModelState.AddModelError("message", "Invalid credentials");
                    
                }

                //AppUser signedUser = await _userManager.FindByEmailAsync(model.Email);

                var result = await _signInManager.PasswordSignInAsync(mailcheck,
                    model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return Redirect("/User/Home/HomePage");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt");
                    return View(model);
                }
            }
            ModelState.AddModelError("", "Invalid login attempt");
            return View(model);

        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {


                AppUser appUser = new AppUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    EmailConfirmed = true
                };



                var result = await _userManager.CreateAsync(appUser, model.Password);

                if (result.Succeeded)
                {
                    //await _signInManager.SignInAsync(appUser, false);
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);

                    }

                }
            }

            return View(model);
        }



        public async Task<IActionResult> Edit()
        {
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            RegisterEditVM model = new RegisterEditVM(appUser);
            return View(model);

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RegisterEditVM user)
        {
            try
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

                if (ModelState.IsValid)
                {
                    appUser.UserName = user.UserName;
                    appUser.Email = user.Email;





                    if (user.Password != null)
                    {
                        appUser.PasswordHash = _passwordHasser.HashPassword(appUser, user.Password);
                    }

                    IdentityResult result = await _userManager.UpdateAsync(appUser);
                    if (result.Succeeded)
                    {
                        await _signInManager.SignOutAsync();
                        return RedirectToAction("Login", "Account");
                    }
                }

                return View(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı mevcut");
                return View(user);
            }

        }



    }
}