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
    public partial class Form3 : Form
    {
        private readonly LoginRepository _login = new LoginRepository();

        public Form3()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Form3 form1 = new Form3();
            //form1.StartPosition = FormStartPosition.CenterScreen;
            //form1.AutoScaleBaseSize = new System.Drawing.Size(500, 800);
            //this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();

            //if(textBox1.Text != "" && txtSenha.Text != "") {
            //    var retornoUsuarios = _login.GetAll().Where(d => d.Usuario == textBox1.Text && d.Password == txtSenha.Text).SingleOrDefault();
            //    if (retornoUsuarios != null)
            //    {
            //        FormMenu menu = new FormMenu();
            //        menu.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario ou senha incorretos...", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Usuario ou senha não estão preenchidos...", "ERRO NO PREENCHIMENTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PreCadastro menu = new PreCadastro();
            menu.Show();

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

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
