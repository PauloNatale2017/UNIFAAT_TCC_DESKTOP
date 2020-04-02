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
    public partial class ProfissionalDesconto : Form
    {
        private readonly ProfissionalDescontoRepository entityDesconto = new ProfissionalDescontoRepository(); 
        public ProfissionalDesconto()
        {
            InitializeComponent();
        }

        private void ProfissionalDesconto_Load(object sender, EventArgs e)
        {


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<ROSESHIELD.DOMAIN.Entities.ProfissionalDesconto> list = new List<ROSESHIELD.DOMAIN.Entities.ProfissionalDesconto>();
            try
            {
                var ProfissionalVolunario = new ROSESHIELD.DOMAIN.Entities.ProfissionalDesconto
                {
                    Nome = txtNome1.Text,
                    Bairro = txtBairro1.Text,
                    Cep = txtCep.Text,
                    Cidade = txtCidade1.Text,
                    CNPJ = txtCnpj.Text,
                    CPF = txtCpf.Text,
                    DataCreate = DateTime.Now,
                    DataUpdate = DateTime.Now,
                    DatadeNascimento = DateTime.Now.ToLongDateString(),
                    DiaAtendimento = txtDiasDeAtendimento.Text,
                    Email = txtEmail1.Text,
                    Escolaridade = txtEscolaridade1.Text,
                    Estado = txtEstado.Text,
                    EstadoCivil = txtEstadoCivil.Text,
                    HorarioAtendimento = txtHoraDeAtendimento.Text,
                    Links = txtLink.Text,
                    Nascionalidade = txtNacionalidade.Text,
                    Naturalidade = txtNaturalidade.Text,
                    NomeFantasia = txtNomeFantasia.Text,
                    Numero = txtNumero.Text,
                    OrgaoEmissor = txtOrgaoEmissor.Text,
                    Pais = txtPais.Text,
                    PortadorNecessidadesEspeciais = txtPortadorDeficiencia.Text,
                    RamoAtuacao = "",
                    RazaoSocial = txtRazaoSocial.Text,
                    RG = txtRg.Text,
                    Rua = txtLogradouro.Text,
                    Sexo = txtSexo.Text,
                    TelefoneCelular = txtCelularWhatsApp.Text,
                    TelefoneFixo = txtTelefoneFixo.Text,
                    ValorCobrado = txtValorCobrado.Text,
                    Desconto = txtDesconto.Text
                };
                entityDesconto.Add(ProfissionalVolunario);
                list.Add(ProfissionalVolunario);
                MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inexperado", ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = list;
                dataGridView1.Refresh();
                dataGridView1.Update();
            }
          
        }

        private void TxtLink_TextChanged(object sender, EventArgs e)
        {

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
