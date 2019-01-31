using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Tygre.OM.Entities.DtoModels;
using Tygre.OM.Services.Abstract;

namespace Tygre.OM.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IPersonelService _personelService;

        public AccountController(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(DTOLogin loginModel, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var personel = await _personelService.Login(loginModel);

                if (personel != null)
                {
                    var claims = new List<Claim>
                    {
                         new Claim(ClaimTypes.Name, personel.PersonelId.ToString())
                    };

                    var userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);

                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError("CustomError", "Personel adi veya şifresi yanlış!");
                }


            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}