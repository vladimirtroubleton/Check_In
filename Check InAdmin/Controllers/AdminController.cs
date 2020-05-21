using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AuthDataLayer.Models;
using AuthDataLayer.Repositories;
using AuthDataLayer.Utils;
using AuthDataLayer.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Check_InAdmin.Controllers
{
    public class AdminController : Controller
    {
        private ILoginUtil loginUtil;
        private IUsersRepository usersRepository;

        public AdminController(ILoginUtil loginUtil, IUsersRepository usersRepository)
        {
            this.loginUtil = loginUtil;
            this.usersRepository = usersRepository;
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginModel)
        {

            UserModel userLoginDataValidation = await loginUtil.CheckAdminParam(loginModel);

            if (userLoginDataValidation != null && userLoginDataValidation.Login == "Admin")
            {
                await Authenticate(userLoginDataValidation);

                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            return View(loginModel);
        }


        [HttpGet]
        [Authorize(Roles ="admin")]
        public IActionResult InfoForAdmin()
        {
            return View();
        }



        private async Task Authenticate(UserModel user)
        {

            var claims = new List<Claim>
            {
                 new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, "admin")
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        [Authorize]
        public async Task<IActionResult> OutUserAtSystem()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }
    }
}