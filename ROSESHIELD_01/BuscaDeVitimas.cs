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
    public partial class BuscaDeVitimas : Form
    {

        private readonly CadastroRepository _cadastrar = new CadastroRepository();
        private readonly CadastroDeVitimasRepository _CadastroVitimas = new CadastroDeVitimasRepository();
        private readonly CadastroBasicoRepository _entityRepository = new CadastroBasicoRepository();

        public List<CadastroFilho> ListCadastroFilho = new List<CadastroFilho>();
        public List<CadastroIdoso> ListCadastroIdoso = new List<CadastroIdoso>();
        public List<CadastroSOS> ListCadastroSOS = new List<CadastroSOS>();

        public BuscaDeVitimas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var retorno = _CadastroVitimas.GetAll().ToList<CadastroDeVitimas>();
            var dados = _entityRepository.GetAll().ToList<CadastroBasico>();
            List<CadastroBasico> basico = _entityRepository.GetAll().Where(d => d.DadosPessoais == textBox1.Text).ToList<CadastroBasico>();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = basico;
            dataGridView1.Refresh();


        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
