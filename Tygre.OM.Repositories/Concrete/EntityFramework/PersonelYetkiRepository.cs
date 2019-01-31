using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tygre.Core.DataAccess.EntityFramework;
using Tygre.OM.Entities.Concrete;
using Tygre.OM.Entities.DtoModels;
using Tygre.OM.Repositories.Absract;

namespace Tygre.OM.Repositories.Concrete.EntityFramework
{
    public class PersonelYetkiRepository : EfEntityRepositoryBase<PersonelYetki, OMContext>, IPersonelYetkiRepository
    {

        public async Task<List<DTOPersonelYetkileri>> GetPersonelYetkileri(int personelId)
        {
            using (var context = new OMContext())
            {
                var yetkiler = await context.ViewPersonelYetkileri.FromSql($@"SELECT Y.* FROM PERSONELLER P
                                                        LEFT JOIN PERSONELYETKILERI PY ON PY.PERSONELID = P.PERSONELID
                                                        LEFT JOIN YETKILER Y ON Y.YETKIID = PY.YETKIID
                                                        WHERE P.PERSONELID={personelId.ToString()}").ToListAsync();

                return yetkiler;
            }

        }
    }
}
