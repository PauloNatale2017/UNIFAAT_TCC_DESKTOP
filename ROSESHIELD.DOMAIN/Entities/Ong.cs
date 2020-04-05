using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Entities
{
    public class Ong : BaseEntity
    {
        public string perfil { get; set; }
        public string acessos { get; set; }
        public CadastroDeVitimas CadastroDeVitimas { get; set; }
    }
}
