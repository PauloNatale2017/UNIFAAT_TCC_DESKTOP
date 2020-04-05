using ROSESHIELD.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.CORE.Repository
{
    public class PoliciaMilitarRepository : Repository.BaseRepository<PoliciaMilitarEntity>
    {
        public PoliciaMilitarRepository()
            : base(new DATAACCESSLAYERS.dbContext.dbContext())
        {

        }
    }
}
