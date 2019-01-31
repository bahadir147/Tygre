using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tygre.OM.Entities.Concrete;
using Tygre.OM.Entities.DtoModels;

namespace Tygre.OM.Services.Abstract
{
    public interface IPersonelService
    {
        Task<Personel> Login(DTOLogin dTOLogin);
        Task<Personel> GetPersonelById(int personeId);
        Task<List<DTOPersonel>> GetPersonelListesi();
    }
}
