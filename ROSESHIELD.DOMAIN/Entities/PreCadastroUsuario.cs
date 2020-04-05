using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Entities
{
    public class PreCadastroUsuario
    {
        [Key]
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public int DDD { get; set; }
        public int Contato { get; set; }
        public string Email { get; set; }
    }
}
