using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Entities
{
    public class Violencia
    {
        [Key]
        public int id { get; set; }
        public string descricao { get; set; }
    }
}
