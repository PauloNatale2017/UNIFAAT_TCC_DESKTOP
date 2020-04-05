using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Entities
{
    public class Login 
    {
        [Key]
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
