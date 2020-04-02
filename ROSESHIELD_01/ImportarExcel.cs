using Microsoft.Office.Interop.Excel;
using ROSESHIELD.DOMAIN.CORE.Repository;
using ROSESHIELD.DOMAIN.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ROSESHIELD_01
{
    public partial class ImportarExcel : Form
    {

        private readonly ExcelImportadoBasicoRepository import = new ExcelImportadoBasicoRepository();
        public List<ExcelImportado> exportExcel { get; set; }
        public ImportarExcel()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();

            FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
            txtPath.Text = fileInfo.Name.ToString();
            string diretorio = fileInfo.DirectoryName;
            textBox1.Text = fileInfo.Extension.ToString();
            txttipo.Text = diretorio;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            CarregarDadosDoExcel(txttipo.Text + @"\" + txtPath.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void CarregarDadosDoExcel(string excel)
        {
            
            string ArquivoExcel = @""+excel;
            System.Data.DataTable tab = GetTableExcel(ArquivoExcel, "Planilha1");
            //exceldados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //exceldados.DataSource = tab;
        }

       
      
        public System.Data.DataTable GetTableExcel(string excel,string nomeExcel)
        {
          
            dynamic ClassDinamica = new ExpandoObject();
            System.Data.DataTable dt = new System.Data.DataTable();
            string ArquivoExcel = @"" + excel;
            List<ExcelImportado> list = new List<ExcelImportado>();
            ROSESHIELD.DOMAIN.Entities.ExcelImportado entity = new ExcelImportado();

            try
            {
                string extension = Path.GetExtension(ArquivoExcel);
                string connection = "";

                if (extension == ".xls") {
                    connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Soruce="+ ArquivoExcel + ";Extende Properties = 'EXCEL 8.0;HDR = YES;'";
                }else if (extension == ".xlsx"){
                    connection = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ArquivoExcel};Extended Properties='Excel 12.0 Macro;HDR=YES'";
                    //connection = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={ArquivoExcel};Extended Properties='HDR=yes;Format=xlsx'";
                }
                             
                OleDbConnection conn = new OleDbConnection(connection);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                System.Data.DataTable table = new System.Data.DataTable();
                DataSet ds = new DataSet();

                cmd.Connection = conn;
                conn.Open();
                System.Data.DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);             
                cmd.CommandText = "SELECT * FROM [" + "Planilha1$" + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(ds);


          
                ArrayList listArrey = new ArrayList();

                foreach (DataRow itdtrowem in ds.Tables[0].Rows) {
                    listArrey.Add(itdtrowem);
                    var neww = new ExcelImportado
                    {
                        a1 = itdtrowem.ItemArray[0].ToString(),
                        a2 = itdtrowem.ItemArray[1].ToString(),
                        a3 = itdtrowem.ItemArray[2].ToString(),
                        a4 = itdtrowem.ItemArray[3].ToString(),
                        a5 = itdtrowem.ItemArray[4].ToString(),
                        a6 = itdtrowem.ItemArray[5].ToString(),
                        a7 = itdtrowem.ItemArray[6].ToString(),
                        a8 = itdtrowem.ItemArray[7].ToString(),
                        a9 = itdtrowem.ItemArray[8].ToString(),
                        a10 = itdtrowem.ItemArray[9].ToString(),
                        a11 = itdtrowem.ItemArray[10].ToString(),
                        a12 = itdtrowem.ItemArray[11].ToString(),
                        a13 = itdtrowem.ItemArray[12].ToString(),
                        a14 = itdtrowem.ItemArray[13].ToString(),
                        a15 = itdtrowem.ItemArray[14].ToString(),
                        a16 = itdtrowem.ItemArray[15].ToString(),
                        a17 = itdtrowem.ItemArray[16].ToString(),
                        a18 = itdtrowem.ItemArray[17].ToString(),
                    };
                    list.Add(neww);
                }

                exportExcel = list;


                tableconverte.DataSource = list;
                tableconverte.Refresh();


                conn.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }


            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            int totalp = exportExcel.Count / 100;
            MessageBox.Show("DADOS A SEREM SALVAS EM BASE DE DADOS", "SALVAR DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (var item in exportExcel)
            {
                var retv = import.Get(d => d.a1 == item.a1).ToList();
                if(retv.Count > 1)
                {
                    import.Exclude(d => d.a1 == item.a1);
                    import.Add(item);
                    if (retv != null)
                    {
                        if (MessageBox.Show("DADOS JA ENCONTRADOS EM BASE DE DADOS DESEJA ATUALIZALOS", "SALVAR DADOS", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            import.Update(item);
                        }

                    }
                    count++;
                } else   {
                    import.Add(item);
                    count++;
                }

                if (progressBar1.Value <= 99) {
                    progressBar1.Value = progressBar1.Value + totalp;
                }
                label7.Text = "TOTAL DE DADOS SENDO INSERIDOS:" + count.ToString();


            }
          
        }
    }
}
