using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tygre.OM.Entities.DtoModels;
using Tygre.OM.Repositories.Absract;
using Tygre.OM.Services.Abstract;

namespace Tygre.OM.Services.Concrete
{
    public class PersonelYetkiService : IPersonelYetkiService
    {
        private readonly IPersonelYetkiRepository _personelYetkiRepository;

        public PersonelYetkiService(IPersonelYetkiRepository personelYetkiRepository)
        {
            _personelYetkiRepository = personelYetkiRepository;
        }

        public async Task<List<DTOPersonelYetkileri>> GetPersonelYetkileri(int personelId)
        {
            return await _personelYetkiRepository.GetPersonelYetkileri(personelId);
        }
    }
}
