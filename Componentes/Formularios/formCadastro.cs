﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibilioteca;
using CamadaNegocioPrincipal;

namespace Componente
{
    public partial class formCadastro : Form
    {

        #region [Attributes]

        /// <summary>
        /// Define o modo de navegação
        /// </summary>
        private eNumeradoTipoNavegacao modeNavigation = eNumeradoTipoNavegacao.navigation;


        #endregion End [Attributes]

        #region [Properties]

        [Category("NossosComponentes"), Description("Classe para gravar os dados no banco")]
        public LogicaPrincipal classeDados { get; set; }

        /// <summary>
        /// Define o modo de navegação do formulário
        /// </summary>
        public eNumeradoTipoNavegacao ModoAcessoForm 
        {
            get { return modeNavigation; }
            set { modeNavigation = value; }
        }

        /// <summary>
        /// Lista com componentes a serem atualizados
        /// </summary>
        public Control[] ListaComponentes { get; set; }

        #endregion End [Properties]

        #region [Constructors]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public formCadastro()
        {
            InitializeComponent();
            this.AtualizarBotoes();
            this.AtualizarUsuario();
        }

        #endregion End [Constructors]

        #region [Events]

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.modeNavigation = eNumeradoTipoNavegacao.inclusion;
            this.AtualizarBotoes();
            this.Add();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.timerBarraProgresso.Enabled = true;
            this.modeNavigation = eNumeradoTipoNavegacao.navigation;
            this.AtualizarBotoes();
            this.Save();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }

        private void timerBarraProgresso_Tick(object sender, EventArgs e)
        {
            this.AtualizarBarraProgresso();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Alter();
        }

        #endregion End [Events]

        #region [Methods]

        /// <summary>
        /// Método que pode ser sobrecarregado para salvar as alterações
        /// </summary>
        public virtual void Save()
        {
            bsoPrincipal.EndEdit();
            classeDados.BeginTransaction();
            //classeDados.ExecuteUpdate( ( DataSet ) bsoPrincipal.DataSource );
            Propriedades.oMetodos.ExecutarAtualizacaoBanco( ( DataSet ) bsoPrincipal.DataSource, classeDados );
            modeNavigation = eNumeradoTipoNavegacao.navigation;
            this.AtualizarBotoes();
            this.AtualizarComponentes();
            tabPrincipal.TabPages.Remove(tabPageCadastro);
            tabPrincipal.TabPages.Add(tabPagePesquisa);
            tabPrincipal.TabPages.Add(tabPageCadastro);
            tabPrincipal.SelectedTab = tabPageCadastro;
            ((DataSet)bsoPrincipal.DataSource).Clear();
        }

        /// <summary>
        /// Metódo que pode ser sobrecarregado para adicionar um novo registro
        /// </summary>
        public virtual void Add()
        {
            modeNavigation = eNumeradoTipoNavegacao.inclusion;
            tabPrincipal.TabPages.Remove(tabPagePesquisa);
            bsoPrincipal.AddNew();
            this.AtualizarBotoes();
            this.AtualizarComponentes();
            Propriedades.ContadorBarraProgresso = 0;
            this.AtualizarBarraProgresso();
            this.progressBar.ResetText();
        }

        public virtual void Cancel()
        {
            if (modeNavigation == eNumeradoTipoNavegacao.inclusion)
            {
                if (MessageBox.Show("Deseja cancelar a inclusão", "teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bsoPrincipal.CancelEdit();
                    modeNavigation = eNumeradoTipoNavegacao.navigation;
                    this.AtualizarBotoes();
                    this.AtualizarComponentes();
                    tabPrincipal.TabPages.Add(tabPagePesquisa);
                    tabPrincipal.SelectedTab = tabPagePesquisa;
                    this.timerBarraProgresso.Enabled = false;
                    Propriedades.ContadorBarraProgresso = 0;
                }
            }

        }

        /// <summary>
        /// Atualiza os botões de acordo com o tipo da navegação
        /// </summary>
        private void AtualizarBotoes()
        {
            if (modeNavigation == eNumeradoTipoNavegacao.navigation && bsoPrincipal.Count == 0)
            {
                btn_add.Enabled = true;
                btn_Cancel.Enabled = false;
                btn_edit.Enabled = true; ;
                btn_save.Enabled = false;
            }
            else if (modeNavigation == eNumeradoTipoNavegacao.navigation && bsoPrincipal.Count > 0)
            {
                btn_add.Enabled = true;
                btn_Cancel.Enabled = false;
                btn_save.Enabled = false;
                btn_edit.Enabled = true;
            }
            else if (modeNavigation == eNumeradoTipoNavegacao.inclusion )
            {
                btn_add.Enabled = false;
                btn_save.Enabled = true;
                btn_Cancel.Enabled = true;
                btn_edit.Enabled = false;
            }
            else if (modeNavigation == eNumeradoTipoNavegacao.change)
            {
                DataRowView drwBso = (DataRowView)bsoPrincipal.Current;

                if (bsoPrincipal.Count > 0 && Convert.ToInt32(drwBso["id"]) > 0)
                {
                    btn_add.Enabled = false;
                    btn_save.Enabled = true;
                    btn_Cancel.Enabled = true;
                    btn_edit.Enabled = false;
                }
                else
                {
                    btn_add.Enabled = true;
                    btn_save.Enabled = false;
                    btn_Cancel.Enabled = false;
                    btn_edit.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Atualiza os componentes de acordo com o tipo de navegação do formulário
        /// </summary>
        public virtual void AtualizarComponentes()
        {
            for (int i = 0; i < ListaComponentes.Length; i++)
            {
                if (modeNavigation == eNumeradoTipoNavegacao.navigation)
                    ListaComponentes[i].Enabled = false;
                else if (modeNavigation == eNumeradoTipoNavegacao.change || modeNavigation == eNumeradoTipoNavegacao.inclusion)
                    ListaComponentes[i].Enabled = true;
            }
        }

        /// <summary>
        /// Atualiza o label com o nome do usuário
        /// </summary>
        private void AtualizarUsuario()
        {
            labelUser.Text = Propriedades.NomeUsuario;
        }

        /// <summary>
        /// Atualiza a barra de progresso durante a gravação
        /// </summary>
        private void AtualizarBarraProgresso()
        {
            this.progressBar.Increment(Propriedades.ContadorBarraProgresso);
        }

        public virtual void Alter()
        {
            this.modeNavigation = eNumeradoTipoNavegacao.change;
            this.AtualizarBotoes();
            this.AtualizarComponentes();
            tabPrincipal.TabPages.Remove(tabPagePesquisa);
        }
        
        #endregion End [Methods]
    }
}
