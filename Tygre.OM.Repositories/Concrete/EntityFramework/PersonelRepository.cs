using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tygre.Core.DataAccess.EntityFramework;
using Tygre.OM.Entities.Concrete;
using Tygre.OM.Repositories.Absract;

namespace Tygre.OM.Repositories.Concrete.EntityFramework
{
    public class PersonelRepository : EfEntityRepositoryBase<Personel, OMContext>, IPersonelRepository
    {
    }
}
