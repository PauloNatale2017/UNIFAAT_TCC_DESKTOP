using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Entities
{
    public class CadastroDeVitimas
    {
        [Key]
        public int Id { get; set; }
        public CadastroBasico CadastroBasico { get; set; }
        public CadastroDeOcorrencia CadastroDeOcorrencia { get; set; }
        public CadastroComplementar CadastroComplementar { get; set; }
        public List<CadastroFilho> CadastroFilhos { get; set; }
        public List<CadastroIdoso> CadastroIdosos { get; set; }
        public List<CadastroSOS> CadastroSOS { get; set; }
    }

    public class CadastroBasico {
        [Key]
        public int Id { get; set; }
        public string DadosPessoais { get; set; }
        public string Sexo { get; set; }
        public string Naturalidade { get; set; }
        public string RG { get; set; }
        public string OrgaoEmissor { get; set; }
        public string CPF { get; set; }
        public string Nacionalidade { get; set; }
        public string DatadeNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Escolaridade { get; set; }
        public string PortadordeNecs { get; set; }
        public string QualNesc { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Link { get; set; }
        public string OpcaoDoLink { get; set; }
    }

    public class CadastroDeOcorrencia
    {
        [Key]
        public int Id { get; set; }
        public string TipoViolencia { get; set; }
        public string DiaOcorrido { get; set; }
        public string LocalOcorrido { get; set; }
        public string Testemunha { get; set; }
        public string UsodeDrogasIlicitas { get; set; }
        public string UsodeDrograsLicitas { get; set; }
        public string VinculocomAgressor { get; set; }
        public string BOSIM { get; set; }
        public string BONAO { get; set; }
        public string NumeroBO { get; set; }
    }

    public class CadastroComplementar
    {
        [Key]
        public int Id { get; set; }
        public string Profissao { get; set; }
        public string RendaPessoal { get; set; }
        public string RendaFamiliar { get; set; }
        public string drogaslicitasSIM { get; set; }
        public string drogaslicitasNAO { get; set; }
        public string QualdrogaDescri1 { get; set; }
        public string DrogasilicitasSIM { get; set; }
        public string DrogasilicitasNAO { get; set; }
        public string QualdrogaDescri2 { get; set; }
        public string PossuifilhosSIM { get; set; }
        public string PossuiFilhosNAO { get; set; }
        public string Qtdo { get; set; }
        public string IdosoSIM { get; set; }
        public string IdosoNAO { get; set; }
        public string Quantidade { get; set; }
    }

    public class CadastroFilho
    {
        [Key]
        public int Id { get; set; }
        public string Nomefilho { get; set; }
        public string Escolaondeestuda { get; set; }
        public string DataNascimento { get; set; }
        public string Endereçoescola { get; set; }
        public string NecessidadesespeciaisSIM { get; set; }
        public string NecessidadesespeciaisNAO { get; set; }
        public string Qualnecessidade { get; set; }
    }

    public class CadastroIdoso
    {
        [Key]
        public int Id { get; set; }
        public string Nomoidoso { get; set; }
        public string DataNascimento { get; set; }
        public string NecessidadesEspeciaisSIM { get; set; }
        public string NecessidadesEspeciaisNAO { get; set; }
        public string Qual { get; set; }
    }

    public class CadastroSOS
    {
        [Key]
        public int Id { get; set; }
        public string NomeSOS { get; set; }
        public string NumeroCelular { get; set; }
        public string Vinculo { get; set; }
    }
    


}
