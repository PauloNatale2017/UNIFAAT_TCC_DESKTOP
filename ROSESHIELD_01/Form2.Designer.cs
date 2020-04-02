namespace ROSESHIELD_01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.cadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbMaterDayDataSet1 = new ROSESHIELD_01.dbMaterDayDataSet1();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNomeCadastrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dbMaterDayDataSet = new ROSESHIELD_01.dbMaterDayDataSet();
            this.dbMaterDayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroTableAdapter = new ROSESHIELD_01.dbMaterDayDataSet1TableAdapters.CadastroTableAdapter();
            this.dbMaterDayDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroTableAdapter1 = new ROSESHIELD_01.dbMaterDayDataSetTableAdapters.CadastroTableAdapter();
            this.tableAdapterManager = new ROSESHIELD_01.dbMaterDayDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dbMaterDayDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dataGridViewSOS = new System.Windows.Forms.DataGridView();
            this.dataGridViewIdoso = new System.Windows.Forms.DataGridView();
            this.dataGridViewBasic = new System.Windows.Forms.DataGridView();
            this.dataGridViewFilhos = new System.Windows.Forms.DataGridView();
            this.dataGridViewCadVit = new System.Windows.Forms.DataGridView();
            this.dataGridViewCompl = new System.Windows.Forms.DataGridView();
            this.dataGridViewocorrencias = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaterDayDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaterDayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaterDayDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaterDayDataSetBindingSource1)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaterDayDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdoso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadVit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewocorrencias)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastroBindingSource
            // 
            this.cadastroBindingSource.DataMember = "Cadastro";
            this.cadastroBindingSource.DataSource = this.dbMaterDayDataSet1;
            // 
            // dbMaterDayDataSet1
            // 
            this.dbMaterDayDataSet1.DataSetName = "dbMaterDayDataSet1";
            this.dbMaterDayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(409, 78);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(182, 22);
            this.txtCidade.TabIndex = 2;
            this.txtCidade.TextChanged += new System.EventHandler(this.TxtCidade_TextChanged);
            // 
            // txtNomeCadastrado
            // 
            this.txtNomeCadastrado.Location = new System.Drawing.Point(19, 78);
            this.txtNomeCadastrado.Name = "txtNomeCadastrado";
            this.txtNomeCadastrado.Size = new System.Drawing.Size(375, 22);
            this.txtNomeCadastrado.TabIndex = 3;
            this.txtNomeCadastrado.TextChanged += new System.EventHandler(this.TxtNomeCadastrado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Usuario";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cidade";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "PESQUISA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(630, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 22);
            this.button3.TabIndex = 7;
            this.button3.Text = "LIMPA PESQUISA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dbMaterDayDataSet
            // 
            this.dbMaterDayDataSet.DataSetName = "dbMaterDayDataSet";
            this.dbMaterDayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbMaterDayDataSetBindingSource
            // 
            this.dbMaterDayDataSetBindingSource.DataSource = this.dbMaterDayDataSet;
            this.dbMaterDayDataSetBindingSource.Position = 0;
            // 
            // cadastroTableAdapter
            // 
            this.cadastroTableAdapter.ClearBeforeFill = true;
            // 
            // dbMaterDayDataSetBindingSource1
            // 
            this.dbMaterDayDataSetBindingSource1.DataSource = this.dbMaterDayDataSet;
            this.dbMaterDayDataSetBindingSource1.Position = 0;
            // 
            // cadastroTableAdapter1
            // 
            this.cadastroTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroTableAdapter = this.cadastroTableAdapter1;
            this.tableAdapterManager.UpdateOrder = ROSESHIELD_01.dbMaterDayDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1357, 27);
            this.fillToolStrip.TabIndex = 9;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.FillToolStripButton_Click);
            // 
            // dbMaterDayDataSetBindingSource2
            // 
            this.dbMaterDayDataSetBindingSource2.DataSource = this.dbMaterDayDataSet;
            this.dbMaterDayDataSetBindingSource2.Position = 0;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1186, 18);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(46, 42);
            this.btnRestaurar.TabIndex = 41;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1239, 18);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(50, 42);
            this.btnMaximizar.TabIndex = 42;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1295, 18);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(51, 42);
            this.btnFechar.TabIndex = 43;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click_1);
            // 
            // dataGridViewSOS
            // 
            this.dataGridViewSOS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewSOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSOS.Location = new System.Drawing.Point(16, 152);
            this.dataGridViewSOS.Name = "dataGridViewSOS";
            this.dataGridViewSOS.RowHeadersWidth = 51;
            this.dataGridViewSOS.RowTemplate.Height = 24;
            this.dataGridViewSOS.Size = new System.Drawing.Size(613, 145);
            this.dataGridViewSOS.TabIndex = 44;
            // 
            // dataGridViewIdoso
            // 
            this.dataGridViewIdoso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewIdoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIdoso.Location = new System.Drawing.Point(653, 152);
            this.dataGridViewIdoso.Name = "dataGridViewIdoso";
            this.dataGridViewIdoso.RowHeadersWidth = 51;
            this.dataGridViewIdoso.RowTemplate.Height = 24;
            this.dataGridViewIdoso.Size = new System.Drawing.Size(656, 145);
            this.dataGridViewIdoso.TabIndex = 45;
            // 
            // dataGridViewBasic
            // 
            this.dataGridViewBasic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewBasic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBasic.Location = new System.Drawing.Point(652, 320);
            this.dataGridViewBasic.Name = "dataGridViewBasic";
            this.dataGridViewBasic.RowHeadersWidth = 51;
            this.dataGridViewBasic.RowTemplate.Height = 24;
            this.dataGridViewBasic.Size = new System.Drawing.Size(656, 145);
            this.dataGridViewBasic.TabIndex = 47;
            // 
            // dataGridViewFilhos
            // 
            this.dataGridViewFilhos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewFilhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilhos.Location = new System.Drawing.Point(16, 320);
            this.dataGridViewFilhos.Name = "dataGridViewFilhos";
            this.dataGridViewFilhos.RowHeadersWidth = 51;
            this.dataGridViewFilhos.RowTemplate.Height = 24;
            this.dataGridViewFilhos.Size = new System.Drawing.Size(613, 145);
            this.dataGridViewFilhos.TabIndex = 46;
            // 
            // dataGridViewCadVit
            // 
            this.dataGridViewCadVit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewCadVit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCadVit.Location = new System.Drawing.Point(651, 487);
            this.dataGridViewCadVit.Name = "dataGridViewCadVit";
            this.dataGridViewCadVit.RowHeadersWidth = 51;
            this.dataGridViewCadVit.RowTemplate.Height = 24;
            this.dataGridViewCadVit.Size = new System.Drawing.Size(656, 145);
            this.dataGridViewCadVit.TabIndex = 49;
            // 
            // dataGridViewCompl
            // 
            this.dataGridViewCompl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewCompl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompl.Location = new System.Drawing.Point(14, 488);
            this.dataGridViewCompl.Name = "dataGridViewCompl";
            this.dataGridViewCompl.RowHeadersWidth = 51;
            this.dataGridViewCompl.RowTemplate.Height = 24;
            this.dataGridViewCompl.Size = new System.Drawing.Size(613, 145);
            this.dataGridViewCompl.TabIndex = 48;
            // 
            // dataGridViewocorrencias
            // 
            this.dataGridViewocorrencias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewocorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewocorrencias.Location = new System.Drawing.Point(16, 664);
            this.dataGridViewocorrencias.Name = "dataGridViewocorrencias";
            this.dataGridViewocorrencias.RowHeadersWidth = 51;
            this.dataGridViewocorrencias.RowTemplate.Height = 24;
            this.dataGridViewocorrencias.Size = new System.Drawing.Size(613, 145);
            this.dataGridViewocorrencias.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "CADASTROS DE SOS";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "CADASTROS DE IDOSOS";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "CADASTROS DE FILHOS";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "CADASTROS BASICOS";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "CADASTROS COMPLEMENTARES";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "CADASTROS DE VITIMAS";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 642);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "CADASTROS DE OCORRENCIAS";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1357, 820);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewocorrencias);
            this.Controls.Add(this.dataGridViewCadVit);
            this.Controls.Add(this.dataGridViewCompl);
            this.Controls.Add(this.dataGridViewBasic);
            this.Controls.Add(this.dataGridViewFilhos);
            this.Controls.Add(this.dataGridViewIdoso);
            this.Controls.Add(this.dataGridViewSOS);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeCadastrado);
            this.Controls.Add(this.txtCidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaterDayDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaterDayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaterDayDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaterDayDataSetBindingSource1)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaterDayDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdoso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadVit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewocorrencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dbMaterDayDataSetBindingSource;
        private dbMaterDayDataSet dbMaterDayDataSet;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNomeCadastrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private dbMaterDayDataSet1 dbMaterDayDataSet1;
        private System.Windows.Forms.BindingSource cadastroBindingSource;
        private dbMaterDayDataSet1TableAdapters.CadastroTableAdapter cadastroTableAdapter;
        private System.Windows.Forms.BindingSource dbMaterDayDataSetBindingSource1;
        private dbMaterDayDataSetTableAdapters.CadastroTableAdapter cadastroTableAdapter1;
        private dbMaterDayDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.BindingSource dbMaterDayDataSetBindingSource2;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dataGridViewSOS;
        private System.Windows.Forms.DataGridView dataGridViewIdoso;
        private System.Windows.Forms.DataGridView dataGridViewBasic;
        private System.Windows.Forms.DataGridView dataGridViewFilhos;
        private System.Windows.Forms.DataGridView dataGridViewCadVit;
        private System.Windows.Forms.DataGridView dataGridViewCompl;
        private System.Windows.Forms.DataGridView dataGridViewocorrencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}