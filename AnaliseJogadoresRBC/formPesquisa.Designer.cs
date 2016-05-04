namespace AnaliseJogadoresRBC
{
    partial class formPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.bsoPrincipal = new System.Windows.Forms.BindingSource(this.components);
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelBtnAlter = new System.Windows.Forms.Panel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panelBtnDelete = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerBarraProgresso = new System.Windows.Forms.Timer(this.components);
            this.cadastro1 = new ClasseLogica.Cadastro();
            this.tbcPesos = new System.Windows.Forms.TabControl();
            this.tbcPesoPosicao = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdPesoPosicao = new System.Windows.Forms.DataGridView();
            this.bsoPesoPosicao = new System.Windows.Forms.BindingSource(this.components);
            this.dtsPesoPosicao = new AnaliseJogadoresRBC.dtsPesoPosicao();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atributoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centroavanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atacanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meiaatacanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meiocampolateralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meiocampocentralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zagueiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateraldireitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateralesquerdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goleiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPesoContrato = new System.Windows.Forms.DataGridView();
            this.bsoPesoContrato = new System.Windows.Forms.BindingSource(this.components);
            this.dtsPesoContrato = new AnaliseJogadoresRBC.dtsPesoContrato();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quatroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cincoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPrincipal.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPrincipal)).BeginInit();
            this.panelOpcoes.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBtnAlter.SuspendLayout();
            this.panelBtnDelete.SuspendLayout();
            this.tbcPesos.SuspendLayout();
            this.tbcPesoPosicao.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesoPosicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPesoPosicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPesoPosicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesoContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPesoContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPesoContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.pnlDados);
            this.panelPrincipal.Controls.Add(this.panelOpcoes);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(716, 502);
            this.panelPrincipal.TabIndex = 1;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.tbcPesos);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(0, 0);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(716, 436);
            this.pnlDados.TabIndex = 1;
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.Controls.Add(this.panelInfo);
            this.panelOpcoes.Controls.Add(this.panelButtons);
            this.panelOpcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOpcoes.Location = new System.Drawing.Point(0, 436);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(716, 66);
            this.panelOpcoes.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.statusStrip1);
            this.panelInfo.Controls.Add(this.progressBar);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 44);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(716, 22);
            this.panelInfo.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, -2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(579, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.SteelBlue;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.progressBar.Location = new System.Drawing.Point(579, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(135, 20);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.panel3);
            this.panelButtons.Controls.Add(this.panel2);
            this.panelButtons.Controls.Add(this.panelBtnAlter);
            this.panelButtons.Controls.Add(this.panelBtnDelete);
            this.panelButtons.Controls.Add(this.panel1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(716, 44);
            this.panelButtons.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(380, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 42);
            this.panel3.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(5, 9);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 30);
            this.btn_add.TabIndex = 0;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Visible = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(458, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 42);
            this.panel2.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ImageKey = "save_32px.png";
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(5, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(73, 30);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelBtnAlter
            // 
            this.panelBtnAlter.Controls.Add(this.btn_edit);
            this.panelBtnAlter.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtnAlter.Location = new System.Drawing.Point(536, 0);
            this.panelBtnAlter.Name = "panelBtnAlter";
            this.panelBtnAlter.Size = new System.Drawing.Size(78, 42);
            this.panelBtnAlter.TabIndex = 2;
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ImageKey = "edit_file_32px.png";
            this.btn_edit.ImageList = this.imageList1;
            this.btn_edit.Location = new System.Drawing.Point(5, 9);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(73, 30);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Alterar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panelBtnDelete
            // 
            this.panelBtnDelete.Controls.Add(this.btn_Cancel);
            this.panelBtnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtnDelete.Location = new System.Drawing.Point(614, 0);
            this.panelBtnDelete.Name = "panelBtnDelete";
            this.panelBtnDelete.Size = new System.Drawing.Size(80, 42);
            this.panelBtnDelete.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ImageKey = "cancel_32px.png";
            this.btn_Cancel.ImageList = this.imageList1;
            this.btn_Cancel.Location = new System.Drawing.Point(6, 9);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(73, 30);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(694, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 42);
            this.panel1.TabIndex = 0;
            // 
            // timerBarraProgresso
            // 
            this.timerBarraProgresso.Interval = 1;
            this.timerBarraProgresso.Tick += new System.EventHandler(this.timerBarraProgresso_Tick);
            // 
            // cadastro1
            // 
            this.cadastro1.transaction = null;
            // 
            // tbcPesos
            // 
            this.tbcPesos.Controls.Add(this.tbcPesoPosicao);
            this.tbcPesos.Controls.Add(this.tabPage2);
            this.tbcPesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPesos.Location = new System.Drawing.Point(0, 0);
            this.tbcPesos.Name = "tbcPesos";
            this.tbcPesos.SelectedIndex = 0;
            this.tbcPesos.Size = new System.Drawing.Size(716, 436);
            this.tbcPesos.TabIndex = 0;
            // 
            // tbcPesoPosicao
            // 
            this.tbcPesoPosicao.Controls.Add(this.grdPesoPosicao);
            this.tbcPesoPosicao.Location = new System.Drawing.Point(4, 22);
            this.tbcPesoPosicao.Name = "tbcPesoPosicao";
            this.tbcPesoPosicao.Padding = new System.Windows.Forms.Padding(3);
            this.tbcPesoPosicao.Size = new System.Drawing.Size(708, 410);
            this.tbcPesoPosicao.TabIndex = 0;
            this.tbcPesoPosicao.Text = "Peso por posição";
            this.tbcPesoPosicao.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdPesoContrato);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Peso por contrato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdPesoPosicao
            // 
            this.grdPesoPosicao.AllowUserToAddRows = false;
            this.grdPesoPosicao.AllowUserToDeleteRows = false;
            this.grdPesoPosicao.AutoGenerateColumns = false;
            this.grdPesoPosicao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdPesoPosicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesoPosicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.atributoDataGridViewTextBoxColumn,
            this.centroavanteDataGridViewTextBoxColumn,
            this.atacanteDataGridViewTextBoxColumn,
            this.meiaatacanteDataGridViewTextBoxColumn,
            this.meiocampolateralDataGridViewTextBoxColumn,
            this.meiocampocentralDataGridViewTextBoxColumn,
            this.volanteDataGridViewTextBoxColumn,
            this.zagueiroDataGridViewTextBoxColumn,
            this.lateraldireitoDataGridViewTextBoxColumn,
            this.lateralesquerdoDataGridViewTextBoxColumn,
            this.goleiroDataGridViewTextBoxColumn});
            this.grdPesoPosicao.DataSource = this.bsoPesoPosicao;
            this.grdPesoPosicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPesoPosicao.Location = new System.Drawing.Point(3, 3);
            this.grdPesoPosicao.Name = "grdPesoPosicao";
            this.grdPesoPosicao.Size = new System.Drawing.Size(702, 404);
            this.grdPesoPosicao.TabIndex = 0;
            // 
            // bsoPesoPosicao
            // 
            this.bsoPesoPosicao.DataMember = "peso_posicao";
            this.bsoPesoPosicao.DataSource = this.dtsPesoPosicao;
            // 
            // dtsPesoPosicao
            // 
            this.dtsPesoPosicao.DataSetName = "dtsPesoPosicao";
            this.dtsPesoPosicao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atributoDataGridViewTextBoxColumn
            // 
            this.atributoDataGridViewTextBoxColumn.DataPropertyName = "atributo";
            this.atributoDataGridViewTextBoxColumn.HeaderText = "Atributo";
            this.atributoDataGridViewTextBoxColumn.Name = "atributoDataGridViewTextBoxColumn";
            // 
            // centroavanteDataGridViewTextBoxColumn
            // 
            this.centroavanteDataGridViewTextBoxColumn.DataPropertyName = "centroavante";
            this.centroavanteDataGridViewTextBoxColumn.HeaderText = "Centroavante";
            this.centroavanteDataGridViewTextBoxColumn.Name = "centroavanteDataGridViewTextBoxColumn";
            // 
            // atacanteDataGridViewTextBoxColumn
            // 
            this.atacanteDataGridViewTextBoxColumn.DataPropertyName = "atacante";
            this.atacanteDataGridViewTextBoxColumn.HeaderText = "Atacante";
            this.atacanteDataGridViewTextBoxColumn.Name = "atacanteDataGridViewTextBoxColumn";
            // 
            // meiaatacanteDataGridViewTextBoxColumn
            // 
            this.meiaatacanteDataGridViewTextBoxColumn.DataPropertyName = "meia_atacante";
            this.meiaatacanteDataGridViewTextBoxColumn.HeaderText = "Meia Atacante";
            this.meiaatacanteDataGridViewTextBoxColumn.Name = "meiaatacanteDataGridViewTextBoxColumn";
            // 
            // meiocampolateralDataGridViewTextBoxColumn
            // 
            this.meiocampolateralDataGridViewTextBoxColumn.DataPropertyName = "meio_campo_lateral";
            this.meiocampolateralDataGridViewTextBoxColumn.HeaderText = "Meio Campo Lateral";
            this.meiocampolateralDataGridViewTextBoxColumn.Name = "meiocampolateralDataGridViewTextBoxColumn";
            // 
            // meiocampocentralDataGridViewTextBoxColumn
            // 
            this.meiocampocentralDataGridViewTextBoxColumn.DataPropertyName = "meio_campo_central";
            this.meiocampocentralDataGridViewTextBoxColumn.HeaderText = "Meio Campo Central";
            this.meiocampocentralDataGridViewTextBoxColumn.Name = "meiocampocentralDataGridViewTextBoxColumn";
            // 
            // volanteDataGridViewTextBoxColumn
            // 
            this.volanteDataGridViewTextBoxColumn.DataPropertyName = "volante";
            this.volanteDataGridViewTextBoxColumn.HeaderText = "Volante";
            this.volanteDataGridViewTextBoxColumn.Name = "volanteDataGridViewTextBoxColumn";
            // 
            // zagueiroDataGridViewTextBoxColumn
            // 
            this.zagueiroDataGridViewTextBoxColumn.DataPropertyName = "zagueiro";
            this.zagueiroDataGridViewTextBoxColumn.HeaderText = "Zagueiro";
            this.zagueiroDataGridViewTextBoxColumn.Name = "zagueiroDataGridViewTextBoxColumn";
            // 
            // lateraldireitoDataGridViewTextBoxColumn
            // 
            this.lateraldireitoDataGridViewTextBoxColumn.DataPropertyName = "lateral_direito";
            this.lateraldireitoDataGridViewTextBoxColumn.HeaderText = "Lateral Direito";
            this.lateraldireitoDataGridViewTextBoxColumn.Name = "lateraldireitoDataGridViewTextBoxColumn";
            // 
            // lateralesquerdoDataGridViewTextBoxColumn
            // 
            this.lateralesquerdoDataGridViewTextBoxColumn.DataPropertyName = "lateral_esquerdo";
            this.lateralesquerdoDataGridViewTextBoxColumn.HeaderText = "Lateral Esquerdo";
            this.lateralesquerdoDataGridViewTextBoxColumn.Name = "lateralesquerdoDataGridViewTextBoxColumn";
            // 
            // goleiroDataGridViewTextBoxColumn
            // 
            this.goleiroDataGridViewTextBoxColumn.DataPropertyName = "goleiro";
            this.goleiroDataGridViewTextBoxColumn.HeaderText = "Goleiro";
            this.goleiroDataGridViewTextBoxColumn.Name = "goleiroDataGridViewTextBoxColumn";
            // 
            // grdPesoContrato
            // 
            this.grdPesoContrato.AllowUserToAddRows = false;
            this.grdPesoContrato.AllowUserToDeleteRows = false;
            this.grdPesoContrato.AutoGenerateColumns = false;
            this.grdPesoContrato.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdPesoContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesoContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.duracaoDataGridViewTextBoxColumn,
            this.umDataGridViewTextBoxColumn,
            this.doisDataGridViewTextBoxColumn,
            this.tresDataGridViewTextBoxColumn,
            this.quatroDataGridViewTextBoxColumn,
            this.cincoDataGridViewTextBoxColumn});
            this.grdPesoContrato.DataSource = this.bsoPesoContrato;
            this.grdPesoContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPesoContrato.Location = new System.Drawing.Point(3, 3);
            this.grdPesoContrato.Name = "grdPesoContrato";
            this.grdPesoContrato.Size = new System.Drawing.Size(702, 404);
            this.grdPesoContrato.TabIndex = 0;
            // 
            // bsoPesoContrato
            // 
            this.bsoPesoContrato.DataMember = "peso_contrato";
            this.bsoPesoContrato.DataSource = this.dtsPesoContrato;
            // 
            // dtsPesoContrato
            // 
            this.dtsPesoContrato.DataSetName = "dtsPesoContrato";
            this.dtsPesoContrato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // duracaoDataGridViewTextBoxColumn
            // 
            this.duracaoDataGridViewTextBoxColumn.DataPropertyName = "duracao";
            this.duracaoDataGridViewTextBoxColumn.HeaderText = "Duração";
            this.duracaoDataGridViewTextBoxColumn.Name = "duracaoDataGridViewTextBoxColumn";
            // 
            // umDataGridViewTextBoxColumn
            // 
            this.umDataGridViewTextBoxColumn.DataPropertyName = "um";
            this.umDataGridViewTextBoxColumn.HeaderText = "Um";
            this.umDataGridViewTextBoxColumn.Name = "umDataGridViewTextBoxColumn";
            // 
            // doisDataGridViewTextBoxColumn
            // 
            this.doisDataGridViewTextBoxColumn.DataPropertyName = "dois";
            this.doisDataGridViewTextBoxColumn.HeaderText = "Dois";
            this.doisDataGridViewTextBoxColumn.Name = "doisDataGridViewTextBoxColumn";
            // 
            // tresDataGridViewTextBoxColumn
            // 
            this.tresDataGridViewTextBoxColumn.DataPropertyName = "tres";
            this.tresDataGridViewTextBoxColumn.HeaderText = "Três";
            this.tresDataGridViewTextBoxColumn.Name = "tresDataGridViewTextBoxColumn";
            // 
            // quatroDataGridViewTextBoxColumn
            // 
            this.quatroDataGridViewTextBoxColumn.DataPropertyName = "quatro";
            this.quatroDataGridViewTextBoxColumn.HeaderText = "Quatro";
            this.quatroDataGridViewTextBoxColumn.Name = "quatroDataGridViewTextBoxColumn";
            // 
            // cincoDataGridViewTextBoxColumn
            // 
            this.cincoDataGridViewTextBoxColumn.DataPropertyName = "cinco";
            this.cincoDataGridViewTextBoxColumn.HeaderText = "Cinco";
            this.cincoDataGridViewTextBoxColumn.Name = "cincoDataGridViewTextBoxColumn";
            // 
            // formPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(716, 502);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "formPesquisa";
            this.Text = "Alteração Pesos";
            this.panelPrincipal.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsoPrincipal)).EndInit();
            this.panelOpcoes.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelBtnAlter.ResumeLayout(false);
            this.panelBtnDelete.ResumeLayout(false);
            this.tbcPesos.ResumeLayout(false);
            this.tbcPesoPosicao.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPesoPosicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPesoPosicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPesoPosicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesoContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPesoContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPesoContrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Panel panelOpcoes;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panelBtnAlter;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel panelBtnDelete;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.BindingSource bsoPrincipal;
        private System.Windows.Forms.Timer timerBarraProgresso;
        private ClasseLogica.Cadastro cadastro1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tbcPesos;
        private System.Windows.Forms.TabPage tbcPesoPosicao;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdPesoPosicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atributoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centroavanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atacanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meiaatacanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meiocampolateralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meiocampocentralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zagueiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateraldireitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateralesquerdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goleiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsoPesoPosicao;
        private dtsPesoPosicao dtsPesoPosicao;
        private System.Windows.Forms.DataGridView grdPesoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quatroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cincoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsoPesoContrato;
        private dtsPesoContrato dtsPesoContrato;
    }
}