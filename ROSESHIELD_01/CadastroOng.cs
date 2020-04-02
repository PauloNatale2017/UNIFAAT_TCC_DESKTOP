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
    public partial class CadastroOng : Form
    {
        private readonly CadastroOngRepository entityCadastroOng = new CadastroOngRepository();
        
        public CadastroOng()
        {
            InitializeComponent();
        }

        private void Label37_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string[] Acesso = new string[13];
            string AcessosUsuario = "";

            #region Acessos a Aplicação
            Acesso[0] = ckbCadastroVitima.Checked == true ? "CadastroVitima" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[1] = ckbColaboradores.Checked == true ? "Colaboradores" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[2] = ckbBuscaUsuarios.Checked == true ? "BuscaUsuarios" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[3] = ckbEmpresaParceira.Checked == true ? "EmpresaParceira" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[4] = ckbProfissional.Checked == true ? "Profissional" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[5] = ckbProfissionalDesconto.Checked == true ? "ProfissionalDesconto" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[6] = ckbPoliciaMilitar.Checked == true ? "PoliciaMilitar" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[7] = ckbImportarExcel.Checked == true ? "ImportarExcel" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[8] = ckbAcessoTotal.Checked == true ? "AcessoTotal" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[9] = ckbAtualiza.Checked == true ? "Atualiza" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[10] = ckbDeleta.Checked == true ? "Deleta" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[11] = ckbEscrita.Checked == true ? "Escrita" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            Acesso[12] = ckbLeitura.Checked == true ? "Leitura" : "N";
            AcessosUsuario = AcessosUsuario + "," + Acesso[0];
            #endregion


            //foreach (Control item in this.Controls)
            //{
            //    var rtt = item;
            //    var rttt = rtt.Name;

            //    if (item is CheckBox)
            //    {
            //        var result = (CheckBox)item;
            //        string ret = result.Name;
            //        Acesso[index] = ret;
            //    }
            //}

            List<Ong> list = new List<Ong>();

            try
            {
                
                var cadastroOng = new Ong
                {
                    acessos = AcessosUsuario,
                    Nome = "",
                    Bairro = "",
                    Cep = "",
                    Cidade = txtCidade1.Text,
                    CNPJ = "",
                    CPF = "",
                    DataCreate = DateTime.Now,
                    DataUpdate = DateTime.Now,                   
                    Email = "",
                    Escolaridade = "",
                    Estado = "",
                    EstadoCivil = "",                   
                    Links = "",
                    Nascionalidade = "",
                    Naturalidade = "",
                    NomeFantasia = "",
                    Numero = "",
                    OrgaoEmissor = "",
                    Pais = "",
                    PortadorNecessidadesEspeciais = "",
                    RazaoSocial = "",
                    RG = "",
                    Rua = "",
                    Sexo = "",
                    TelefoneCelular ="",
                    TelefoneFixo = ""
                };
                list.Add(cadastroOng);

                entityCadastroOng.Add(cadastroOng);
                MessageBox.Show("Dados salvos com sucesso", "SALVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
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
