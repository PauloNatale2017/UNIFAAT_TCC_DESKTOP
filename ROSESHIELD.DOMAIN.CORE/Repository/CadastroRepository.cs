using ROSESHIELD.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.CORE.Repository
{
    public class CadastroRepository : Repository.BaseRepository<Cadastro>
    {
        public CadastroRepository()
            : base(new DATAACCESSLAYERS.dbContext.dbContext())
        {

        }
    }
}
