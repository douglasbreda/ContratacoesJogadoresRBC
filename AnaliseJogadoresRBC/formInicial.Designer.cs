namespace AnaliseJogadoresRBC
{
    partial class formInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInicial));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlAnalisar = new System.Windows.Forms.Panel();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlCadastrar = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPesquisar = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlPrincipal.SuspendLayout();
            this.pnlAnalisar.SuspendLayout();
            this.pnlCadastrar.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.pnlInfo);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(658, 210);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlAnalisar
            // 
            this.pnlAnalisar.Controls.Add(this.btnAnalisar);
            this.pnlAnalisar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAnalisar.Location = new System.Drawing.Point(435, 0);
            this.pnlAnalisar.Name = "pnlAnalisar";
            this.pnlAnalisar.Padding = new System.Windows.Forms.Padding(2);
            this.pnlAnalisar.Size = new System.Drawing.Size(223, 183);
            this.pnlAnalisar.TabIndex = 2;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnalisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisar.ImageKey = "bullish_96px.png";
            this.btnAnalisar.ImageList = this.imageList1;
            this.btnAnalisar.Location = new System.Drawing.Point(2, 2);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(219, 179);
            this.btnAnalisar.TabIndex = 1;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "football_48px.png");
            this.imageList1.Images.SetKeyName(1, "football_96px.png");
            this.imageList1.Images.SetKeyName(2, "search_96px.png");
            this.imageList1.Images.SetKeyName(3, "bullish_96px.png");
            this.imageList1.Images.SetKeyName(4, "weight_filled_100px.png");
            // 
            // pnlCadastrar
            // 
            this.pnlCadastrar.Controls.Add(this.btnCadastrar);
            this.pnlCadastrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadastrar.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastrar.Name = "pnlCadastrar";
            this.pnlCadastrar.Padding = new System.Windows.Forms.Padding(2);
            this.pnlCadastrar.Size = new System.Drawing.Size(225, 183);
            this.pnlCadastrar.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ImageKey = "football_96px.png";
            this.btnCadastrar.ImageList = this.imageList1;
            this.btnCadastrar.Location = new System.Drawing.Point(2, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(221, 179);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfo.Location = new System.Drawing.Point(0, 183);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(658, 27);
            this.pnlInfo.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlPesquisar);
            this.panel1.Controls.Add(this.pnlCadastrar);
            this.panel1.Controls.Add(this.pnlAnalisar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 183);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(71, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "O Banco de Dados fica localizado em um servidor online, portanto o único requisit" +
    "o é uma conexão com a internet";
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Controls.Add(this.btnPesquisar);
            this.pnlPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPesquisar.Location = new System.Drawing.Point(225, 0);
            this.pnlPesquisar.Name = "pnlPesquisar";
            this.pnlPesquisar.Padding = new System.Windows.Forms.Padding(2);
            this.pnlPesquisar.Size = new System.Drawing.Size(210, 183);
            this.pnlPesquisar.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ImageKey = "weight_filled_100px.png";
            this.btnPesquisar.ImageList = this.imageList1;
            this.btnPesquisar.Location = new System.Drawing.Point(2, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(206, 179);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesos";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // formInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 210);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "formInicial";
            this.Text = "Análise de Contratações de Jogadores - RBC";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlAnalisar.ResumeLayout(false);
            this.pnlCadastrar.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlPesquisar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlAnalisar;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label1;
    }
}