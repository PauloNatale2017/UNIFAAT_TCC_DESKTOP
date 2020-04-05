using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Entities
{
    public class BaseEntity
    {   
         [Key]
         public int ID { get; set; }   
         public DateTime DataCreate { get; set; } 
         public DateTime DataUpdate { get; set; }
         public string Nome { get; set; }
         public string RG { get; set; }
         public string OrgaoEmissor { get; set; }
         public string CPF { get; set; }
         public string CNPJ { get; set; }
         public string Rua { get; set; }
         public string Bairro { get; set; }
         public string Numero { get; set; }
         public string Estado { get; set; }
         public string Cidade { get; set; }
         public string Pais { get; set; }
         public string Cep { get; set; }
         public string TelefoneFixo { get; set; }
         public string TelefoneCelular { get; set; }
         public string Email { get; set; }
         public string DatadeNascimento { get; set; }
         public string Sexo { get; set; }
         public string EstadoCivil { get; set; }        
         public string PortadorNecessidadesEspeciais { get; set; }
         public string Escolaridade { get; set; }
         public string Naturalidade { get; set; }
         public string Nascionalidade { get; set; }
         public string RazaoSocial { get; set; }
         public string NomeFantasia { get; set; }
         public string Links { get; set; }

    }
}
