using ROSESHIELD.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.CORE.Repository
{
    public class PreCadastroRepository : Repository.BaseRepository<PreCadastroUsuario>
    {
        public PreCadastroRepository()
            : base(new DATAACCESSLAYERS.dbContext.dbContext())
        {

        }
    }
}
