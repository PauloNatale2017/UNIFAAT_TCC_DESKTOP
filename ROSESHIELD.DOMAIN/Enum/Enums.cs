using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD.DOMAIN.Enum
{
    public class Enums
    {



        public enum EnumDataAnnotations

        {

            [field: Description("Data de Cadastro")]
            DataCadastro,
            [field: Description("Data de Nascimento")]
            DatadeNascimento,
            [field: Description("Numero do Cadastro")]
            NumeroCadastrado,
            [field: Description("Grau de Escolaridade")]
            Escolaridade,
            [field: Description("Cidade")]
            Cidade,
            [field: Description("BO Gerado pela Ocorrencia")]
            BO,
            [field: Description("Municipio da Ocorrencia")]
            MP,
            [field: Description("Bairro")]
            Bairro,
            [field: Description("Estado Civil")]
            EstadoCivil,
            [field: Description("Total de filhos")]
            Filhos,
            [field: Description("Tipo de Violencia(Sofrida)")]
            TipodeViolencia,
            [field: Description("Vitima utilizava de Alcool/Drogas")]
            UsoDeAlcool_Drogas_Vitima,
            [field: Description("Agressor utilizava de Alcool/Drogas")]
            UsoDeAlcool_Drogas_Agressor,
            [field: Description("Grau de vinculo com o agressor")]
            VinculoComAgressor,
            [field: Description("Encaminhada por")]
            EncaminhadaPor,
            [field: Description("Situação Atual")]
            Situacao,
            [field: Description("Motivo do Abandono do BO")]
            Motivododesligamento,
            [field: Description("Data de Deligamento")]
            Desligamento,
            [field: Description("Observações")]
            Observacoes

        }



        public static string GetEnumDescription(Enum.Enums.EnumDataAnnotations value)
        {
            System.Reflection.FieldInfo fi = value.GetType().GetField(value.ToString());
            System.ComponentModel.DescriptionAttribute[] attributes = (System.ComponentModel.DescriptionAttribute[])fi.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
            return (attributes.Length > byte.MinValue) ? attributes[byte.MinValue].Description : value.ToString();
         }

        public class Dinamic
        {
            public string Tipo { get; set; }
            public string Nome { get; set; }
        }


        public static string[] ReflectionEarlyBinding()

        {

            Type T = Type.GetType("IOC.Domain.Entities.Cadastro");
            int i = 0;
            PropertyInfo[] properties = T.GetProperties();
            string[] rest = new string[properties.Length];
            List<dynamic> List = new List<dynamic>();

            foreach (PropertyInfo property in properties)
            {
                rest[i] = property.Name;
                 i++;
                if (property.PropertyType.Name.ToString() != "String[]" &&
                     property.PropertyType.Name.ToString() != "List`1")

                    List.Add(new Dinamic
                    {
                        Tipo = property.PropertyType.Name.ToString(),
                        Nome = property.Name.ToString()

                    });

            }



            ConstructorInfo[] constructors = T.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {

                string ret3 = constructor.ToString();

            }



            return rest;

        }













    }
}
