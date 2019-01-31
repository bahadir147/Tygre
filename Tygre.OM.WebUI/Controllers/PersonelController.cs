using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tygre.OM.Services.Abstract;

namespace Tygre.OM.WebUI.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IPersonelService _personelService;

        public PersonelController(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        public async Task<IActionResult> List()
        {
            var personeller = await _personelService.GetPersonelListesi();
            return View(personeller);
        }
    }
}