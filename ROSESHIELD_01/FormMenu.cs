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
    public partial class FormMenu : Form
    {
        private Form _objForm;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            FormMenu form = new FormMenu();
            form.WindowState = FormWindowState.Maximized;
            _objForm = painelContainer.Controls.OfType<Forms>().FirstOrDefault();
            if (_objForm == null)
            {
                _objForm = new Forms();
                _objForm.TopLevel = false;
                _objForm.WindowState = FormWindowState.Maximized;                    
                painelContainer.Controls.Add(_objForm);
                painelContainer.Tag = _objForm;           
                painelContainer.Width = form.Size.Width;
                painelContainer.Height = form.Size.Height;
                _objForm.Show();
                _objForm.BringToFront();
            }
            else
            {
                if (_objForm.WindowState == FormWindowState.Minimized)
                    _objForm.WindowState = FormWindowState.Normal;
                _objForm.BringToFront();
            }
           
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CadastroVitimas>();
;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            IsMdiContainer = true;
        }

        private void PainelContainer_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<PoliciaMilitar>();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form4>();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CadastroOng>();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CadastroEmpresaParceira>();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<BuscaDeVitimas>();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Profissional>();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<ProfissionalDesconto>();
        }

        private void PanelCabecalho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<ImportarExcel>();
            
        }

        private void PanelCabecalho_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Pesquisas>();
        }
    }
}
