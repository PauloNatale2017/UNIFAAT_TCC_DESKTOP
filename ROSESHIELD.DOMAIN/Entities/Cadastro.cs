using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Entities
{
    public class Cadastro : BaseEntity
    {
        public string DataOcorrencia { get; set; }
        public string NumeroCadastrado { get; set; }
        public string BO { get; set; }
        public string MP { get; set; }
        public Filho Filhos { get; set; }
        public Violencia TipodeViolência { get; set; }
        public string UsoDeAlcool_Vitima { get; set; }
        public string UsoDeDroga_Vitima { get; set; }
        public string UsoDeAlcool_Agressor { get; set; }
        public string UsoDeDroga_Agressor { get; set; }
        public string VínculoComAgressor { get; set; }
        public string EncaminhadaPor { get; set; }
        //public string MP { get; set; }
        //public string Situacao { get; set; }
        //public string Motivododesligamento { get; set; }
        //public string Desligamento { get; set; }
        public string Observacoes { get; set; }
    }
}
