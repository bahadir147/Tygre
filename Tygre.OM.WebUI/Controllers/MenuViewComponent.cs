using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tygre.OM.Services.Abstract;

namespace Tygre.OM.WebUI.Controllers
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IPersonelYetkiService _personelYetkiService;

        public MenuViewComponent(IPersonelYetkiService personelYetkiService)
        {
            _personelYetkiService = personelYetkiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            try
            {
                var userId = User.Identity.Name;
                var yetkiler = await _personelYetkiService.GetPersonelYetkileri(Convert.ToInt32(userId));
                return View(yetkiler);
            }
            catch (Exception)
            {
                await HttpContext.SignOutAsync();
                return View(StatusCodes.Status500InternalServerError);
            }
        }
    }

}
