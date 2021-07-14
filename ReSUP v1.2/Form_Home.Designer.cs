namespace ReSUP_v1._2
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /*
        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        */


        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idAtividadeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PagTeamViewer = new System.Windows.Forms.TabPage();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tecnicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSet1 = new ReSUP_v1._2.DBSet();
            this.ConecatrTVButton = new System.Windows.Forms.Button();
            this.teamViewerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKTeamVieweidClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            this.teamViewerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PagAtividade = new System.Windows.Forms.TabPage();
            this.idTecnicoTextBox = new System.Windows.Forms.TextBox();
            this.fKAtividadeidClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.situacaoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.descricao2TextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.descricao1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idAtividadeListBox = new System.Windows.Forms.ListBox();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.PagCadastros = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabCadCliente = new System.Windows.Forms.TabPage();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tecnicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabCadTecnico = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.clienteDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKClienteidTecnicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tecnicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ComandoTV = new System.Windows.Forms.Label();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.técnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteTableAdapter = new ReSUP_v1._2.DBSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new ReSUP_v1._2.DBSetTableAdapters.TableAdapterManager();
            this.teamViewerTableAdapter = new ReSUP_v1._2.DBSetTableAdapters.TeamViewerTableAdapter();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.atividadeTableAdapter = new ReSUP_v1._2.DBSetTableAdapters.AtividadeTableAdapter();
            this.tecnicoTableAdapter = new ReSUP_v1._2.DBSetTableAdapters.TecnicoTableAdapter();
            this.fKAtividadeidTecnicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKClienteidTecnicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            idAtividadeLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PagTeamViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamViewerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTeamVieweidClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamViewerBindingSource)).BeginInit();
            this.PagAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidClienteBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.PagCadastros.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabCadCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            this.tabCadTecnico.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteidTecnicoBindingSource1)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidTecnicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteidTecnicoBindingSource)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // idAtividadeLabel
            // 
            idAtividadeLabel.AutoSize = true;
            idAtividadeLabel.Location = new System.Drawing.Point(310, 33);
            idAtividadeLabel.Name = "idAtividadeLabel";
            idAtividadeLabel.Size = new System.Drawing.Size(0, 13);
            idAtividadeLabel.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PagTeamViewer);
            this.tabControl1.Controls.Add(this.PagAtividade);
            this.tabControl1.Controls.Add(this.PagCadastros);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(9, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // PagTeamViewer
            // 
            this.PagTeamViewer.AutoScroll = true;
            this.PagTeamViewer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagTeamViewer.Controls.Add(this.commentTextBox);
            this.PagTeamViewer.Controls.Add(this.ConecatrTVButton);
            this.PagTeamViewer.Controls.Add(this.teamViewerDataGridView);
            this.PagTeamViewer.Controls.Add(this.groupBox1);
            this.PagTeamViewer.Location = new System.Drawing.Point(4, 22);
            this.PagTeamViewer.Name = "PagTeamViewer";
            this.PagTeamViewer.Padding = new System.Windows.Forms.Padding(3);
            this.PagTeamViewer.Size = new System.Drawing.Size(789, 375);
            this.PagTeamViewer.TabIndex = 0;
            this.PagTeamViewer.Text = "TeamViewer";
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(306, 18);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(276, 44);
            this.commentTextBox.TabIndex = 6;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "FK_Cliente_idTecnico";
            this.clienteBindingSource1.DataSource = this.tecnicoBindingSource;
            // 
            // tecnicoBindingSource
            // 
            this.tecnicoBindingSource.DataMember = "Tecnico";
            this.tecnicoBindingSource.DataSource = this.dBSet1;
            // 
            // dBSet1
            // 
            this.dBSet1.DataSetName = "DBSet";
            this.dBSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ConecatrTVButton
            // 
            this.ConecatrTVButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ConecatrTVButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConecatrTVButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConecatrTVButton.Location = new System.Drawing.Point(626, 28);
            this.ConecatrTVButton.Name = "ConecatrTVButton";
            this.ConecatrTVButton.Size = new System.Drawing.Size(137, 27);
            this.ConecatrTVButton.TabIndex = 5;
            this.ConecatrTVButton.Text = "Conectar";
            this.ConecatrTVButton.UseVisualStyleBackColor = false;
            this.ConecatrTVButton.Click += new System.EventHandler(this.ConecatrTVButton_Click);
            // 
            // teamViewerDataGridView
            // 
            this.teamViewerDataGridView.AllowUserToOrderColumns = true;
            this.teamViewerDataGridView.AutoGenerateColumns = false;
            this.teamViewerDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.teamViewerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamViewerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamViewerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.teamViewerDataGridView.DataSource = this.fKTeamVieweidClienteBindingSource;
            this.teamViewerDataGridView.Location = new System.Drawing.Point(9, 85);
            this.teamViewerDataGridView.Name = "teamViewerDataGridView";
            this.teamViewerDataGridView.Size = new System.Drawing.Size(773, 242);
            this.teamViewerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomePC";
            this.dataGridViewTextBoxColumn3.HeaderText = "Computador";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumeroTV";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SenhaTV";
            this.dataGridViewTextBoxColumn5.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ObsTV";
            this.dataGridViewTextBoxColumn6.HeaderText = "Observações do Computador";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 435;
            // 
            // fKTeamVieweidClienteBindingSource
            // 
            this.fKTeamVieweidClienteBindingSource.DataMember = "FK_TeamViewe_idCliente";
            this.fKTeamVieweidClienteBindingSource.DataSource = this.clienteBindingSource;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dBSet1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nomeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nomeComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nomeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teamViewerBindingSource, "idCliente", true));
            this.nomeComboBox.DataSource = this.clienteBindingSource;
            this.nomeComboBox.DisplayMember = "Nome";
            this.nomeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nomeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeComboBox.FormattingEnabled = true;
            this.nomeComboBox.Location = new System.Drawing.Point(6, 17);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(250, 21);
            this.nomeComboBox.TabIndex = 1;
            this.nomeComboBox.ValueMember = "idCliente";
            // 
            // teamViewerBindingSource
            // 
            this.teamViewerBindingSource.DataMember = "TeamViewer";
            this.teamViewerBindingSource.DataSource = this.dBSet1;
            // 
            // PagAtividade
            // 
            this.PagAtividade.AutoScroll = true;
            this.PagAtividade.Controls.Add(this.groupBox9);
            this.PagAtividade.Controls.Add(this.groupBox6);
            this.PagAtividade.Controls.Add(this.groupBox5);
            this.PagAtividade.Controls.Add(this.groupBox4);
            this.PagAtividade.Controls.Add(this.groupBox2);
            this.PagAtividade.Controls.Add(idAtividadeLabel);
            this.PagAtividade.Controls.Add(this.groupBox3);
            this.PagAtividade.Location = new System.Drawing.Point(4, 22);
            this.PagAtividade.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.PagAtividade.Name = "PagAtividade";
            this.PagAtividade.Padding = new System.Windows.Forms.Padding(3);
            this.PagAtividade.Size = new System.Drawing.Size(789, 375);
            this.PagAtividade.TabIndex = 1;
            this.PagAtividade.Text = "Atividades";
            this.PagAtividade.UseVisualStyleBackColor = true;
            // 
            // idTecnicoTextBox
            // 
            this.idTecnicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKAtividadeidClienteBindingSource, "idTecnico", true));
            this.idTecnicoTextBox.Location = new System.Drawing.Point(22, 17);
            this.idTecnicoTextBox.Name = "idTecnicoTextBox";
            this.idTecnicoTextBox.Size = new System.Drawing.Size(55, 20);
            this.idTecnicoTextBox.TabIndex = 9;
            this.idTecnicoTextBox.TextChanged += new System.EventHandler(this.idTecnicoTextBox_TextChanged);
            // 
            // fKAtividadeidClienteBindingSource
            // 
            this.fKAtividadeidClienteBindingSource.DataMember = "FK_Atividade_idCliente";
            this.fKAtividadeidClienteBindingSource.DataSource = this.clienteBindingSource;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.situacaoTextBox);
            this.groupBox6.Location = new System.Drawing.Point(496, 300);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(143, 46);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Situação";
            // 
            // situacaoTextBox
            // 
            this.situacaoTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "FINALIZADO",
            "PENDENTE",
            "AGUARDANDO",
            "DBA"});
            this.situacaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.situacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKAtividadeidClienteBindingSource, "Situacao", true));
            this.situacaoTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.situacaoTextBox.Location = new System.Drawing.Point(5, 17);
            this.situacaoTextBox.Name = "situacaoTextBox";
            this.situacaoTextBox.Size = new System.Drawing.Size(132, 20);
            this.situacaoTextBox.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.descricao2TextBox);
            this.groupBox5.Location = new System.Drawing.Point(372, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(267, 170);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Procedimentos";
            // 
            // descricao2TextBox
            // 
            this.descricao2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKAtividadeidClienteBindingSource, "Descricao2", true));
            this.descricao2TextBox.Location = new System.Drawing.Point(6, 19);
            this.descricao2TextBox.Multiline = true;
            this.descricao2TextBox.Name = "descricao2TextBox";
            this.descricao2TextBox.Size = new System.Drawing.Size(255, 145);
            this.descricao2TextBox.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.descricao1TextBox);
            this.groupBox4.Location = new System.Drawing.Point(11, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 170);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descrição da Atividade";
            // 
            // descricao1TextBox
            // 
            this.descricao1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKAtividadeidClienteBindingSource, "Descricao1", true));
            this.descricao1TextBox.Location = new System.Drawing.Point(6, 19);
            this.descricao1TextBox.Multiline = true;
            this.descricao1TextBox.Name = "descricao1TextBox";
            this.descricao1TextBox.Size = new System.Drawing.Size(343, 145);
            this.descricao1TextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.idAtividadeListBox);
            this.groupBox2.Location = new System.Drawing.Point(645, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 335);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atividades";
            // 
            // idAtividadeListBox
            // 
            this.idAtividadeListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.atividadeBindingSource, "idAtividade", true));
            this.idAtividadeListBox.DataSource = this.fKAtividadeidClienteBindingSource;
            this.idAtividadeListBox.DisplayMember = "Created_at";
            this.idAtividadeListBox.FormattingEnabled = true;
            this.idAtividadeListBox.Location = new System.Drawing.Point(8, 18);
            this.idAtividadeListBox.Name = "idAtividadeListBox";
            this.idAtividadeListBox.Size = new System.Drawing.Size(115, 316);
            this.idAtividadeListBox.TabIndex = 3;
            this.idAtividadeListBox.ValueMember = "idAtividade";
            // 
            // atividadeBindingSource
            // 
            this.atividadeBindingSource.DataMember = "Atividade";
            this.atividadeBindingSource.DataSource = this.dBSet1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(11, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teamViewerBindingSource, "idCliente", true));
            this.comboBox2.DataSource = this.clienteBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "idCliente";
            // 
            // PagCadastros
            // 
            this.PagCadastros.AutoScroll = true;
            this.PagCadastros.Controls.Add(this.tabControl2);
            this.PagCadastros.Location = new System.Drawing.Point(4, 22);
            this.PagCadastros.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.PagCadastros.Name = "PagCadastros";
            this.PagCadastros.Padding = new System.Windows.Forms.Padding(3);
            this.PagCadastros.Size = new System.Drawing.Size(789, 375);
            this.PagCadastros.TabIndex = 2;
            this.PagCadastros.Text = "Cadastros";
            this.PagCadastros.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabCadCliente);
            this.tabControl2.Controls.Add(this.tabCadTecnico);
            this.tabControl2.Location = new System.Drawing.Point(0, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(786, 366);
            this.tabControl2.TabIndex = 0;
            // 
            // tabCadCliente
            // 
            this.tabCadCliente.AutoScroll = true;
            this.tabCadCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabCadCliente.Controls.Add(this.clienteDataGridView);
            this.tabCadCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCadCliente.Name = "tabCadCliente";
            this.tabCadCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadCliente.Size = new System.Drawing.Size(778, 340);
            this.tabCadCliente.TabIndex = 0;
            this.tabCadCliente.Text = "Cliente";
            this.tabCadCliente.UseVisualStyleBackColor = true;
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToOrderColumns = true;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clienteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clienteDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.clienteDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.clienteDataGridView.DataSource = this.clienteBindingSource2;
            this.clienteDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.clienteDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clienteDataGridView.Location = new System.Drawing.Point(0, 8);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(766, 324);
            this.clienteDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Moura ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn8.HeaderText = "Observação";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 325;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "idTecnico";
            this.dataGridViewTextBoxColumn9.DataSource = this.tecnicoBindingSource1;
            this.dataGridViewTextBoxColumn9.DisplayMember = "NomeTecnico";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tecnico Responsável";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "idTecnico";
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // tecnicoBindingSource1
            // 
            this.tecnicoBindingSource1.DataMember = "Tecnico";
            this.tecnicoBindingSource1.DataSource = this.dBSet1;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "Cliente";
            this.clienteBindingSource2.DataSource = this.dBSet1;
            // 
            // tabCadTecnico
            // 
            this.tabCadTecnico.AutoScroll = true;
            this.tabCadTecnico.Controls.Add(this.groupBox8);
            this.tabCadTecnico.Controls.Add(this.groupBox7);
            this.tabCadTecnico.Location = new System.Drawing.Point(4, 22);
            this.tabCadTecnico.Name = "tabCadTecnico";
            this.tabCadTecnico.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadTecnico.Size = new System.Drawing.Size(778, 340);
            this.tabCadTecnico.TabIndex = 1;
            this.tabCadTecnico.Text = "Tecnico";
            this.tabCadTecnico.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.clienteDataGridView1);
            this.groupBox8.Location = new System.Drawing.Point(346, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(426, 322);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Clientes Relacionados";
            // 
            // clienteDataGridView1
            // 
            this.clienteDataGridView1.AllowUserToOrderColumns = true;
            this.clienteDataGridView1.AutoGenerateColumns = false;
            this.clienteDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.clienteDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.clienteDataGridView1.DataSource = this.fKClienteidTecnicoBindingSource1;
            this.clienteDataGridView1.Location = new System.Drawing.Point(8, 19);
            this.clienteDataGridView1.Name = "clienteDataGridView1";
            this.clienteDataGridView1.Size = new System.Drawing.Size(413, 291);
            this.clienteDataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn12.HeaderText = "Moura ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 76;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn13.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 130;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn14.HeaderText = "Observação";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.Width = 160;
            // 
            // fKClienteidTecnicoBindingSource1
            // 
            this.fKClienteidTecnicoBindingSource1.DataMember = "FK_Cliente_idTecnico";
            this.fKClienteidTecnicoBindingSource1.DataSource = this.tecnicoBindingSource1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tecnicoDataGridView);
            this.groupBox7.Location = new System.Drawing.Point(10, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(330, 322);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Relação de Técnicos";
            // 
            // tecnicoDataGridView
            // 
            this.tecnicoDataGridView.AllowUserToOrderColumns = true;
            this.tecnicoDataGridView.AutoGenerateColumns = false;
            this.tecnicoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tecnicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tecnicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn10});
            this.tecnicoDataGridView.DataSource = this.tecnicoBindingSource1;
            this.tecnicoDataGridView.Location = new System.Drawing.Point(10, 19);
            this.tecnicoDataGridView.Name = "tecnicoDataGridView";
            this.tecnicoDataGridView.Size = new System.Drawing.Size(311, 291);
            this.tecnicoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idTecnico";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tecnico ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NomeTecnico";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 190;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 375);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ComandoTV
            // 
            this.ComandoTV.BackColor = System.Drawing.Color.Transparent;
            this.ComandoTV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKTeamVieweidClienteBindingSource, "ComandoTV", true));
            this.ComandoTV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ComandoTV.Location = new System.Drawing.Point(534, 456);
            this.ComandoTV.Name = "ComandoTV";
            this.ComandoTV.Size = new System.Drawing.Size(272, 17);
            this.ComandoTV.TabIndex = 4;
            this.ComandoTV.Text = "label1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator,
            this.salvarToolStripMenuItem,
            this.salvarcomoToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimirToolStripMenuItem,
            this.visualizarImpressãoToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "&Salvar";
            // 
            // salvarcomoToolStripMenuItem
            // 
            this.salvarcomoToolStripMenuItem.Name = "salvarcomoToolStripMenuItem";
            this.salvarcomoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarcomoToolStripMenuItem.Text = "Salvar &como";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // visualizarImpressãoToolStripMenuItem
            // 
            this.visualizarImpressãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizarImpressãoToolStripMenuItem.Image")));
            this.visualizarImpressãoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.visualizarImpressãoToolStripMenuItem.Name = "visualizarImpressãoToolStripMenuItem";
            this.visualizarImpressãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarImpressãoToolStripMenuItem.Text = "Visuali&zar Impressão";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sai&r";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem,
            this.toolStripSeparator3,
            this.recortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.toolStripSeparator4,
            this.selecionarTudoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.desfazerToolStripMenuItem.Text = "&Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.refazerToolStripMenuItem.Text = "&Refazer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripMenuItem.Image")));
            this.recortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.recortarToolStripMenuItem.Text = "Recor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripMenuItem.Image")));
            this.colarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.colarToolStripMenuItem.Text = "C&olar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(156, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar &Tudo";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.técnicoToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ferramentasToolStripMenuItem.Text = "Cadastros";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.personalizarToolStripMenuItem.Text = "Team Viewer";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.opçõesToolStripMenuItem.Text = "Cliente";
            // 
            // técnicoToolStripMenuItem
            // 
            this.técnicoToolStripMenuItem.Name = "técnicoToolStripMenuItem";
            this.técnicoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.técnicoToolStripMenuItem.Text = "Técnico";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtividadeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.TeamViewerTableAdapter = this.teamViewerTableAdapter;
            this.tableAdapterManager.TecnicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ReSUP_v1._2.DBSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teamViewerTableAdapter
            // 
            this.teamViewerTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = null;
            this.clienteBindingNavigator.CountItem = null;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator5,
            this.bindingNavigatorSeparator2,
            this.clienteBindingNavigatorSaveItem,
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.toolStripSeparator9});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.clienteBindingNavigator.MoveFirstItem = null;
            this.clienteBindingNavigator.MoveLastItem = null;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = null;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(816, 25);
            this.clienteBindingNavigator.TabIndex = 2;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(62, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(58, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click_2);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // atividadeTableAdapter
            // 
            this.atividadeTableAdapter.ClearBeforeFill = true;
            // 
            // tecnicoTableAdapter
            // 
            this.tecnicoTableAdapter.ClearBeforeFill = true;
            // 
            // fKAtividadeidTecnicoBindingSource
            // 
            this.fKAtividadeidTecnicoBindingSource.DataMember = "FK_Atividade_idTecnico";
            this.fKAtividadeidTecnicoBindingSource.DataSource = this.tecnicoBindingSource;
            // 
            // fKClienteidTecnicoBindingSource
            // 
            this.fKClienteidTecnicoBindingSource.DataMember = "FK_Cliente_idTecnico";
            this.fKClienteidTecnicoBindingSource.DataSource = this.tecnicoBindingSource1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.idTecnicoTextBox);
            this.groupBox9.Location = new System.Drawing.Point(537, 13);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(102, 50);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "ID do Tecnico";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 475);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ComandoTV);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "ReSUP v1.2";
            this.Load += new System.EventHandler(this.Form_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.PagTeamViewer.ResumeLayout(false);
            this.PagTeamViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamViewerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTeamVieweidClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamViewerBindingSource)).EndInit();
            this.PagAtividade.ResumeLayout(false);
            this.PagAtividade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidClienteBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.PagCadastros.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabCadCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            this.tabCadTecnico.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteidTecnicoBindingSource1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tecnicoDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKAtividadeidTecnicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClienteidTecnicoBindingSource)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PagTeamViewer;
        private System.Windows.Forms.TabPage PagAtividade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarcomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarImpressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private DBSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private DBSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox nomeComboBox;
        private DBSet dBSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DBSetTableAdapters.TeamViewerTableAdapter teamViewerTableAdapter;
        private System.Windows.Forms.BindingSource teamViewerBindingSource;
        private System.Windows.Forms.DataGridView teamViewerDataGridView;
        private System.Windows.Forms.BindingSource fKTeamVieweidClienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.Label ComandoTV;
        private System.Windows.Forms.Button ConecatrTVButton;
        private System.Windows.Forms.ToolStripMenuItem técnicoToolStripMenuItem;
        private System.Windows.Forms.TabPage PagCadastros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private DBSetTableAdapters.AtividadeTableAdapter atividadeTableAdapter;
        private System.Windows.Forms.ListBox idAtividadeListBox;
        private System.Windows.Forms.BindingSource fKAtividadeidClienteBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox descricao1TextBox;
        private System.Windows.Forms.TextBox descricao2TextBox;
        private System.Windows.Forms.BindingSource tecnicoBindingSource;
        private DBSetTableAdapters.TecnicoTableAdapter tecnicoTableAdapter;
        private System.Windows.Forms.BindingSource fKAtividadeidTecnicoBindingSource;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox situacaoTextBox;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabCadCliente;
        private System.Windows.Forms.TabPage tabCadTecnico;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.TextBox idTecnicoTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.BindingSource tecnicoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView tecnicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView clienteDataGridView1;
        private System.Windows.Forms.BindingSource fKClienteidTecnicoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource fKClienteidTecnicoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.GroupBox groupBox9;
    }
}

