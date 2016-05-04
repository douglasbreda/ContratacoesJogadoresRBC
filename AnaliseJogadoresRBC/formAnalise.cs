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
    public partial class formAnalise : Form
    {
        #region [Atributos]

        Analise oAnalise = new Analise();
        Atributos oAtributos = null;

        #endregion Fim [Atributos]

        #region [Construtor]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public formAnalise()
        {
            InitializeComponent();
        }

        #endregion Fim [Construtor]

        #region [Métodos]

        /// <summary>
        /// Bloqueia as letras no campo de números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void IniciarAnalise()
        {
            DataTable dtbAnalise = new DataTable();
            dtbAnalise = oAnalise.BuscarJogadores();
            this.DefinirAtributos();
            oAnalise.TabelaFinal.Clear();

            sttsAnalise.Text = "Analisando dados...";

            dtbAnalise.AsEnumerable().Where( item => item.RowState != DataRowState.Deleted ).ToList().ForEach( analise =>
               {
                   oAnalise.RealizarComparacao( oAtributos, analise );
               } );

            grdResultados.DataSource = oAnalise.TabelaFinal;
            grdResultados.Sort( grdResultados.Columns["PER_FINAL"], ListSortDirection.Descending );
        }

        /// <summary>
        /// Define os atributos de entrada para análise
        /// </summary>
        private void DefinirAtributos()
        {
            oAtributos = new Atributos();
            oAtributos.Idade = Convert.ToInt32( txtIdade.Text );
            oAtributos.Gols = Convert.ToInt32( txtGols.Text );
            oAtributos.Lesao = cboLesao.Text;
            oAtributos.PePreferencial = radDireito.Checked;
            oAtributos.PesoKg = Convert.ToDouble( txtPeso.Text );
            oAtributos.Posicao = cboPosicao.Text;
            oAtributos.Salario = Convert.ToDouble( txtSalario.Text );
            oAtributos.Altura = Convert.ToDouble( txtAltura.Text );
            oAtributos.Assistencias = Convert.ToInt32( txtAssis.Text );
            oAtributos.Cartoes = Convert.ToInt32( txtCartoes.Text );
            oAtributos.Contrato = Convert.ToDouble( cboContrato.Text );
            oAtributos.Defesas = Convert.ToInt32( txtDefesas.Text );
            oAtributos.Desarmes = Convert.ToInt32( txtDesarmes.Text );
            oAtributos.Dribles = Convert.ToInt32( txtDrible.Text );
        }

        #endregion Fim [Métodos]

        #region [Eventos]
        private void btnIniciar_Click( object sender, EventArgs e )
        {
            IniciarAnalise();
        }

        #endregion Fim [Eventos]

        private void grdResultados_ColumnAdded( object sender, DataGridViewColumnEventArgs e )
        {
            if( e.Column.DataPropertyName.Equals( "DES_CALCULO" ) )
                e.Column.HeaderText = "Cálculo";
            else if( e.Column.DataPropertyName.Equals( "PER_FINAL" ) )
                e.Column.HeaderText = "Similaridade (%)";
            else if( e.Column.DataPropertyName.Equals( "nome" ) )
                e.Column.HeaderText = "Nome";
            else if( e.Column.DataPropertyName.Equals( "idade" ) )
                e.Column.HeaderText = "Idade";
            else if( e.Column.DataPropertyName.Equals( "salario" ) )
                e.Column.HeaderText = "Salário";
            else if( e.Column.DataPropertyName.Equals( "altura" ) )
                e.Column.HeaderText = "Altura";
            else if( e.Column.DataPropertyName.Equals( "peso" ) )
                e.Column.HeaderText = "Peso";
            else if( e.Column.DataPropertyName.Equals( "gols_temporada" ) )
                e.Column.HeaderText = "Gols/Temporada";
            else if( e.Column.DataPropertyName.Equals( "assistencias_temporada" ) )
                e.Column.HeaderText = "Assistências/Temporada";
            else if( e.Column.DataPropertyName.Equals( "cartoes_amarelo_temporada" ) )
                e.Column.HeaderText = "Cartões/Temporada";
            else if( e.Column.DataPropertyName.Equals( "desarmes" ) )
                e.Column.HeaderText = "Desarmes";
            else if( e.Column.DataPropertyName.Equals( "defesas" ) )
                e.Column.HeaderText = "Defesas";
            else if( e.Column.DataPropertyName.Equals( "lesao" ) )
                e.Column.HeaderText = "Lesão";
            else if( e.Column.DataPropertyName.Equals( "pe_preferencial" ) )
                e.Column.HeaderText = "Pé-Preferencial";
            else if( e.Column.DataPropertyName.Equals( "dribles" ) )
                e.Column.HeaderText = "Dribles";
            else if( e.Column.DataPropertyName.Equals( "contrato_anos" ) )
                e.Column.HeaderText = "Contrato/Anos";
        }
    }
}
