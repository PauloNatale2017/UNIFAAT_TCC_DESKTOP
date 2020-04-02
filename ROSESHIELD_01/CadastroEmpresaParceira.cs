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
    public partial class CadastroEmpresaParceira : Form
    {
        private readonly CadastroEmpresaParceiraRepository entityEmpresaParceira = new CadastroEmpresaParceiraRepository();
        public CadastroEmpresaParceira()
        {
            InitializeComponent();
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                List<EmpresaParceira> List = new List<EmpresaParceira>();
                List.Add(new EmpresaParceira
                {
                    AreaAtuacao = "",
                    Cargo = "",
                    DatadeNascimento = DateTime.Now.ToString(),
                    Descricao = "",
                    FaixaSalarial = "",
                    HorarioTrabalho = "",
                    NomeVaga = "",
                    Nome = "",
                    Bairro = txtBairro1.Text,
                    Cep = txtCep.Text,
                    Cidade = txtCidade1.Text,
                    CNPJ = txtCnpj.Text,
                    CPF = "",
                    DataCreate = DateTime.Now,
                    DataUpdate = DateTime.Now,
                    Email = "",
                    Escolaridade = "",
                    Estado = txtEstado.Text,
                    EstadoCivil = "",
                    Links = cbxLink.Text,
                    Nascionalidade = "",
                    Naturalidade = "",
                    NomeFantasia = txtNomeFantasia.Text,
                    Numero = "",
                    OrgaoEmissor = "",
                    Pais = txtPais.Text,
                    PortadorNecessidadesEspeciais = "",
                    RazaoSocial = txtRazaoSocial.Text,
                    RG = "",
                    Rua = txtRua.Text,
                    Sexo = "",
                    TelefoneCelular = txtCelularWhatsApp.Text,
                    TelefoneFixo = txtTelefoneFixo.Text
                });
                EmpresaParceira entituUnic = List[0];
                entityEmpresaParceira.Add(entituUnic);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = List;
                dataGridView1.Refresh();
                dataGridView1.Update();


                MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro Inexperado...", ex.Message.ToString(), MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                MessageBox.Show("");
            }
            finally
            {

            }
           
        }
    }
}
