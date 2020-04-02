using ROSESHIELD.DOMAIN.CORE.Repository;
using ROSESHIELD.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROSESHIELD_01
{
    public partial class CadastroVitimas : Form
    {
        private readonly CadastroRepository _cadastrar = new CadastroRepository();
        private readonly CadastroDeVitimasRepository _CadastroVitimas = new CadastroDeVitimasRepository();

        public List<CadastroFilho> ListCadastroFilho = new List<CadastroFilho>();
        public List<CadastroIdoso> ListCadastroIdoso = new List<CadastroIdoso>();
        public List<CadastroSOS> ListCadastroSOS = new List<CadastroSOS>();


        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RSTJJSUH;Initial Catalog=dbMaterDay;Integrated Security=True;Connect Timeout=200");
        public CadastroVitimas()
        {         
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var Assembly = typeof(CadastroBasico).Assembly;
            var entity = new Cadastro() {
                //Bairro = txtBairro.Text,
                //Cidade = txtCidade.Text,
                ////NomeCompleto = "";//txtNome.Text,
                //DatadeNascimento = txtNasciemnto.Text,
                //EstadoCivil = txtEstadoCivil.Text,
                ////Filhos = txtQtdeFilhos.Text,
                //Escolaridade = txtEscolaridade.Text,
                DataCreate = DateTime.Now,
                DataUpdate = DateTime.Now
            };
            //_cadastrar.Add(entity);
            //MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //List<Cadastro> retornos = _cadastrar.GetAll().ToList();
            //dataGridView1.DataSource = retornos;    
        }

        private void CadastroVitimas_Load(object sender, EventArgs e)
        {
            //progressBar1.Value = 5;
            //progressBar2.Value = 5;
            //progressBar3.Value = 5;
            //progressBar4.Value = 5;
            //progressBar5.Value = 5;

            CarregaGrid();
            //this.cadastroTableAdapter.Fill(this.dbMaterDayDataSet.Cadastro);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sasasasasasasas");
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Label44_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "DADOS_FILHOS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {

          


            //    var Assembly = typeof(CadastroBasico).Assembly;
            //Type humanoType = typeof(CadastroBasico);

            //PropertyInfo[] properties = humanoType.GetProperties();
            //string[] arrayClass = new string[properties.Length];
            //int count = 0;

            //foreach (var propertyInfo in properties)
            //{
            //    arrayClass[count] = propertyInfo.Name;
            //    count++;
         
            //}


            //Type t = typeof(CadastroBasico);          
            //PropertyInfo[] props = t.GetProperties();

            //foreach (var prop in props)
            //    if (prop.GetIndexParameters().Length == 0) { 
                
            //        var a    = prop.Name;
            //        var s    = prop.PropertyType.Name;
            //        var d    = prop.GetValue(t.GetType());
            //    }
            //    else {

            //        Console.WriteLine("   {0} ({1}): <Indexed>", prop.Name,
            //                          prop.PropertyType.Name);
            //    }



            try
            {
                string violencias = "";
                if (chkF.Checked == true) {
                    violencias = violencias + "FISICA";
                }
                if (chkM.Checked == true) {
                    violencias = violencias + "MORAL";
                }
                if (chkP.Checked == true) {
                    violencias = violencias + "PSICOLOGICA";
                } 
                if(chkPT.Checked == true) {
                    violencias = violencias + "PATRIMONIAL";
                }
                if (chkS.Checked == true) {
                    violencias = violencias + "SEXUAL";
                }

                _CadastroVitimas.Add(new CadastroDeVitimas
                {
                    CadastroBasico = new CadastroBasico
                    {
                      
                        DadosPessoais = Nome.Text,
                        Sexo = Sexo.Text,
                        Naturalidade = Naturalidade.Text,
                        RG = RG.Text,
                        OrgaoEmissor = OrgaoEmissor.Text,
                        CPF = Cpf.Text,
                        Nacionalidade = Nacionalidade.Text,
                        DatadeNascimento = DataNascimento.Text,
                        EstadoCivil = EstadoCivil.Text,
                        Escolaridade = Escolaridade1.Text,
                        PortadordeNecs = Portador.Text,
                        QualNesc = PortadorDeficiencia.Text,
                        Logradouro = Logradouro.Text,
                        Bairro = Bairro.Text,
                        Cidade = txtCidade1.Text,
                        Pais = Pais.Text,
                        Cep = Cep.Text,
                        Estado = Estado.Text,
                        Numero = Numero.Text,
                        TelefoneFixo = TelefoneFixo.Text,
                        Celular = CelularWhatsApp.Text,
                        Email = Email.Text,
                        Link = Link.Text,
                        OpcaoDoLink = TipoLink.Text,
                    },
                    CadastroComplementar = new CadastroComplementar
                    {
                        Profissao = txtProfissao.Text,
                        RendaPessoal = txtRendaPessoal.Text,
                        RendaFamiliar = txtRendaFamiliar.Text,
                        drogaslicitasSIM = chkSimLicitasVitima.Text,
                        drogaslicitasNAO = chkNaoLicitasVitima.Text,
                        QualdrogaDescri1 = txtLicitas.Text,
                        DrogasilicitasNAO = chkSimIlicitaVitima.Text,
                        DrogasilicitasSIM = txtIIicita.Text,
                        QualdrogaDescri2 = txtIlicitaVitima.Text,
                        PossuifilhosSIM = chkSimFilhosVitima.Text,
                        PossuiFilhosNAO = chkNaoFilhosVitima.Text,
                        Qtdo = txtQtdFilhos.Text,
                        IdosoSIM = chkSimIdosoVitima.Text,
                        IdosoNAO = chkNaoIdosoVitima.Text,
                        Quantidade = txtQtdoIdosoVitima.Text,
                    },
                    CadastroDeOcorrencia = new CadastroDeOcorrencia
                    {
                        TipoViolencia = violencias,
                        DiaOcorrido = mskDiaOcorrido.Text,
                        LocalOcorrido = txtLocalOcorrido.Text,
                        Testemunha = txtTestemunha.Text,
                        UsodeDrogasIlicitas = txtIlicitaVitima.Text,
                        UsodeDrograsLicitas = txtLicitasVitima.Text,
                        VinculocomAgressor = txtVinculoAgressor.Text,
                        BOSIM = chkSimBO.Text,
                        BONAO = chkNaoBO.Text,
                        NumeroBO = txtBO.Text,
                    },
                    CadastroFilhos = ListCadastroFilho,
                    CadastroIdosos = ListCadastroIdoso,
                    CadastroSOS = ListCadastroSOS
                });

                #region CLEAN

                Nome.Text = "";
                Sexo.Text = "";
                Naturalidade.Text = "";
                RG.Text = "";
                OrgaoEmissor.Text = "";
                Cpf.Text = "";
                Nacionalidade.Text = "";
                DataNascimento.Text = "";
                EstadoCivil.Text = "";
                Escolaridade1.Text = "";
                Portador.Text = "";
                PortadorDeficiencia.Text = "";
                Logradouro.Text = "";
                Bairro.Text = "";
                txtCidade1.Text = "";
                Pais.Text = "";
                Cep.Text = "";
                Estado.Text = "";
                Numero.Text = "";
                TelefoneFixo.Text = "";
                CelularWhatsApp.Text = "";
                Email.Text = "";
                Link.Text = "";
                TipoLink.Text = "";

                txtProfissao.Text = "";
                txtRendaPessoal.Text = "";
                txtRendaFamiliar.Text = "";
                chkSimLicitasVitima.Text = "";
                chkNaoLicitasVitima.Text = "";
                txtLicitas.Text = "";
                chkSimIlicitaVitima.Text = "";
                txtIIicita.Text = "";
                txtIlicitaVitima.Text = "";
                chkSimFilhosVitima.Text = "";
                chkNaoFilhosVitima.Text = "";
                txtQtdFilhos.Text = "";
                chkSimIdosoVitima.Text = "";
                chkNaoIdosoVitima.Text = "";
                txtQtdoIdosoVitima.Text = "";
                
                mskDiaOcorrido.Text = "";
                txtLocalOcorrido.Text = "";
                txtTestemunha.Text = "";
                txtIlicitaVitima.Text = "";
                txtLicitasVitima.Text = "";
                txtVinculoAgressor.Text = "";
                chkSimBO.Text = "";
                chkNaoBO.Text = "";
                txtBO.Text = "";

                chkF.Checked = false;
                chkM.Checked = false;
                chkP.Checked = false;
                chkPT.Checked = false;
                chkS.Checked = false;

                #endregion

                MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {                  
            ListCadastroFilho.Add(new CadastroFilho
            {
                Nomefilho = txtNomeFilho.Text,
                Escolaondeestuda = txtNomeEscola.Text,
                DataNascimento = mskDataNascimentoFilho.Text,
                Endereçoescola = txtEnderecoEscola.Text,
                NecessidadesespeciaisSIM = chkSimFilho.Text,
                NecessidadesespeciaisNAO = chkNaoFilho.Text,
                Qualnecessidade = txtNecessidadeFilho.Text,
            });
            dataGridViewFilhos.DataSource = "";
            dataGridViewFilhos.DataSource = ListCadastroFilho;
            dataGridViewFilhos.Refresh();
            dataGridViewFilhos.Update();

            GridFilhos.DataSource = "";
            GridFilhos.DataSource = ListCadastroFilho;
            GridFilhos.Refresh();
            GridFilhos.Update();

            

            #region CLEAN

            txtNomeFilho.Text = "";
            txtNomeEscola.Text = "";
            mskDataNascimentoFilho.Text = "";
            txtEnderecoEscola.Text = "";
            chkSimFilho.Text = "";
            chkNaoFilho.Text = "";
            txtNecessidadeFilho.Text = "";

            chkSimFilho.Checked = false;
            chkNaoFilho.Checked = false;

            #endregion
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ListCadastroIdoso.Add(new CadastroIdoso
            {
                Nomoidoso = txtNomeIdoso1.Text,
                DataNascimento = mskDataNascimentoIdoso.Text,
                NecessidadesEspeciaisSIM = chkSimIdoso.Text,
                NecessidadesEspeciaisNAO = chkNaoIdoso.Text,
                Qual = txtNecessidadeIdoso.Text,
            });
            dataGridViewIdoso.DataSource = "";
            dataGridViewIdoso.DataSource = ListCadastroIdoso;
            dataGridViewIdoso.Refresh();
            dataGridViewIdoso.Update();

            GridIdosos.DataSource = "";
            GridIdosos.DataSource = ListCadastroIdoso;
            GridIdosos.Refresh();
            GridIdosos.Update();

            

            #region CLEAN

            txtNomeIdoso1.Text = "";
            mskDataNascimentoIdoso.Text = "";
            chkSimIdoso.Text = "";
            chkNaoIdoso.Text = "";
            txtNecessidadeIdoso.Text = "";

            chkSimIdoso.Checked = false;
            chkNaoIdoso.Checked = false;

            #endregion
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ListCadastroSOS.Add(new CadastroSOS
            {
                NomeSOS = txtNomeSOS.Text,
                NumeroCelular = mskCelularSOS.Text,
                Vinculo = txtVinculoSOS.Text,
            });
            dataGridViewSOS.DataSource = "";
            dataGridViewSOS.DataSource = ListCadastroSOS;
            dataGridViewSOS.Refresh();
            dataGridViewSOS.Update();

            GridSOS.DataSource = "";
            GridSOS.DataSource = ListCadastroSOS;
            GridSOS.Refresh();
            GridSOS.Update();

            

            #region CLEAN

            txtNomeSOS.Text = "";
            mskCelularSOS.Text = "";
            txtVinculoSOS.Text = "";
            #endregion
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

        private void progressBar2_Click(object sender, EventArgs e)
        {
            progressBarENDERECO.Value = 50;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            var Assembly = typeof(CadastroBasico).Assembly;
            progressBarDADOSPESSOAIS.Value = 50;
        }

        public void CarregaGrid()
        {
            string violencias = "";
            if (chkF.Checked == true)
            {
                violencias = violencias + "FISICA";
            }
            if (chkM.Checked == true)
            {
                violencias = violencias + "MORAL";
            }
            if (chkP.Checked == true)
            {
                violencias = violencias + "PSICOLOGICA";
            }
            if (chkPT.Checked == true)
            {
                violencias = violencias + "PATRIMONIAL";
            }
            if (chkS.Checked == true)
            {
                violencias = violencias + "SEXUAL";
            }
            var CadastroDeOcorrencia = new List<CadastroDeOcorrencia>();
            CadastroDeOcorrencia.Add(new ROSESHIELD.DOMAIN.Entities.CadastroDeOcorrencia
            {
                TipoViolencia = violencias,
                DiaOcorrido = mskDiaOcorrido.Text,
                LocalOcorrido = txtLocalOcorrido.Text,
                Testemunha = txtTestemunha.Text,
                UsodeDrogasIlicitas = txtIlicitaVitima.Text,
                UsodeDrograsLicitas = txtLicitasVitima.Text,
                VinculocomAgressor = txtVinculoAgressor.Text,
                BOSIM = chkSimBO.Text,
                BONAO = chkNaoBO.Text,
                NumeroBO = txtBO.Text,
            });
            //GridOcorrencias.DataSource = CadastroDeOcorrencia;
            //GridOcorrencias.Refresh();

            var CadastroComplementar = new List<CadastroComplementar>();
            CadastroComplementar.Add(new ROSESHIELD.DOMAIN.Entities.CadastroComplementar());
            //GridComplementar.DataSource = CadastroComplementar;
            //GridComplementar.Refresh();

            var Filhos = new List<CadastroFilho>();
            Filhos.Add(new ROSESHIELD.DOMAIN.Entities.CadastroFilho());
            GridFilhos.DataSource = Filhos;
            GridFilhos.Refresh();

            var Idosos = new List<CadastroIdoso>();
            Idosos.Add(new ROSESHIELD.DOMAIN.Entities.CadastroIdoso());
            GridIdosos.DataSource = Idosos;
            GridIdosos.Refresh();

            var SOS = new List<CadastroSOS>();
            SOS.Add(new ROSESHIELD.DOMAIN.Entities.CadastroSOS());
            GridSOS.DataSource = SOS;
            GridSOS.Refresh();

        }

        private void GridOcorrencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        public int valid { get; set; }
        private void txtTestemunha_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

     

        private void txtVinculoAgressor_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void mskDiaOcorrido_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var type = sender.GetType().Name;
            MaskedTextBox t = (MaskedTextBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtLocalOcorrido_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtIIicita_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtLicitas_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkSimBO_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }


        private Control FindControlByName(Control pai, string name)
        {
            foreach (Control c in pai.Controls)
            {
                if (c.Name == name)
                      return c; //found

                // se o o controle tiver filhos, chama recursivamente a função

                if (c.Controls.Count > 0) {
                    Control retorno = FindControlByName(c, name);
                    // o retorno não é null, então acabou! é tetra!
                    if (retorno != null)
                        return retorno;
                }

            }

            return null; //not found

        }

        public int countPessoas { get; set; }
        public int countEndereco { get; set; }
        public int countContato { get; set; }
        public int countOcorrencia { get; set; }
        public int countComplemento { get; set; }
        public int countIdoso { get; set; }
        public int countFilhos{ get; set; }
        public int countSOS { get; set; }

        

        public void ChargeProgressBar1(string type = "",string name= "",string property = "",string grupo = "")
        {
            
            switch (grupo)
            {
             
               case "DADOS_PESSOAIS":
                   if (!string.IsNullOrEmpty(name) && name != ""){
                                if (countPessoas == 99) { } 
                               else {
                                   progressBarDADOSPESSOAIS.Value = progressBarDADOSPESSOAIS.Value + 1;
                                   countPessoas++;
                                   labeldadospessoais.Text = "" + countPessoas.ToString() + "%";
                               }
                                                             
                            }
                   break;

               case "DADOS_ENDERECO":
                   if (!string.IsNullOrEmpty(name) && name != "")
                            {
                                if(countEndereco == 99) { } else
                                {
                                    progressBarENDERECO.Value = progressBarENDERECO.Value + 1;
                                    countEndereco++;
                                    labelendereco.Text = "" + countEndereco.ToString() + "%";
                                }
                               
                            }
                   break;
               case "DADOS_CONTATO":
                   if (!string.IsNullOrEmpty(name) && name != "")
                            {
                                if (countContato == 99) { } 
                                else
                                {
                                    progressBarCONTATOS.Value = progressBarCONTATOS.Value + 1;
                                    countContato++;
                                    labelcontato.Text = "" + countContato.ToString() + "%";
                                }
                               
                            }
                   break;

                case "CONTROLE_COMPLEM":
                    if (!string.IsNullOrEmpty(name) && name != "")
                    {
                        if (countOcorrencia == 99) { }
                        else {
                            progressBarOcorrencia.Value = progressBarOcorrencia.Value + 1;
                            countOcorrencia++;
                            labelocorrencia.Text = "" + countOcorrencia.ToString() + "%";

                        }

                    }
                    break;

                case "TabPage2":
                    if (!string.IsNullOrEmpty(name) && name != "")
                    {
                        if (countComplemento == 99) { }
                        else{
                            progressBarComple.Value = progressBarComple.Value + 1;
                            countComplemento++;
                            labelcomplemento.Text = "" + countComplemento.ToString() + "%";
                        }

                    }
                    break;

                case "DADOS_FILHOS":
                    if (!string.IsNullOrEmpty(name) && name != "")
                    {
                        if (countFilhos == 99) { }
                        else {
                            progressBarFilhos.Value = progressBarFilhos.Value + 1;
                            countFilhos++;
                            labelfilhos.Text = "" + countFilhos.ToString() + "%";
                        }

                    }
                    break;

                case "DADOS_IDOSO":
                    if (!string.IsNullOrEmpty(name) && name != "")
                    {
                        if (countIdoso == 99) { }
                        else {
                            progressBarIDOSO.Value = progressBarIDOSO.Value + 1;
                            countIdoso++;
                            labelidoso.Text = "" + countIdoso.ToString() + "%";
                        }

                    }
                    break;


                case "DADOS_SOS":
                    if (!string.IsNullOrEmpty(name) && name != "")
                    {
                        if (countSOS == 99) { }
                        else {
                            progressBarSOS.Value = progressBarSOS.Value + 1;
                            countSOS++;
                            labelsos.Text = "" + countSOS.ToString() + "%";
                        }

                    }
                    break;

                    


                default:
                    break;
            }

            ProgressBarFull();
            // GroupBox camposGroupbox = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(d=>d.FieldType == typeof(GroupBox));

            //var campoTextbox = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(d => d.FieldType == typeof(TextBox)).ToList();

            //foreach (Control gb in this.Controls)
            //{
            //    if (gb is TabControl)
            //    {
            //        if (gb.Name == "CONTROLE_DADOS")
            //        {
            //            foreach (Control tb in gb.Controls)
            //            {
            //                if (tb.Text == "CADASTRO DE OCORRENCIA")
            //                {
            //                    foreach (Control row in tb.Controls)
            //                    {
            //                        if (row is TextBox)
            //                        {
            //                            var Property = tb.Name;
            //                            var valueText = tb.Text;
            //                            if (valueText != "" && !string.IsNullOrEmpty(valueText))
            //                            {
            //                                progressBarOcorrencia.Value = progressBarOcorrencia.Value + 1;
            //                                count++;
            //                                break;
            //                            }

            //                        }
            //                    }
            //                }
            //                if (tb.Text == "CADASTRO COMPLEMENTAR")
            //                {
            //                    foreach (Control row in tb.Controls)
            //                    {
            //                        if (row is TextBox)
            //                        {
            //                            var Property = tb.Name;
            //                            var valueText = tb.Text;
            //                            if (valueText != "" && !string.IsNullOrEmpty(valueText))
            //                            {
            //                                progressBarComple.Value = progressBarComple.Value + 1;
            //                                count++;
            //                                break;
            //                            }

            //                        }
            //                    }
            //                }
            //                if (tb.Text == "CADASTRO FILHO(A)")
            //                {
            //                    foreach (Control row in tb.Controls)
            //                    {
            //                        if (row is TextBox)
            //                        {
            //                            var Property = tb.Name;
            //                            var valueText = tb.Text;
            //                            if (valueText != "" && !string.IsNullOrEmpty(valueText))
            //                            {
            //                                progressBarFilhos.Value = progressBarFilhos.Value + 1;
            //                                count++;
            //                                break;
            //                            }

            //                        }
            //                    }
            //                }
            //                if (tb.Text == "CADASTRO DE IDOSO")
            //                {
            //                    foreach (Control row in tb.Controls)
            //                    {
            //                        if (row is TextBox)
            //                        {
            //                            var Property = tb.Name;
            //                            var valueText = tb.Text;
            //                            if (valueText != "" && !string.IsNullOrEmpty(valueText))
            //                            {
            //                                progressBarIDOSO.Value = progressBarIDOSO.Value + 1;
            //                                count++;
            //                                break;
            //                            }

            //                        }
            //                    }
            //                }
            //                if (tb.Text == "CADASTRO DE S.O.S")
            //                {
            //                    foreach (Control row in tb.Controls)
            //                    {
            //                        if (row is TextBox)
            //                        {
            //                            var Property = tb.Name;
            //                            var valueText = tb.Text;
            //                            if (valueText != "" && !string.IsNullOrEmpty(valueText))
            //                            {
            //                                progressBarSOS.Value = progressBarSOS.Value + 1;
            //                                count++;
            //                                break;
            //                            }

            //                        }
            //                    }
            //                }

            //            }
            //        }

            //    }
            //    if (gb is GroupBox)
            //    {
            //        if(gb.Name == "DADOS_PESSOAIS")
            //        {
            //            foreach (Control tb in gb.Controls)
            //            {
            //                if (tb is TextBox)
            //                {
            //                    var Property = tb.Name;
            //                    var valueText = tb.Text;
            //                    if(valueText != "" && !string.IsNullOrEmpty(valueText))  {
            //                        progressBarDADOSPESSOAIS.Value = progressBarDADOSPESSOAIS.Value + 1;
            //                        count++;
            //                        break;
            //                    }

            //                }
            //            }
            //        }
            //        if(gb.Name == "DADOS_ENDERECO")
            //        {
            //            foreach (Control tb in gb.Controls)
            //            {
            //                if (tb is TextBox)
            //                {
            //                    var Property = tb.Name;
            //                    var valueText = tb.Text;
            //                    if (valueText != "" && !string.IsNullOrEmpty(valueText))
            //                    {
            //                        progressBarENDERECO.Value = progressBarENDERECO.Value + 1;
            //                        count++;
            //                        break;
            //                    }

            //                }
            //            }
            //        }
            //        if(gb.Name == "DADOS_CONTATO")
            //        {
            //            foreach (Control tb in gb.Controls)
            //            {
            //                if (tb is TextBox)
            //                {
            //                    var Property = tb.Name;
            //                    var valueText = tb.Text;
            //                    if (valueText != "" && !string.IsNullOrEmpty(valueText))
            //                    {
            //                        progressBarCONTATOS.Value = progressBarCONTATOS.Value + 1;
            //                        count++;
            //                        break;
            //                    }

            //                }
            //            }
            //        }
            //    }
            //    if (count > 0)
            //    {
            //        count = 0;
            //        break;
            //    }

            //}


            //FieldInfo[] campos = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);




            //foreach (FieldInfo campo in campos)
            //{
            //    if (campo.FieldType == typeof(TabControl))
            //    {
            //        string a = campo.Name;
            //    }

            //    if (campo.FieldType == typeof(GroupBox))
            //    {
            //        string nomeGroup = campo.Name;
            //        switch (nomeGroup)
            //        {
            //            case "DADOS_PESSOAIS":
            //                if (progressBar1.Value < 100)
            //                {
            //                    if (campo.FieldType == typeof(TextBox))
            //                    {
            //                        TextBox t = (TextBox)FindControlByName(this, campo.Name);
            //                        if (t.Text != "" && !string.IsNullOrEmpty(t.Text))
            //                        {
            //                            progressBar1.Value = progressBar1.Value + 1;
            //                            count++;
            //                        }
            //                    }


            //                }
            //                break;

            //            case "DADOS_ENDERECO":
            //                if (progressBar2.Value < 100)
            //                {
            //                    if (campo.FieldType == typeof(TextBox))
            //                    {
            //                        TextBox t = (TextBox)FindControlByName(this, campo.Name);
            //                        if (t.Text != "" && !string.IsNullOrEmpty(t.Text))
            //                        {
            //                            progressBar2.Value = progressBar2.Value + 1;
            //                            count++;
            //                        }
            //                    }                                   

            //                }
            //                break;

            //            case "DADOS_CONTATO":
            //                if (progressBar3.Value < 100)
            //                {
            //                    if (campo.FieldType == typeof(TextBox))
            //                    {
            //                        TextBox t = (TextBox)FindControlByName(this, campo.Name);
            //                        if (t.Text != "" && !string.IsNullOrEmpty(t.Text))
            //                        {
            //                            progressBar3.Value = progressBar3.Value + 1;
            //                            count++;
            //                        }
            //                    }

            //                }

            //                break;

            //            default:
            //                break;
            //        }
            //        if (count > 0)
            //            break;
            //    }

            //    if (campo.FieldType == typeof(TextBox))
            //    {



            //        //TextBox t = (TextBox)FindControlByName(this, campo.Name);
            //        //if(t.Text != "" && !string.IsNullOrEmpty(t.Text))
            //        //{
            //        //    if (progressBar6.Value < 100)
            //        //    {
            //        //        progressBar1.Value = progressBar1.Value + 1;
            //        //        progressBar2.Value = progressBar2.Value + 1;
            //        //        progressBar3.Value = progressBar3.Value + 1;
            //        //        progressBar4.Value = progressBar4.Value + 1;
            //        //        progressBar5.Value = progressBar5.Value + 1;
            //        //        progressBar6.Value = progressBar6.Value + 1;
            //        //        label66.Text = count.ToString() + "%";
            //        //        count++;
            //        //    }

            //        //}

            //    }

            //    //MessageBox.Show(texto);
            //}

            //foreach (Control item in this.Controls)
            //{

            //    if (item is TextBox)
            //    {
            //        if (item.Text != string.Empty)
            //        {
            //            progressBar1.Value = progressBar1.Value + 1;
            //        }
            //    }


            //    if (item.AccessibilityObject.Name == "CADASTRO COMPLETO")
            //    {
            //        foreach (Control items in item.Controls)
            //        {
            //            if (item is TextBox)
            //            {
            //                if (item.Text != string.Empty)
            //                {
            //                    progressBar1.Value = progressBar1.Value + 1;
            //                }
            //            }
            //        }

            //    }

            //}

            //var value = Property.Trim();
            //if (!string.IsNullOrEmpty(value) && value != "")
            //{
            //    if (valid == 0)
            //    {
            //        progressBar1.Value = progressBar1.Value + 1;
            //        valid++;
            //    }
            //}
            //else
            //{
            //    if (valid > 0)
            //    {
            //        progressBar1.Value = progressBar1.Value - 1;
            //        valid--;
            //    }

            //}
        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_PESSOAIS";
            ChargeProgressBar1(type, t.Text, t.Name,grupo);
        }

        private void Sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            ComboBox t = (ComboBox)sender;
            string grupo = "DADOS_PESSOAIS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Naturalidade_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_PESSOAIS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        public bool rg_used { get; set; }
        private void RG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var type = sender.GetType().Name;
            MaskedTextBox t = (MaskedTextBox)sender;
            string grupo = "DADOS_PESSOAIS";
            string RG = t.Text.Replace(",", "").Replace("-", "");

            if (RG.Length == 0)
            {
                progressBarDADOSPESSOAIS.Value = progressBarDADOSPESSOAIS.Value - 1;
                rg_used = false;
            }
            if (RG.Length == 9){
                if (rg_used != true)
                {
                    ChargeProgressBar1(type, RG, t.Name, grupo);
                    rg_used = true;
                }
            }
        }

        private void OrgaoEmissor_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_PESSOAIS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var type = sender.GetType().Name;
            MaskedTextBox t = (MaskedTextBox)sender;
            string grupo = "DADOS_PESSOAIS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Nacionalidade_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_PESSOAIS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void DataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var type = sender.GetType().Name;
            MaskedTextBox t = (MaskedTextBox)sender;
            string grupo = "DADOS_PESSOAIS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void EstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            ComboBox t = (ComboBox)sender;
            string grupo = "DADOS_PESSOAIS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Escolaridade1_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_PESSOAIS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Portador_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            ComboBox t = (ComboBox)sender;
            string grupo = "DADOS_PESSOAIS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void PortadorDeficiencia_TextChanged(object sender, EventArgs e)
        {
            ChargeProgressBar1();
        }

        private void Logradouro_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_ENDERECO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Bairro_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_ENDERECO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtCidade1_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_ENDERECO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Pais_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_ENDERECO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Cep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var type = sender.GetType().Name;
            MaskedTextBox t = (MaskedTextBox)sender;
            string grupo = "DADOS_ENDERECO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Estado_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_ENDERECO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Numero_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_ENDERECO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void TelefoneFixo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var type = sender.GetType().Name;
            MaskedTextBox t = (MaskedTextBox)sender;
            string grupo = "DADOS_CONTATO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
            
        }

        private void CelularWhatsApp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var type = sender.GetType().Name;
            MaskedTextBox t = (MaskedTextBox)sender;
            string grupo = "DADOS_CONTATO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_CONTATO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void Link_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_CONTATO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void TipoLink_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            ComboBox t = (ComboBox)sender;
            string grupo = "DADOS_CONTATO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void PROGRESS_BOX_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar7_Click(object sender, EventArgs e)
        {

        }

        private void txtBO_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtProfissao_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtRendaPessoal_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtRendaFamiliar_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtLicitasVitima_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtIlicitaVitima_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtQtdFilhos_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtQtdoIdosoVitima_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkSimFilhosVitima_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkNaoFilhosVitima_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkSimIdosoVitima_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkNaoIdosoVitima_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtNomeFilho_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_FILHOS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtNomeEscola_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_FILHOS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void mskDataNascimentoFilho_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var type = sender.GetType().Name;
            MaskedTextBox t = (MaskedTextBox)sender;
            string grupo = "DADOS_FILHOS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtEnderecoEscola_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_FILHOS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkNaoFilho_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "DADOS_FILHOS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtNecessidadeFilho_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_FILHOS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtNomeIdoso1_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_IDOSO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);

        }

        private void mskDataNascimentoIdoso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var type = sender.GetType().Name;
            MaskedTextBox t = (MaskedTextBox)sender;
            string grupo = "DADOS_IDOSO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkSimIdoso_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "DADOS_IDOSO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkNaoIdoso_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "DADOS_IDOSO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtNecessidadeIdoso_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_IDOSO";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtNomeSOS_TextChanged(object sender, EventArgs e)
        {
            
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_SOS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
  
        }

        private void mskCelularSOS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var type = sender.GetType().Name;
            MaskedTextBox t = (MaskedTextBox)sender;
            string grupo = "DADOS_SOS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void txtVinculoSOS_TextChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            TextBox t = (TextBox)sender;
            string grupo = "DADOS_SOS";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CONTROLE_COMPLEM_Click(object sender, EventArgs e)
        {

        }

        private void chkF_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkS_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkP_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkPT_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkM_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "CONTROLE_COMPLEM";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkSimLicitasVitima_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkNaoLicitasVitima_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkSimIlicitaVitima_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void chkNaoIlicitaVitima_CheckedChanged(object sender, EventArgs e)
        {
            var type = sender.GetType().Name;
            CheckBox t = (CheckBox)sender;
            string grupo = "TabPage2";
            ChargeProgressBar1(type, t.Text, t.Name, grupo);
        }

        private void DADOS_FILHOS_Click(object sender, EventArgs e)
        {

        }

        public bool dadospessoais { get; set; }
        public bool complemento { get; set; }
        public bool endereco { get; set; }
        public bool ocorrencias { get; set; }
        public bool filhos { get; set; }
        public bool idoso { get; set; }
        public bool sos { get; set; }
        public bool contatos { get; set; }
        public int total { get; set; }
        public void ProgressBarFull()
        {            
            if(progressBarComple.Value == 99)
            {
                if (complemento == false)
                {
                    progressBarFULL.Value = progressBarFULL.Value + 11;
                    complemento = true;
                    total = total + 11;
                    label66.Text = "" + total.ToString() + "%";
                }
            }
            if (progressBarCONTATOS.Value == 99)
            {
                if (contatos == false)
                {
                    progressBarFULL.Value = progressBarFULL.Value + 11;
                    contatos = true;
                    total = total + 11;
                    label66.Text = "" + total.ToString() + "%";
                }
            }
            if (progressBarENDERECO.Value == 99)
            {
                if (endereco == false)
                {
                    progressBarFULL.Value = progressBarFULL.Value + 11;
                    endereco = true;
                    total = total + 11;
                    label66.Text = "" + total.ToString() + "%";
                }
            }
               

            if (progressBarOcorrencia.Value == 99)
            {
                if (ocorrencias == false)
                {
                    progressBarFULL.Value = progressBarFULL.Value + 11;
                    ocorrencias = true;
                    total = total + 11;
                    label66.Text = "" + total.ToString() + "%";
                }
            }
             

            if (progressBarFilhos.Value == 99)
            {
                if (filhos == false)
                {
                    progressBarFULL.Value = progressBarFULL.Value + 11;
                    filhos = true;
                    total = total + 11;
                    label66.Text = "" + total.ToString() + "%";
                }
            }
               

            if (progressBarSOS.Value == 99)
            {
                if (sos == false)
                {
                    progressBarFULL.Value = progressBarFULL.Value + 22;
                    sos = true;
                    total = total + 23;
                    label66.Text = "" + total.ToString() + "%";
                }
            }
               

            if (progressBarIDOSO.Value == 99)
            {
                if (idoso == false)
                {
                    progressBarFULL.Value = progressBarFULL.Value + 11;
                    idoso = true;
                    total = total + 11;
                    label66.Text = "" + total.ToString() + "%";
                }
            }
               

            if (progressBarDADOSPESSOAIS.Value == 99)
            {
                if (dadospessoais == false)
                {
                    progressBarFULL.Value = progressBarFULL.Value + 11;                   
                    dadospessoais = true;
                    total = total + 11;
                    label66.Text = "" + total.ToString() + "%";
                }
                
            }
               
        }
    }
}
