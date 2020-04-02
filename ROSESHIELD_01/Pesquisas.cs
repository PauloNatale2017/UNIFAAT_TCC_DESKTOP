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
    public partial class Pesquisas : Form
    {

        public readonly ProfissionalVoluntarioRepository _ProfissionalVoluntarioRepository = new ProfissionalVoluntarioRepository();
        public readonly ProfissionalDescontoRepository _ProfissionalDescontoRepository = new ProfissionalDescontoRepository();
        public readonly PoliciaMilitarRepository _PoliciaMilitarRepository = new PoliciaMilitarRepository();      
        public readonly CadastroDeVitimasRepository _CadastroDeVitimasRepository = new CadastroDeVitimasRepository();
        public readonly CadastroBasicoRepository _CadastroBasicoRepository = new CadastroBasicoRepository();
        public readonly CadastroOngRepository _CadastroOngRepository = new CadastroOngRepository();
        public readonly CadastroEmpresaParceiraRepository _CadastroEmpresaParceiraRepository = new CadastroEmpresaParceiraRepository();

        public Pesquisas()
        {
            InitializeComponent();
        }

        private void Pesquisas_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow gridRow in dataGridView1.Rows)
            {
                var classname = gridRow.DataBoundItem.GetType().Name;
                populaentidadegrid(gridRow, classname);
            }
            MessageBox.Show("Dados alterados com sucesso", "Ateração", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool populaentidadegrid(DataGridViewRow gridRow,string classNme)
        {
            var entity = gridRow.DataBoundItem;

            switch (classNme)
            {
                case "Ong":
                    _CadastroOngRepository.Update((Ong)entity);
                    break;
                case "ProfissionalVoluntario":
                    _ProfissionalVoluntarioRepository.Update((ProfissionalVoluntario)entity);
                    break;
                case "ProfissionalDesconto":
                     ROSESHIELD.DOMAIN.Entities.ProfissionalDesconto ent = (ROSESHIELD.DOMAIN.Entities.ProfissionalDesconto)entity;
                    _ProfissionalDescontoRepository.Update(ent);
                    break;
                case "PoliciaMilitarEntity":
                    ROSESHIELD.DOMAIN.Entities.PoliciaMilitarEntity policia = (ROSESHIELD.DOMAIN.Entities.PoliciaMilitarEntity)entity;
                    _PoliciaMilitarRepository.Update(policia);
                    break;
                case "CadastroBasico":
                    ROSESHIELD.DOMAIN.Entities.CadastroBasico cadastrobasico = (ROSESHIELD.DOMAIN.Entities.CadastroBasico)entity;
                    _CadastroBasicoRepository.Update(cadastrobasico);
                    break;
                case "EmpresaParceira":
                    ROSESHIELD.DOMAIN.Entities.EmpresaParceira empresaParceira = (ROSESHIELD.DOMAIN.Entities.EmpresaParceira)entity;
                    _CadastroEmpresaParceiraRepository.Update(empresaParceira);
                    break;



                default:
                    break;
            }
          

            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem.ToString())
            {
                case "PROFISSIONAL":
                    dataGridView1.DataSource = _ProfissionalVoluntarioRepository.GetAll().ToList();
                    dataGridView1.Refresh();
                    break;
                case "PROFISSIONAL DESCONTO":
                    dataGridView1.DataSource = _ProfissionalDescontoRepository.GetAll().ToList();
                    dataGridView1.Refresh();
                    break;
                case "POLICIA MILITAR":
                    dataGridView1.DataSource = _PoliciaMilitarRepository.GetAll().ToList();
                    dataGridView1.Refresh();
                    break;
                //case "VITIMA":
                //    dataGridView1.DataSource = _CadastroDeVitimasRepository.GetAll().ToList();
                //    dataGridView1.Refresh();
                //    break;
                case "COLABORADOR":
                    dataGridView1.DataSource = _CadastroBasicoRepository.GetAll().ToList();
                    dataGridView1.Refresh();
                    break;
                case "CADASTRO ONG":
                    dataGridView1.DataSource = _CadastroOngRepository.GetAll().ToList();
                    dataGridView1.Refresh();
                    break;
                case "EMPRESA PARCEIRA":
                    dataGridView1.DataSource = _CadastroEmpresaParceiraRepository.GetAll().ToList();
                    dataGridView1.Refresh();
                    break;

                default:
                    break;
            }
        }
    }
}
