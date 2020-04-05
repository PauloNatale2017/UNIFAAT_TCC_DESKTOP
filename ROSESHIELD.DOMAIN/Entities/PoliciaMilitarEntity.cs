using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Entities
{
    public class PoliciaMilitarEntity : BaseEntity 
    {
        public string NomeDepartamento { get; set; }
        public string AbrangenciaDeAtuacao { get; set; }
        public string PontoFocalDeContato { get; set; }
       
    }
}
