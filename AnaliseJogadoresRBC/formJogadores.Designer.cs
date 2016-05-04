namespace AnaliseJogadoresRBC
{
    partial class formJogadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJogadores));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.bsoPrincipal = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCadastro1 = new AnaliseJogadoresRBC.dtsCadastro();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDribles = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboContrato = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLesao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDefesas = new System.Windows.Forms.TextBox();
            this.grpPe = new System.Windows.Forms.GroupBox();
            this.radEsquerdo = new System.Windows.Forms.RadioButton();
            this.radDireito = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesarmes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCartoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssistencias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGols = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.cboPosicao = new System.Windows.Forms.ComboBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtJogadores = new System.Windows.Forms.TextBox();
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.panelBtnAlter = new System.Windows.Forms.Panel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panelBtnDelete = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerBarraProgresso = new System.Windows.Forms.Timer(this.components);
            this.cadastro1 = new ClasseLogica.Cadastro();
            this.panelPrincipal.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCadastro1)).BeginInit();
            this.grpPe.SuspendLayout();
            this.panelOpcoes.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBtnAlter.SuspendLayout();
            this.panelBtnDelete.SuspendLayout();
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
            this.pnlDados.Controls.Add(this.tabPrincipal);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(0, 0);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(716, 436);
            this.pnlDados.TabIndex = 1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPageCadastro);
            this.tabPrincipal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(716, 436);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCadastro.Controls.Add(this.txtIdade);
            this.tabPageCadastro.Controls.Add(this.label13);
            this.tabPageCadastro.Controls.Add(this.txtDribles);
            this.tabPageCadastro.Controls.Add(this.label12);
            this.tabPageCadastro.Controls.Add(this.label11);
            this.tabPageCadastro.Controls.Add(this.cboContrato);
            this.tabPageCadastro.Controls.Add(this.label10);
            this.tabPageCadastro.Controls.Add(this.label9);
            this.tabPageCadastro.Controls.Add(this.label8);
            this.tabPageCadastro.Controls.Add(this.cboLesao);
            this.tabPageCadastro.Controls.Add(this.label7);
            this.tabPageCadastro.Controls.Add(this.txtDefesas);
            this.tabPageCadastro.Controls.Add(this.grpPe);
            this.tabPageCadastro.Controls.Add(this.label6);
            this.tabPageCadastro.Controls.Add(this.txtDesarmes);
            this.tabPageCadastro.Controls.Add(this.label5);
            this.tabPageCadastro.Controls.Add(this.txtCartoes);
            this.tabPageCadastro.Controls.Add(this.label4);
            this.tabPageCadastro.Controls.Add(this.txtAssistencias);
            this.tabPageCadastro.Controls.Add(this.label3);
            this.tabPageCadastro.Controls.Add(this.txtGols);
            this.tabPageCadastro.Controls.Add(this.label2);
            this.tabPageCadastro.Controls.Add(this.txtPeso);
            this.tabPageCadastro.Controls.Add(this.label1);
            this.tabPageCadastro.Controls.Add(this.txtAltura);
            this.tabPageCadastro.Controls.Add(this.lblPosicao);
            this.tabPageCadastro.Controls.Add(this.cboPosicao);
            this.tabPageCadastro.Controls.Add(this.lblSalario);
            this.tabPageCadastro.Controls.Add(this.txtSalario);
            this.tabPageCadastro.Controls.Add(this.lblIdade);
            this.tabPageCadastro.Controls.Add(this.lblNome);
            this.tabPageCadastro.Controls.Add(this.txtCodigo);
            this.tabPageCadastro.Controls.Add(this.lblCodigo);
            this.tabPageCadastro.Controls.Add(this.txtJogadores);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 28);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(708, 404);
            this.tabPageCadastro.TabIndex = 2;
            this.tabPageCadastro.Text = "Cadastro";
            // 
            // txtIdade
            // 
            this.txtIdade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "idade", true));
            this.txtIdade.Location = new System.Drawing.Point(9, 128);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 26);
            this.txtIdade.TabIndex = 5;
            this.txtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdade_KeyPress);
            // 
            // bsoPrincipal
            // 
            this.bsoPrincipal.DataMember = "jogadores";
            this.bsoPrincipal.DataSource = this.dtsCadastro1;
            // 
            // dtsCadastro1
            // 
            this.dtsCadastro1.DataSetName = "dtsCadastro";
            this.dtsCadastro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(388, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 19);
            this.label13.TabIndex = 30;
            this.label13.Text = "Dribles";
            // 
            // txtDribles
            // 
            this.txtDribles.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "dribles", true));
            this.txtDribles.Location = new System.Drawing.Point(392, 235);
            this.txtDribles.Name = "txtDribles";
            this.txtDribles.Size = new System.Drawing.Size(100, 26);
            this.txtDribles.TabIndex = 31;
            this.txtDribles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDribles_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "m";
            // 
            // cboContrato
            // 
            this.cboContrato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "contrato_anos", true));
            this.cboContrato.FormattingEnabled = true;
            this.cboContrato.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboContrato.Location = new System.Drawing.Point(249, 127);
            this.cboContrato.Name = "cboContrato";
            this.cboContrato.Size = new System.Drawing.Size(188, 27);
            this.cboContrato.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "mil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Contrato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Lesão";
            // 
            // cboLesao
            // 
            this.cboLesao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "lesao", true));
            this.cboLesao.FormattingEnabled = true;
            this.cboLesao.Items.AddRange(new object[] {
            "Raramente",
            "Dificilmente",
            "Baixo",
            "Medio",
            "Alto",
            "Constantemente"});
            this.cboLesao.Location = new System.Drawing.Point(498, 234);
            this.cboLesao.Name = "cboLesao";
            this.cboLesao.Size = new System.Drawing.Size(202, 27);
            this.cboLesao.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Defesas";
            // 
            // txtDefesas
            // 
            this.txtDefesas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "defesas", true));
            this.txtDefesas.Location = new System.Drawing.Point(286, 234);
            this.txtDefesas.Name = "txtDefesas";
            this.txtDefesas.Size = new System.Drawing.Size(100, 26);
            this.txtDefesas.TabIndex = 29;
            this.txtDefesas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDefesas_KeyPress);
            // 
            // grpPe
            // 
            this.grpPe.Controls.Add(this.radEsquerdo);
            this.grpPe.Controls.Add(this.radDireito);
            this.grpPe.Location = new System.Drawing.Point(8, 210);
            this.grpPe.Name = "grpPe";
            this.grpPe.Size = new System.Drawing.Size(166, 53);
            this.grpPe.TabIndex = 25;
            this.grpPe.TabStop = false;
            this.grpPe.Text = "Pé preferencial";
            // 
            // radEsquerdo
            // 
            this.radEsquerdo.AutoSize = true;
            this.radEsquerdo.Location = new System.Drawing.Point(80, 25);
            this.radEsquerdo.Name = "radEsquerdo";
            this.radEsquerdo.Size = new System.Drawing.Size(85, 23);
            this.radEsquerdo.TabIndex = 1;
            this.radEsquerdo.TabStop = true;
            this.radEsquerdo.Text = "Esquerdo";
            this.radEsquerdo.UseVisualStyleBackColor = true;
            this.radEsquerdo.CheckedChanged += new System.EventHandler(this.radEsquerdo_CheckedChanged);
            // 
            // radDireito
            // 
            this.radDireito.AutoSize = true;
            this.radDireito.Location = new System.Drawing.Point(6, 25);
            this.radDireito.Name = "radDireito";
            this.radDireito.Size = new System.Drawing.Size(68, 23);
            this.radDireito.TabIndex = 0;
            this.radDireito.TabStop = true;
            this.radDireito.Text = "Direito";
            this.radDireito.UseVisualStyleBackColor = true;
            this.radDireito.CheckedChanged += new System.EventHandler(this.radDireito_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Desarmes";
            // 
            // txtDesarmes
            // 
            this.txtDesarmes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "desarmes", true));
            this.txtDesarmes.Location = new System.Drawing.Point(180, 235);
            this.txtDesarmes.Name = "txtDesarmes";
            this.txtDesarmes.Size = new System.Drawing.Size(100, 26);
            this.txtDesarmes.TabIndex = 27;
            this.txtDesarmes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesarmes_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cartões/Temporada";
            // 
            // txtCartoes
            // 
            this.txtCartoes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "cartoes_amarelo_temporada", true));
            this.txtCartoes.Location = new System.Drawing.Point(544, 178);
            this.txtCartoes.Name = "txtCartoes";
            this.txtCartoes.Size = new System.Drawing.Size(156, 26);
            this.txtCartoes.TabIndex = 24;
            this.txtCartoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartoes_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Assitências/Temporada";
            // 
            // txtAssistencias
            // 
            this.txtAssistencias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "assistencias_temporada", true));
            this.txtAssistencias.Location = new System.Drawing.Point(402, 178);
            this.txtAssistencias.Name = "txtAssistencias";
            this.txtAssistencias.Size = new System.Drawing.Size(136, 26);
            this.txtAssistencias.TabIndex = 22;
            this.txtAssistencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAssistencias_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gols/Temporada";
            // 
            // txtGols
            // 
            this.txtGols.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "gols_temporada", true));
            this.txtGols.Location = new System.Drawing.Point(277, 178);
            this.txtGols.Name = "txtGols";
            this.txtGols.Size = new System.Drawing.Size(119, 26);
            this.txtGols.TabIndex = 20;
            this.txtGols.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGols_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "peso", true));
            this.txtPeso.Location = new System.Drawing.Point(137, 178);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 26);
            this.txtPeso.TabIndex = 17;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "altura", true));
            this.txtAltura.Location = new System.Drawing.Point(8, 178);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(101, 26);
            this.txtAltura.TabIndex = 14;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(456, 106);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(57, 19);
            this.lblPosicao.TabIndex = 11;
            this.lblPosicao.Text = "Posição";
            // 
            // cboPosicao
            // 
            this.cboPosicao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "posicao", true));
            this.cboPosicao.FormattingEnabled = true;
            this.cboPosicao.Items.AddRange(new object[] {
            "",
            "Centroavante",
            "Atacante",
            "Meia Atacante",
            "Meio Campo Lateral",
            "Meio Campo Central",
            "Volante",
            "Zagueiro",
            "Lateral Direito",
            "Lateral Esquerdo",
            "Goleiro"});
            this.cboPosicao.Location = new System.Drawing.Point(443, 128);
            this.cboPosicao.Name = "cboPosicao";
            this.cboPosicao.Size = new System.Drawing.Size(257, 27);
            this.cboPosicao.TabIndex = 12;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(111, 105);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(51, 19);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "salario", true));
            this.txtSalario.Location = new System.Drawing.Point(115, 128);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 26);
            this.txtSalario.TabIndex = 7;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(8, 105);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(44, 19);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 19);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "id", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(8, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(101, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 3);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtJogadores
            // 
            this.txtJogadores.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "nome", true));
            this.txtJogadores.Location = new System.Drawing.Point(8, 76);
            this.txtJogadores.MaxLength = 100;
            this.txtJogadores.Name = "txtJogadores";
            this.txtJogadores.Size = new System.Drawing.Size(692, 26);
            this.txtJogadores.TabIndex = 3;
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
            this.btn_add.ImageKey = "add_file_filled_32px.png";
            this.btn_add.ImageList = this.imageList1;
            this.btn_add.Location = new System.Drawing.Point(5, 9);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 30);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Incluir";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add_file_filled_32px.png");
            this.imageList1.Images.SetKeyName(1, "edit_file_32px.png");
            this.imageList1.Images.SetKeyName(2, "save_32px.png");
            this.imageList1.Images.SetKeyName(3, "cancel_32px.png");
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
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btn_Cancel.Text = "Canc.";
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            // formJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(716, 502);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "formJogadores";
            this.Text = "Sistema de Cadastro";
            this.panelPrincipal.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCadastro1)).EndInit();
            this.grpPe.ResumeLayout(false);
            this.grpPe.PerformLayout();
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
        public System.Windows.Forms.TabControl tabPrincipal;
        public System.Windows.Forms.TabPage tabPageCadastro;
        public System.Windows.Forms.BindingSource bsoPrincipal;
        private System.Windows.Forms.Timer timerBarraProgresso;
        private dtsCadastro dtsCadastro1;
        private ClasseLogica.Cadastro cadastro1;
        private System.Windows.Forms.TextBox txtJogadores;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.ComboBox cboPosicao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDribles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboContrato;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboLesao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDefesas;
        private System.Windows.Forms.GroupBox grpPe;
        private System.Windows.Forms.RadioButton radEsquerdo;
        private System.Windows.Forms.RadioButton radDireito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesarmes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCartoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAssistencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGols;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtIdade;
    }
}