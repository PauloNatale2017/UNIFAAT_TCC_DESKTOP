using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Entities
{
    public class ProfissionalDesconto : BaseEntity
    {
        public string RamoAtuacao { get; set; }
        public string DiaAtendimento { get; set; }
        public string HorarioAtendimento { get; set; }
        public string ValorCobrado { get; set; }
        public string Desconto{ get; set; }

    }
}
