using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Entities
{
   public class EmpresaParceira : BaseEntity
    {
        public string NomeVaga { get; set; }
        public string AreaAtuacao { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }
        public string FaixaSalarial { get; set; }
        public string HorarioTrabalho { get; set; }
    }
}
