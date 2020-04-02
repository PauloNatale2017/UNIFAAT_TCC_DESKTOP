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
    public partial class Form2 : Form
    {

        private readonly CadastroDeVitimasRepository         _cadastrar =                  new CadastroDeVitimasRepository();
        private readonly CadastroBasicoRepository            _basico =                     new CadastroBasicoRepository();
        private readonly PreCadastroRepository               _precadastrar =               new PreCadastroRepository();
        private readonly ProfissionalVoluntarioRepository    _voluntariocadastrar =        new ProfissionalVoluntarioRepository();
        private readonly ProfissionalDescontoRepository      _voluntariodescontcadastrar = new ProfissionalDescontoRepository();
        private readonly PoliciaMilitarRepository            _policiacadastrar =           new PoliciaMilitarRepository();
        private readonly CadastroOngRepository               _ongcadastrar =               new CadastroOngRepository();

        private readonly CadastroFilhoRepository _filhocadastrar = new CadastroFilhoRepository();
        private readonly CadastroIdosoRepository _idosocadastrar = new CadastroIdosoRepository();
        private readonly CadastroSOSRepository _soscadastrar = new CadastroSOSRepository();
        private readonly CadastroDeOcorrenciaRepository _ocorrenciacadastrar = new CadastroDeOcorrenciaRepository();
        private readonly CadastroComplementarRepository _complementecadastrar = new CadastroComplementarRepository();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbMaterDayDataSet1.Cadastro'. Você pode movê-la ou removê-la conforme necessário.
            //this.cadastroTableAdapter.Fill(this.dbMaterDayDataSet1.Cadastro);

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            List<CadastroDeVitimas> rernoDados = _cadastrar.GetAll().ToList<CadastroDeVitimas>();
           
            List<CadastroComplementar> CadastroComplementar = _complementecadastrar.GetAll().ToList<CadastroComplementar>();
            List<CadastroBasico> CadastroBasico = _basico.GetAll().ToList<CadastroBasico>();
            List<CadastroFilho> CadastroFilhos = _filhocadastrar.GetAll().ToList<CadastroFilho>();
            List<CadastroIdoso> CadastroIdoso = _idosocadastrar.GetAll().ToList<CadastroIdoso>();
            List<CadastroDeOcorrencia> cadastrodeocorrencia = _ocorrenciacadastrar.GetAll().ToList<CadastroDeOcorrencia>();
            List<CadastroSOS> CadastroSOS = _soscadastrar.GetAll().ToList<CadastroSOS>();

            dataGridViewCompl.DataSource = "";
            dataGridViewCompl.DataSource = CadastroComplementar;
            dataGridViewCompl.Refresh();
            dataGridViewCompl.Update();

            dataGridViewSOS.DataSource = "";
            dataGridViewSOS.DataSource = CadastroSOS;
            dataGridViewSOS.Refresh();
            dataGridViewSOS.Update();

            dataGridViewFilhos.DataSource = "";
            dataGridViewFilhos.DataSource = CadastroFilhos;
            dataGridViewFilhos.Refresh();
            dataGridViewFilhos.Update();

            dataGridViewIdoso.DataSource = "";
            dataGridViewIdoso.DataSource = CadastroIdoso;
            dataGridViewIdoso.Refresh();
            dataGridViewIdoso.Update();

            dataGridViewBasic.DataSource = "";
            dataGridViewBasic.DataSource = CadastroBasico;
            dataGridViewBasic.Refresh();
            dataGridViewBasic.Update();

            dataGridViewocorrencias.DataSource = "";
            dataGridViewocorrencias.DataSource = cadastrodeocorrencia;
            dataGridViewocorrencias.Refresh();
            dataGridViewocorrencias.Update();

            dataGridViewCadVit.DataSource = "";
            dataGridViewCadVit.DataSource = rernoDados;
            dataGridViewCadVit.Refresh();
            dataGridViewCadVit.Update();

            //rernoDados.Add(new CadastroDeVitimas
            //{
            //    CadastroBasico = CadastroBasico[2],
            //    CadastroComplementar = CadastroComplementar[2],
            //    CadastroDeOcorrencia = cadastrodeocorrencia[2],
            //    CadastroFilhos = CadastroFilhos,
            //    CadastroIdosos = CadastroIdoso,
            //    CadastroSOSs = CadastroSOS
            //});


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            List<CadastroDeVitimas> rernoDados = _cadastrar.GetAll().ToList();
            //PesquisaColaboradoresGridview.DataSource = rernoDados;
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cadastroTableAdapter1.Fill(this.dbMaterDayDataSet.Cadastro);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



        private void BtnMaximizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void BtnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNomeCadastrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
