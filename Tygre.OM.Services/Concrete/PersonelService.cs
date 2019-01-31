using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Tygre.Core.Enums;
using Tygre.OM.Entities.Concrete;
using Tygre.OM.Entities.DtoModels;
using Tygre.OM.Repositories.Absract;
using Tygre.OM.Services.Abstract;

namespace Tygre.OM.Services.Concrete
{
    public class PersonelService : IPersonelService
    {
        private readonly IPersonelRepository _personelRepository;
        private readonly IMapper _mapper;

        public PersonelService(IPersonelRepository personelRepository, IMapper mapper)
        {
            _personelRepository = personelRepository;
            _mapper = mapper;
        }

        public async Task<Personel> GetPersonelById(int personeId)
        {
            return await _personelRepository.Get(x => x.PersonelId == personeId);
        }

        public async Task<List<DTOPersonel>> GetPersonelListesi()
        {
            var personeller = await _personelRepository.GetList();
            var dtoPersoneller = _mapper.Map<List<DTOPersonel>>(personeller);
            return dtoPersoneller;
        }

        public async Task<Personel> Login(DTOLogin dTOLogin)
        {
            var personel = await _personelRepository.Get(x => x.Adi == dTOLogin.PersonelAdi && x.Sifre == dTOLogin.PersonelSifre && x.Status == StatusEnum.Active);
            if (personel == null) return null;
            personel.Sifre = "";

            return personel;
        }

    }
}
