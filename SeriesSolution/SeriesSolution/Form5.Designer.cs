namespace SeriesSolution
{
    partial class Form5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seriadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nºTemporadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaIMDBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLançamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimaExibiçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwSeriadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSviewSeries = new SeriesSolution.DSviewSeries();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.seriadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nºTemporadasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAcessadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorColeçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntParcelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFreteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoDeEsperaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwSitesAcessadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwSeriadosTableAdapter = new SeriesSolution.DSviewSeriesTableAdapters.vwSeriadosTableAdapter();
            this.vwSitesAcessadosTableAdapter = new SeriesSolution.DSviewSeriesTableAdapters.vwSitesAcessadosTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSeriadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSviewSeries)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSitesAcessadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Seriados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seriadoDataGridViewTextBoxColumn,
            this.descriçãoDataGridViewTextBoxColumn,
            this.nºTemporadasDataGridViewTextBoxColumn,
            this.notaIMDBDataGridViewTextBoxColumn,
            this.dataLançamentoDataGridViewTextBoxColumn,
            this.ultimaExibiçãoDataGridViewTextBoxColumn,
            this.situaçãoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwSeriadosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // seriadoDataGridViewTextBoxColumn
            // 
            this.seriadoDataGridViewTextBoxColumn.DataPropertyName = "Seriado";
            this.seriadoDataGridViewTextBoxColumn.HeaderText = "Seriado";
            this.seriadoDataGridViewTextBoxColumn.Name = "seriadoDataGridViewTextBoxColumn";
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            this.descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            // 
            // nºTemporadasDataGridViewTextBoxColumn
            // 
            this.nºTemporadasDataGridViewTextBoxColumn.DataPropertyName = "Nº Temporadas";
            this.nºTemporadasDataGridViewTextBoxColumn.HeaderText = "Nº Temporadas";
            this.nºTemporadasDataGridViewTextBoxColumn.Name = "nºTemporadasDataGridViewTextBoxColumn";
            // 
            // notaIMDBDataGridViewTextBoxColumn
            // 
            this.notaIMDBDataGridViewTextBoxColumn.DataPropertyName = "Nota IMDB";
            this.notaIMDBDataGridViewTextBoxColumn.HeaderText = "Nota IMDB";
            this.notaIMDBDataGridViewTextBoxColumn.Name = "notaIMDBDataGridViewTextBoxColumn";
            // 
            // dataLançamentoDataGridViewTextBoxColumn
            // 
            this.dataLançamentoDataGridViewTextBoxColumn.DataPropertyName = "Data Lançamento";
            this.dataLançamentoDataGridViewTextBoxColumn.HeaderText = "Data Lançamento";
            this.dataLançamentoDataGridViewTextBoxColumn.Name = "dataLançamentoDataGridViewTextBoxColumn";
            this.dataLançamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ultimaExibiçãoDataGridViewTextBoxColumn
            // 
            this.ultimaExibiçãoDataGridViewTextBoxColumn.DataPropertyName = "Ultima exibição";
            this.ultimaExibiçãoDataGridViewTextBoxColumn.HeaderText = "Ultima exibição";
            this.ultimaExibiçãoDataGridViewTextBoxColumn.Name = "ultimaExibiçãoDataGridViewTextBoxColumn";
            this.ultimaExibiçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situaçãoDataGridViewTextBoxColumn
            // 
            this.situaçãoDataGridViewTextBoxColumn.DataPropertyName = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.Name = "situaçãoDataGridViewTextBoxColumn";
            // 
            // vwSeriadosBindingSource
            // 
            this.vwSeriadosBindingSource.DataMember = "vwSeriados";
            this.vwSeriadosBindingSource.DataSource = this.dSviewSeries;
            // 
            // dSviewSeries
            // 
            this.dSviewSeries.DataSetName = "DSviewSeries";
            this.dSviewSeries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(902, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coleções";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seriadoDataGridViewTextBoxColumn1,
            this.nºTemporadasDataGridViewTextBoxColumn1,
            this.dataAcessadoDataGridViewTextBoxColumn,
            this.lojaDataGridViewTextBoxColumn,
            this.valorColeçãoDataGridViewTextBoxColumn,
            this.qntParcelasDataGridViewTextBoxColumn,
            this.valorParcelasDataGridViewTextBoxColumn,
            this.valorFreteDataGridViewTextBoxColumn,
            this.entregaDataGridViewTextBoxColumn,
            this.tempoDeEsperaDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vwSitesAcessadosBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(896, 318);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // seriadoDataGridViewTextBoxColumn1
            // 
            this.seriadoDataGridViewTextBoxColumn1.DataPropertyName = "Seriado";
            this.seriadoDataGridViewTextBoxColumn1.HeaderText = "Seriado";
            this.seriadoDataGridViewTextBoxColumn1.Name = "seriadoDataGridViewTextBoxColumn1";
            // 
            // nºTemporadasDataGridViewTextBoxColumn1
            // 
            this.nºTemporadasDataGridViewTextBoxColumn1.DataPropertyName = "Nº Temporadas";
            this.nºTemporadasDataGridViewTextBoxColumn1.HeaderText = "Nº Temporadas";
            this.nºTemporadasDataGridViewTextBoxColumn1.Name = "nºTemporadasDataGridViewTextBoxColumn1";
            // 
            // dataAcessadoDataGridViewTextBoxColumn
            // 
            this.dataAcessadoDataGridViewTextBoxColumn.DataPropertyName = "Data Acessado";
            this.dataAcessadoDataGridViewTextBoxColumn.HeaderText = "Data Acessado";
            this.dataAcessadoDataGridViewTextBoxColumn.Name = "dataAcessadoDataGridViewTextBoxColumn";
            this.dataAcessadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lojaDataGridViewTextBoxColumn
            // 
            this.lojaDataGridViewTextBoxColumn.DataPropertyName = "Loja";
            this.lojaDataGridViewTextBoxColumn.HeaderText = "Loja";
            this.lojaDataGridViewTextBoxColumn.Name = "lojaDataGridViewTextBoxColumn";
            // 
            // valorColeçãoDataGridViewTextBoxColumn
            // 
            this.valorColeçãoDataGridViewTextBoxColumn.DataPropertyName = "Valor Coleção";
            this.valorColeçãoDataGridViewTextBoxColumn.HeaderText = "Valor Coleção";
            this.valorColeçãoDataGridViewTextBoxColumn.Name = "valorColeçãoDataGridViewTextBoxColumn";
            // 
            // qntParcelasDataGridViewTextBoxColumn
            // 
            this.qntParcelasDataGridViewTextBoxColumn.DataPropertyName = "Qnt Parcelas";
            this.qntParcelasDataGridViewTextBoxColumn.HeaderText = "Qnt Parcelas";
            this.qntParcelasDataGridViewTextBoxColumn.Name = "qntParcelasDataGridViewTextBoxColumn";
            // 
            // valorParcelasDataGridViewTextBoxColumn
            // 
            this.valorParcelasDataGridViewTextBoxColumn.DataPropertyName = "Valor Parcelas";
            this.valorParcelasDataGridViewTextBoxColumn.HeaderText = "Valor Parcelas";
            this.valorParcelasDataGridViewTextBoxColumn.Name = "valorParcelasDataGridViewTextBoxColumn";
            this.valorParcelasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorFreteDataGridViewTextBoxColumn
            // 
            this.valorFreteDataGridViewTextBoxColumn.DataPropertyName = "Valor frete";
            this.valorFreteDataGridViewTextBoxColumn.HeaderText = "Valor frete";
            this.valorFreteDataGridViewTextBoxColumn.Name = "valorFreteDataGridViewTextBoxColumn";
            // 
            // entregaDataGridViewTextBoxColumn
            // 
            this.entregaDataGridViewTextBoxColumn.DataPropertyName = "Entrega";
            this.entregaDataGridViewTextBoxColumn.HeaderText = "Entrega";
            this.entregaDataGridViewTextBoxColumn.Name = "entregaDataGridViewTextBoxColumn";
            // 
            // tempoDeEsperaDataGridViewTextBoxColumn
            // 
            this.tempoDeEsperaDataGridViewTextBoxColumn.DataPropertyName = "Tempo de Espera";
            this.tempoDeEsperaDataGridViewTextBoxColumn.HeaderText = "Tempo de Espera";
            this.tempoDeEsperaDataGridViewTextBoxColumn.Name = "tempoDeEsperaDataGridViewTextBoxColumn";
            this.tempoDeEsperaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            // 
            // vwSitesAcessadosBindingSource
            // 
            this.vwSitesAcessadosBindingSource.DataMember = "vwSitesAcessados";
            this.vwSitesAcessadosBindingSource.DataSource = this.dSviewSeries;
            // 
            // vwSeriadosTableAdapter
            // 
            this.vwSeriadosTableAdapter.ClearBeforeFill = true;
            // 
            // vwSitesAcessadosTableAdapter
            // 
            this.vwSitesAcessadosTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 350);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSeriadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSviewSeries)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSitesAcessadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private DSviewSeries dSviewSeries;
        private System.Windows.Forms.BindingSource vwSeriadosBindingSource;
        private DSviewSeriesTableAdapters.vwSeriadosTableAdapter vwSeriadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nºTemporadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaIMDBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLançamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimaExibiçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource vwSitesAcessadosBindingSource;
        private DSviewSeriesTableAdapters.vwSitesAcessadosTableAdapter vwSitesAcessadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nºTemporadasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAcessadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorColeçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntParcelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFreteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoDeEsperaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
    }
}