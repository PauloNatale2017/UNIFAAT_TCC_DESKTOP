using ROSESHIELD.DOMAIN.CORE.Repository;
using ROSESHIELD.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROSESHIELD_01
{
    public partial class PoliciaMilitar : Form
    {

        private readonly PoliciaMilitarRepository entityPoliciaMilitar = new PoliciaMilitarRepository();
        public PoliciaMilitar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            List<PoliciaMilitarEntity> list = new List<PoliciaMilitarEntity>();
            try
            {
                var PoliciaMilitar = new PoliciaMilitarEntity
                {
                    NomeDepartamento = txtNomeDp.Text,
                    AbrangenciaDeAtuacao = AbrangenciaDeAtuacao.Text,
                    PontoFocalDeContato = txtPontoFocalDeContato.Text,
                    Nome = txtNomeDp.Text,
                    Bairro = txtBairro1.Text,
                    Cep = txtCep.Text,
                    Cidade = txtCidade1.Text,
                    CNPJ = "",
                    CPF = "",
                    DataCreate = DateTime.Now,
                    DataUpdate = DateTime.Now,
                    DatadeNascimento = DateTime.Now.ToString(),
                    Email = "",
                    Escolaridade = "",
                    Estado = "",
                    EstadoCivil = "",
                    Links = txtLink.Text,
                    Nascionalidade = "",
                    Naturalidade = "",
                    NomeFantasia = "",
                    Numero = "",
                    OrgaoEmissor = "",
                    Pais = txtPais.Text,
                    PortadorNecessidadesEspeciais = "",
                    RazaoSocial = "",
                    RG = "",
                    Rua = txtRua.Text,
                    Sexo = "",
                    TelefoneCelular = txtTelefoneFixo.Text,
                    TelefoneFixo = ""
                };
                list.Add(PoliciaMilitar);
                entityPoliciaMilitar.Add(PoliciaMilitar);

                MessageBox.Show("Dados salvos com sucesso", "SALVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro Inexperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                PoliciaGridView.DataSource = "";
                PoliciaGridView.DataSource = list;
                PoliciaGridView.Refresh();
                PoliciaGridView.Update();

               
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
