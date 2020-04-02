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
    public partial class Profissional : Form
    {
        private readonly ProfissionalVoluntarioRepository entityProfissional = new ProfissionalVoluntarioRepository();
        public Profissional()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<ProfissionalVoluntario> list = new List<ProfissionalVoluntario>();
            try
            {
                var ProfissionalVolunario = new ProfissionalVoluntario
                {
                    Nome = Nome.Text,
                    Bairro = Bairro.Text,
                    Cep = Cep.Text,
                    Cidade = txtCidade1.Text,
                    CNPJ = Cnpj.Text,
                    CPF = Cpf.Text,
                    DataCreate = DateTime.Now,
                    DataUpdate = DateTime.Now,
                    DatadeNascimento = DataNascimento.Text == "" ? DateTime.Now.ToString() : DataNascimento.Text,
                    DiaAtendimento = DiasDeAtendimento.Text,
                    Email = Email.Text,
                    Escolaridade = Escolaridade1.Text,
                    Estado = Estado.Text,
                    EstadoCivil = EstadoCivil.Text,
                    HorarioAtendimento = HoraDeAtendimento.Text,
                    Links = Link.Text,
                    Nascionalidade = Nacionalidade.Text,
                    Naturalidade = Naturalidade.Text,
                    NomeFantasia = NomeFantasia.Text,
                    Numero = Numero.Text,
                    OrgaoEmissor = OrgaoEmissor.Text,
                    Pais = Pais.Text,
                    PortadorNecessidadesEspeciais = PortadorDeficiencia.Text,
                    RamoAtuacao = "",
                    RazaoSocial = RazaoSocial.Text,
                    RG = RG.Text,
                    Rua = Logradouro.Text,
                    Sexo = Sexo.Text,
                    TelefoneCelular = CelularWhatsApp.Text,
                    TelefoneFixo = TelefoneFixo.Text
                };
                entityProfissional.Add(ProfissionalVolunario);
                list.Add(ProfissionalVolunario);
                MessageBox.Show("Dados salvos com sucesso", "SALVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro Inexperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = list;
                dataGridView1.Refresh();
                dataGridView1.Update();
            }

        }
    

        private void TxtBairro1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
