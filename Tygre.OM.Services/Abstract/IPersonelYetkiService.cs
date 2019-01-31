using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tygre.OM.Entities.DtoModels;

namespace Tygre.OM.Services.Abstract
{
    public interface IPersonelYetkiService
    {
        Task<List<DTOPersonelYetkileri>> GetPersonelYetkileri(int personelId);
    }
}
