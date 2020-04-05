using ROSESHIELD.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.CORE.Repository
{
    public class CadastroOngRepository : Repository.BaseRepository<Ong>
    {
        public CadastroOngRepository()
            : base(new DATAACCESSLAYERS.dbContext.dbContext())
        {

        }
    }
}
