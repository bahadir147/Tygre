using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tygre.Core.DataAccess;
using Tygre.OM.Entities.Concrete;
using Tygre.OM.Entities.DtoModels;

namespace Tygre.OM.Repositories.Absract
{
    public interface IPersonelYetkiRepository : IEntityRepository<PersonelYetki>
    {
        Task<List<DTOPersonelYetkileri>> GetPersonelYetkileri(int personelId);
    }
}
