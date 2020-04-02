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
    public partial class PreCadastro : Form
    {
        private readonly PreCadastroRepository _precadastrar = 
            new PreCadastroRepository();
        public PreCadastro()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var entity = new PreCadastroUsuario()
            { 
                Contato =  int.Parse(txtContato.Text),
                DDD = int.Parse(txtDDD.Text),
                Email = txtEmail.Text,
                NomeUsuario = txtNomeUsuario.Text,
                Senha = txtSenha.Text
                //DataCreate = DateTime.Now,
                //DataUpdate = DateTime.Now
            };
            _precadastrar.Add(entity);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
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
