using Bibilioteca;
using CamadaNegocioPrincipal;
using ClasseLogica;
using Componente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseJogadoresRBC
{
    public partial class formJogadores : Form
    {
        #region [Attributes]

        /// <summary>
        /// Define o modo de navegação
        /// </summary>
        private eNumeradoTipoNavegacao modeNavigation = eNumeradoTipoNavegacao.navigation;


        #endregion End [Attributes]

        #region [Properties]

        [Category( "NossosComponentes" ), Description( "Classe para gravar os dados no banco" )]
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
        public formJogadores()
        {
            InitializeComponent();
            ListaComponentes = new Control[] { txtJogadores, txtIdade, txtSalario, txtAltura, txtAssistencias, txtCartoes, txtDefesas, txtDesarmes, txtDribles, txtGols, txtPeso, cboContrato, cboLesao, cboPosicao, grpPe };
            this.AtualizarBotoes();
            this.AtualizarUsuario();
            this.AtualizarComponentes();
            classeDados = new Cadastro();
        }

        #endregion End [Constructors]

        #region [Events]

        private void btn_add_Click( object sender, EventArgs e )
        {
            this.modeNavigation = eNumeradoTipoNavegacao.inclusion;
            this.AtualizarBotoes();
            this.Add();
        }

        private void btn_save_Click( object sender, EventArgs e )
        {
            this.timerBarraProgresso.Enabled = true;
            this.modeNavigation = eNumeradoTipoNavegacao.navigation;
            this.AtualizarBotoes();
            this.Save();
        }

        private void btn_del_Click( object sender, EventArgs e )
        {
            this.Cancel();
        }

        private void timerBarraProgresso_Tick( object sender, EventArgs e )
        {
            this.AtualizarBarraProgresso();
        }

        private void btn_edit_Click( object sender, EventArgs e )
        {
            this.Alter();
        }

        private void radDireito_CheckedChanged( object sender, EventArgs e )
        {
            if( radDireito.Checked )
                ( ( DataRowView ) bsoPrincipal.Current )["pe_preferencial"] = 1;
        }

        private void radEsquerdo_CheckedChanged( object sender, EventArgs e )
        {
            if( radEsquerdo.Checked )
                ( ( DataRowView ) bsoPrincipal.Current )["pe_preferencial"] = 0;
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
            classeDados.ExecuteUpdate( ( DataSet ) bsoPrincipal.DataSource );
            //Propriedades.oMetodos.ExecutarAtualizacaoBanco( ( DataSet ) bsoPrincipal.DataSource, classeDados );
            modeNavigation = eNumeradoTipoNavegacao.navigation;
            this.AtualizarBotoes();
            this.AtualizarComponentes();
            tabPrincipal.TabPages.Remove( tabPageCadastro );
            //tabPrincipal.TabPages.Add( tabPagePesquisa );
            tabPrincipal.TabPages.Add( tabPageCadastro );
            tabPrincipal.SelectedTab = tabPageCadastro;
            ( ( DataSet ) bsoPrincipal.DataSource ).Clear();
        }

        /// <summary>
        /// Metódo que pode ser sobrecarregado para adicionar um novo registro
        /// </summary>
        public virtual void Add()
        {
            modeNavigation = eNumeradoTipoNavegacao.inclusion;
            //tabPrincipal.TabPages.Remove( tabPagePesquisa );
            bsoPrincipal.AddNew();
            this.AtualizarBotoes();
            this.AtualizarComponentes();
            Propriedades.ContadorBarraProgresso = 0;
            this.AtualizarBarraProgresso();
            this.progressBar.ResetText();
        }

        public virtual void Cancel()
        {
            if( modeNavigation == eNumeradoTipoNavegacao.inclusion )
            {
                if( MessageBox.Show( "Deseja cancelar a inclusão", "teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == System.Windows.Forms.DialogResult.Yes )
                {
                    bsoPrincipal.CancelEdit();
                    modeNavigation = eNumeradoTipoNavegacao.navigation;
                    this.AtualizarBotoes();
                    this.AtualizarComponentes();
                    //tabPrincipal.TabPages.Add( tabPagePesquisa );
                    //tabPrincipal.SelectedTab = tabPagePesquisa;
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
            if( modeNavigation == eNumeradoTipoNavegacao.navigation && bsoPrincipal.Count == 0 )
            {
                btn_add.Enabled = true;
                btn_Cancel.Enabled = false;
                btn_edit.Enabled = true; ;
                btn_save.Enabled = false;
            }
            else if( modeNavigation == eNumeradoTipoNavegacao.navigation && bsoPrincipal.Count > 0 )
            {
                btn_add.Enabled = true;
                btn_Cancel.Enabled = false;
                btn_save.Enabled = false;
                btn_edit.Enabled = true;
            }
            else if( modeNavigation == eNumeradoTipoNavegacao.inclusion )
            {
                btn_add.Enabled = false;
                btn_save.Enabled = true;
                btn_Cancel.Enabled = true;
                btn_edit.Enabled = false;
            }
            else if( modeNavigation == eNumeradoTipoNavegacao.change )
            {
                DataRowView drwBso = ( DataRowView ) bsoPrincipal.Current;

                if( bsoPrincipal.Count > 0 && Convert.ToInt32( drwBso["id"] ) > 0 )
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
            for( int i = 0; i < ListaComponentes.Length; i++ )
            {
                if( modeNavigation == eNumeradoTipoNavegacao.navigation )
                    ListaComponentes[i].Enabled = false;
                else if( modeNavigation == eNumeradoTipoNavegacao.change || modeNavigation == eNumeradoTipoNavegacao.inclusion )
                    ListaComponentes[i].Enabled = true;
            }
        }

        /// <summary>
        /// Atualiza o label com o nome do usuário
        /// </summary>
        private void AtualizarUsuario()
        {
            //labelUser.Text = Propriedades.NomeUsuario;
        }

        /// <summary>
        /// Atualiza a barra de progresso durante a gravação
        /// </summary>
        private void AtualizarBarraProgresso()
        {
            this.progressBar.Increment( Propriedades.ContadorBarraProgresso );
        }

        public virtual void Alter()
        {
            this.modeNavigation = eNumeradoTipoNavegacao.change;
            this.AtualizarBotoes();
            this.AtualizarComponentes();
            //tabPrincipal.TabPages.Remove( tabPagePesquisa );
        }

        private void SomenteNumeros( object sender, KeyPressEventArgs e )
        {
            TextBox txtTemp = ( TextBox ) sender;

            //Verifica se já há uma vígula e se a tecla precionada for uma virgula impede a operação

            if( txtTemp.Text.Contains( ',' ) && e.KeyChar == ( char ) 44 )
            {
                e.Handled = true;
            }

            //Se não for número, vírgula ou backspace trava a tecla

            if( !( Char.IsNumber( e.KeyChar ) ) && !( e.KeyChar == ( char ) 8 ) &&
            !( e.KeyChar == ( char ) 44 ) && !( e.KeyChar == ( char ) 9 ) )
            {
                e.Handled = true;
            }
        }

        #endregion End [Methods]

        private void toolStripStatusLabel1_Click( object sender, EventArgs e )
        {

        }

        private void txtSalario_KeyPress( object sender, KeyPressEventArgs e )
        {
            SomenteNumeros( sender, e );
        }

        private void txtIdade_KeyPress( object sender, KeyPressEventArgs e )
        {
            SomenteNumeros( sender, e );
        }

        private void txtAltura_KeyPress( object sender, KeyPressEventArgs e )
        {
            SomenteNumeros( sender, e );
        }

        private void txtPeso_KeyPress( object sender, KeyPressEventArgs e )
        {
            SomenteNumeros( sender, e );
        }

        private void txtGols_KeyPress( object sender, KeyPressEventArgs e )
        {
            SomenteNumeros( sender, e );
        }

        private void txtAssistencias_KeyPress( object sender, KeyPressEventArgs e )
        {
            SomenteNumeros( sender, e );
        }

        private void txtCartoes_KeyPress( object sender, KeyPressEventArgs e )
        {
            SomenteNumeros( sender, e );
        }

        private void txtDesarmes_KeyPress( object sender, KeyPressEventArgs e )
        {
            SomenteNumeros( sender, e );
        }

        private void txtDefesas_KeyPress( object sender, KeyPressEventArgs e )
        {
            SomenteNumeros( sender, e );
        }

        private void txtDribles_KeyPress( object sender, KeyPressEventArgs e )
        {
            SomenteNumeros( sender, e );
        }
    }
}
