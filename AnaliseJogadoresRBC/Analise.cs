using CamadaNegocioPrincipal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseJogadoresRBC
{
    public class Analise : LogicaPrincipal
    {
        #region [Atributos]

        DataTable dtbPesoPosicao = new DataTable();
        DataTable dtbSimilaridadeLesao = new DataTable();
        DataTable dtbSimilaridadeJogadores = new DataTable();
        DataTable dtbTabelaComparacaoFinal = new DataTable();
        DataTable dtbSimilaridadeContrato = new DataTable();
        StringBuilder sbCalculo = null;
        double nSomadorPeso = 0;

        #endregion Fim [Atributos]

        #region [Propriedades]

        /// <summary>
        /// Retorna a tabela de peso por posição
        /// </summary>
        public DataTable TabelaPesoPosicao
        {
            get { return dtbPesoPosicao; }
        }

        /// <summary>
        /// Retorna a tabela de similaridades entre lesões
        /// </summary>
        public DataTable TabelaSimilaridadeLesao
        {
            get { return dtbSimilaridadeLesao; }
        }

        /// <summary>
        /// Retorna a tabela de similaridades entre jogadores
        /// </summary>
        public DataTable TabelaSimilaridadeJogador
        {
            get { return dtbSimilaridadeJogadores; }
        }

        /// <summary>
        /// Tabela de similaridade de contratos
        /// </summary>
        public DataTable TabelaSimilaridadeContrato
        {
            get { return dtbSimilaridadeContrato; }
        }


        /// <summary>
        /// Tabela de similaridade de contratos
        /// </summary>
        public DataTable TabelaFinal
        {
            get { return dtbTabelaComparacaoFinal; }
        }

        #endregion Fim [Propriedades]

        public Analise()
        {
            IniciarTabelas();
        }

        /// <summary>
        /// Iniciar as tabelas de similaridade
        /// </summary>
        private void IniciarTabelas()
        {
            dtbPesoPosicao = BuscarTabelaPesoPosicao();
            dtbSimilaridadeLesao = BuscarTabelaSimilaridadeLesao();
            dtbSimilaridadeJogadores = BuscarTabelaSimilaridadeJogadores();
            dtbTabelaComparacaoFinal = CriarTabelaComparacao();
            dtbSimilaridadeContrato = BuscarTabelaSimilaridadeContrato();
        }

        /// <summary>
        /// Cria a tabela de comparação para armazenar os resultados finais
        /// </summary>
        /// <returns></returns>
        private DataTable CriarTabelaComparacao()
        {
            DataTable dtbRetorno = new DataTable();

            DataColumn dcCalculo = new DataColumn( "DES_CALCULO", typeof( string ) );
            DataColumn dcPercentual = new DataColumn( "PER_FINAL", typeof( double ) );
            DataColumn dcNome = new DataColumn( "nome", typeof( string ) );
            DataColumn dcIdade = new DataColumn( "idade", typeof( int ) );
            DataColumn dcSalario = new DataColumn( "salario", typeof( string ) );
            DataColumn dcAltura = new DataColumn( "altura", typeof( double ) );
            DataColumn dcPeso = new DataColumn( "peso", typeof( double ) );
            DataColumn dcGols = new DataColumn( "gols_temporada", typeof( int ) );
            DataColumn dcAssistencias = new DataColumn( "assistencias_temporada", typeof( int ) );
            DataColumn dcCartoes = new DataColumn( "cartoes_amarelo_temporada", typeof( int ) );
            DataColumn dcDesarmes = new DataColumn( "desarmes", typeof( int ) );
            DataColumn dcDefesas = new DataColumn( "defesas", typeof( int ) );
            DataColumn dcLesao = new DataColumn( "lesao", typeof( string ) );
            DataColumn dcPePreferencial = new DataColumn( "pe_preferencial", typeof( bool ) );
            DataColumn dcDribles = new DataColumn( "dribles", typeof( double ) );
            DataColumn dcContrato = new DataColumn( "contrato_anos", typeof( int ) );
            DataColumn dcPosicao = new DataColumn( "posicao", typeof( string ) );

            dtbRetorno.Columns.AddRange( new DataColumn[] { dcCalculo, dcPercentual, dcNome, dcIdade, dcSalario,
                                                            dcAltura, dcPeso, dcGols, dcAssistencias, dcCartoes, dcDesarmes,
                                                            dcDefesas, dcLesao, dcPePreferencial, dcDribles, dcContrato, dcPosicao} );

            return dtbRetorno;
        }


        /// <summary>
        /// Retorna todos os jogadores da tabela
        /// </summary>
        /// <returns></returns>
        public DataTable BuscarJogadores()
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.AppendLine( "SELECT * FROM jogadores" );

            return base.ExecutarComando( sbSql );
        }

        /// <summary>
        /// Retorna a tabela de comparação de pesos por posição
        /// </summary>
        /// <returns></returns>
        public DataTable BuscarTabelaPesoPosicao()
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.AppendLine( "SELECT * FROM peso_posicao" );

            return base.ExecutarComando( sbSql );
        }

        /// <summary>
        /// Retorna a tabela de comparação de similaridades entre lesões
        /// </summary>
        /// <returns></returns>
        public DataTable BuscarTabelaSimilaridadeLesao()
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.AppendLine( "SELECT * FROM similaridade_lesao" );

            return base.ExecutarComando( sbSql );
        }

        /// <summary>
        /// Retorna a tabela de comparação de similaridades entre lesões
        /// </summary>
        /// <returns></returns>
        public DataTable BuscarTabelaSimilaridadeJogadores()
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.AppendLine( "SELECT * FROM similaridade_jogadores" );

            return base.ExecutarComando( sbSql );
        }

        /// <summary>
        /// Retorna a similaridade do contrato
        /// </summary>
        /// <returns></returns>
        public DataTable BuscarTabelaSimilaridadeContrato()
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.AppendLine( "SELECT * FROM peso_contrato" );

            return base.ExecutarComando( sbSql );
        }

        /// <summary>
        /// Realiza a comparação
        /// </summary>
        /// <param name="pAtributos"></param>
        /// <param name="pDrwComparacao"></param>
        public void RealizarComparacao( Atributos pAtributos, DataRow pDrwComparacao )
        {
            DataRow drwNovo = dtbTabelaComparacaoFinal.NewRow();

            sbCalculo = new StringBuilder();

            nSomadorPeso = 0;

            double nTotalIdade = CalcularTotalIdade( pAtributos.Idade, Convert.ToInt32( pDrwComparacao["idade"] ), BuscarPesoPosicao( pAtributos.Posicao, "Idade" ) );
            
            double nTotalSalario = CalcularTotalSalario( pAtributos.Salario, Convert.ToInt32( pDrwComparacao["salario"] ), BuscarPesoPosicao( pAtributos.Posicao, "Salário" ) );

            double nTotalPosicao = CalcularTotalPosicao( BuscarSimilaridadePosicao( SelecionarTabelaJogador( pAtributos.Posicao ), SelecionarTabelaJogador( pDrwComparacao["posicao"].ToString() ) ), BuscarPesoPosicao( pAtributos.Posicao, "Posição" ) );

            double nTotalPePreferencial = pAtributos.PePreferencial == ( Convert.ToBoolean( pDrwComparacao["pe_preferencial"] ) ) ? ( 1 * BuscarPesoPosicao( pAtributos.Posicao, "Pé preferencial" ) ) : 0;

            double nTotalContrato = CalcularTotalContrato( BuscarSimilaridadeContrato( pAtributos.Contrato.ToString(), pDrwComparacao["contrato_anos"].ToString()), BuscarPesoPosicao( pAtributos.Posicao, "Contrato/Duração" ) );

            double nTotalAltura = CalcularTotalAltura( pAtributos.Altura, Convert.ToDouble( pDrwComparacao["altura"] ), BuscarPesoPosicao( pAtributos.Posicao, "Altura" ) );

            double nTotalPeso = CalcularTotalPeso( pAtributos.PesoKg, Convert.ToDouble( pDrwComparacao["peso"] ), BuscarPesoPosicao( pAtributos.Posicao, "Peso" ) );

            double nTotalCartoes = CalcularTotalCartoes( pAtributos.Cartoes, Convert.ToDouble( pDrwComparacao["cartoes_amarelo_temporada"] ), BuscarPesoPosicao( pAtributos.Posicao, "Cartões Amarelo/ Temporada" ) );

            double nTotalDesarmes = CalcularTotalDesarmes( pAtributos.Desarmes, Convert.ToDouble( pDrwComparacao["desarmes"] ), BuscarPesoPosicao( pAtributos.Posicao, "Desarmes" ) );

            double nTotalAssistencias = CalcularTotalAssistencias( pAtributos.Assistencias, Convert.ToDouble( pDrwComparacao["assistencias_temporada"] ), BuscarPesoPosicao( pAtributos.Posicao, "Assistências" ) );

            double nTotalDefesas = CalcularTotalDefesas( pAtributos.Desarmes, Convert.ToDouble( pDrwComparacao["defesas"] ), BuscarPesoPosicao( pAtributos.Posicao, "Defesas" ) );

            double nTotalDribles = CalcularTotalDribles( pAtributos.Dribles, Convert.ToDouble( pDrwComparacao["dribles"] ), BuscarPesoPosicao( pAtributos.Posicao, "Dribles" ) );

            double nTotalLesao = CalcularTotalLesao( Convert.ToDouble( BuscarSimilaridadeLesao( pAtributos.Lesao, pDrwComparacao["lesao"].ToString() ) ), BuscarPesoPosicao( pAtributos.Posicao, "Lesão" ) );

            double nTotalGeral = ( ( Math.Round( nTotalIdade + nTotalSalario + nTotalPosicao +
                                 nTotalPePreferencial + nTotalContrato + nTotalAltura +
                                 nTotalPeso + nTotalCartoes + nTotalDesarmes + nTotalAssistencias
                                 + nTotalDefesas + nTotalDribles + nTotalLesao, 2 ) / Math.Round( nSomadorPeso, 2 ) ) * 100 );

            drwNovo["DES_CALCULO"] = sbCalculo;
            drwNovo["PER_FINAL"] = nTotalGeral > 100 ? 100 : nTotalGeral;
            drwNovo["nome"] = pDrwComparacao["nome"];
            drwNovo["idade"] = pDrwComparacao["idade"];
            drwNovo["salario"] = pDrwComparacao["salario"];
            drwNovo["posicao"] = pDrwComparacao["posicao"];
            drwNovo["altura"] = pDrwComparacao["altura"];
            drwNovo["peso"] = pDrwComparacao["peso"];
            drwNovo["gols_temporada"] = pDrwComparacao["gols_temporada"];
            drwNovo["assistencias_temporada"] = pDrwComparacao["assistencias_temporada"];
            drwNovo["cartoes_amarelo_temporada"] = pDrwComparacao["cartoes_amarelo_temporada"]; 
            drwNovo["desarmes"] = pDrwComparacao["desarmes"];
            drwNovo["defesas"] = pDrwComparacao["defesas"];
            drwNovo["lesao"] = pDrwComparacao["lesao"];
            drwNovo["pe_preferencial"] = pDrwComparacao["pe_preferencial"];
            drwNovo["dribles"] = pDrwComparacao["dribles"];
            drwNovo["contrato_anos"] = pDrwComparacao["contrato_anos"];


            dtbTabelaComparacaoFinal.Rows.Add( drwNovo );
        }

        /// <summary>
        /// Busca a similaridade do contrato
        /// </summary>
        /// <returns></returns>
        private double BuscarSimilaridadeContrato(string pDuracaoEntrada, string pDuracaoComparacao)
        {
            string sDuracaoEntrada = BuscarColunaContrato( pDuracaoEntrada );

            string sDuracaoComparacao = BuscarColunaContrato( pDuracaoComparacao );

            return Convert.ToDouble( dtbSimilaridadeContrato.AsEnumerable().Where( item => item["duracao"].Equals( sDuracaoEntrada ) ).FirstOrDefault()[sDuracaoComparacao] );
        }

        private string BuscarColunaContrato(string pDuracao )
        {
            string sRetorno = "";

            switch( pDuracao )
            {
                case "1":
                    sRetorno = "um";
                break;

                case "2":
                    sRetorno = "dois";
                break;

                case "3":
                    sRetorno = "tres";
                break;

                case "4":
                    sRetorno = "quatro";
                break;

                case "5":
                    sRetorno = "cinco";
                break;
            }

            return sRetorno;
        }

        /// <summary>
        /// Calcula o total do contrato de acordo com definições em um peso
        /// </summary>
        /// <param name="pContrato1"></param>
        /// <param name="pContrato2"></param>
        /// <param name="pPeso"></param>
        /// <returns></returns>
        private double CalcularTotalContrato(double pContrato, double pPeso )
        {
            nSomadorPeso += pPeso;

            sbCalculo.Append( " | " + pContrato + "*" + pPeso + "| " );

            return ( pContrato * pPeso );

        }

        /// <summary>
        /// Calcula o total de dribles de acordo com definições em um peso
        /// </summary>
        /// <param name="pLesao1"></param>
        /// <param name="pLesao2"></param>
        /// <param name="pPesoTabela"></param>
        /// <returns></returns>
        private double CalcularTotalLesao(double pValorTabela, double pPesoTabela )
        {
            sbCalculo.Append( " | " + pValorTabela + "*" + pPesoTabela + "| " );

            nSomadorPeso += pPesoTabela;

            return ( pValorTabela * pPesoTabela );
        }

        /// <summary>
        /// Calcula o total de dribles de acordo com definições em um peso
        /// </summary>
        /// <param name="pDribles1"></param>
        /// <param name="pDribles2"></param>
        /// <param name="pPesoTabela"></param>
        /// <returns></returns>
        private double CalcularTotalDribles(double pDribles1, double pDribles2, double pPesoTabela )
        {
            double nPeso = 0;

            double nTotal = Math.Abs( pDribles1 - pDribles2);

            if( nTotal >= 0 && nTotal <= 10 )
                nPeso = 1;
            else if( nTotal > 10 && nTotal <= 15 )
                nPeso = 0.8;
            else if( nTotal > 15 && nTotal <= 20 )
                nPeso = 0.6;
            else if( nTotal > 20 && nTotal <= 25 )
                nPeso = 0.4;
            else if( nTotal > 25 )
                nPeso = 0.2;

            sbCalculo.Append( " | " + nPeso + "*" + pPesoTabela + "| " );

            nSomadorPeso += pPesoTabela;

            return ( nPeso * pPesoTabela );
        }

        /// <summary>
        /// Calcula o total de defesas de acordo com definições em um peso
        /// </summary>
        /// <param name="pDefesas1"></param>
        /// <param name="pDefesas2"></param>
        /// <param name="pPesoTabela"></param>
        /// <returns></returns>
        private double CalcularTotalDefesas(double pDefesas1, double pDefesas2, double pPesoTabela )
        {
            double nPeso = 0;

            double nTotal = Math.Abs( pDefesas1 - pDefesas2 );

            if( nTotal > 0 && nTotal <= 5 )
                nPeso = 1;
            else if( nTotal > 5 && nTotal <= 10 )
                nPeso = 0.8;
            else if( nTotal > 10 && nTotal <= 20 )
                nPeso = 0.6;
            else if( nTotal > 20 && nTotal <= 30 )
                nPeso = 0.4;
            else if( nTotal > 30)
                nPeso = 0.2;

            sbCalculo.Append( " | " + nPeso + "*" + pPesoTabela + "| " );

            nSomadorPeso += pPesoTabela;

            return ( nPeso * pPesoTabela );
        }

        /// <summary>
        /// Calcula o total de desarmes de acordo com definições em um peso
        /// </summary>
        /// <param name="pDesarmes1"></param>
        /// <param name="pDesarmes2"></param>
        /// <param name="pPesoTabela"></param>
        /// <returns></returns>
        private double CalcularTotalDesarmes( double pDesarmes1, double pDesarmes2, double pPesoTabela )
        {
            double nPeso = 0;

            double nTotal = Math.Abs( pDesarmes1 - pDesarmes2 );

            if( nTotal == 0 )
                nPeso = 1;
            else if( nTotal > 0 && nTotal <= 5 )
                nPeso = 0.8;
            else if( nTotal > 5 && nTotal <= 10 )
                nPeso = 0.6;
            else if( nTotal > 10 && nTotal <= 15 )
                nPeso = 0.4;
            else if( nTotal > 15 )
                nPeso = 0.2;

            sbCalculo.Append( " | " + nPeso + "*" + pPesoTabela + "| " );

            nSomadorPeso += pPesoTabela;

            return ( nPeso * pPesoTabela );
        }

        /// <summary>
        /// Calcula o total de cartões de acordo com definições em um peso
        /// </summary>
        /// <param name="pCartoes1"></param>
        /// <param name="pCartoes2"></param>
        /// <param name="pPesoTabela"></param>
        private double CalcularTotalCartoes(double pCartoes1, double pCartoes2, double pPesoTabela )
        {
            double nPeso = 0;

            double nTotal = Math.Abs( pCartoes1 - pCartoes2 );

            if( nTotal == 0 )
                nPeso = 1;
            else if( nTotal > 0 && nTotal <= 5 )
                nPeso = 0.8;
            else if( nTotal > 5 && nTotal <= 10 )
                nPeso = 0.6;
            else if( nTotal > 10 && nTotal <= 15 )
                nPeso = 0.4;
            else if( nTotal > 15 )
                nPeso = 0.2;

            sbCalculo.Append( " | " + nPeso + "*" + pPesoTabela + "| " );

            nSomadorPeso += pPesoTabela;

            return ( nPeso * pPesoTabela );
        }

        /// <summary>
        /// Calcula o total de assistências de acordo com definições em um peso
        /// </summary>
        /// <param name="pAssistencias1"></param>
        /// <param name="pAssistencias2"></param>
        /// <param name="pPesoTabela"></param>
        /// <returns></returns>
        private double CalcularTotalAssistencias(double pAssistencias1, double pAssistencias2, double pPesoTabela )
        {
            double nPeso = 0;

            double nTotal = Math.Abs( pAssistencias1 - pAssistencias2 );

            if( nTotal == 0 )
                nPeso = 1;
            else if( nTotal > 0 && nTotal <= 5 )
                nPeso = 0.8;
            else if( nTotal > 5 && nTotal <= 10 )
                nPeso = 0.6;
            else if( nTotal > 10 && nTotal <= 15 )
                nPeso = 0.4;
            else if( nTotal > 15 )
                nPeso = 0.2;

            sbCalculo.Append( " | " + nPeso + "*" + pPesoTabela + "| " );

            nSomadorPeso += pPesoTabela;

            return ( nPeso * pPesoTabela );
        }

        /// <summary>
        /// Calcula o total de peso de acordo com definições em um peso
        /// </summary>
        /// <param name="pPesoTabela1"></param>
        /// <param name="pPesoTabela2"></param>
        /// <param name="pPesoTabela"></param>
        /// <returns></returns>
        private double CalcularTotalPeso(double pPesoTabela1, double pPesoTabela2, double pPesoTabela )
        {
            double nPeso = 0;

            double nTotal = Math.Abs( pPesoTabela1 - pPesoTabela2 );

            if( nTotal == 0 )
                nPeso = 1;
            else if( nTotal > 0 && nTotal <= 5 )
                nPeso = 0.8;
            else if( nTotal > 5 && nTotal <= 8 )
                nPeso = 0.6;
            else if( nTotal > 8 && nTotal <= 15 )
                nPeso = 0.4;
            else if( nTotal > 15 )
                nPeso = 0.2;

            sbCalculo.Append( " | " + nPeso + "*" + pPesoTabela + "| " );

            nSomadorPeso += pPesoTabela;

            return ( nPeso * pPesoTabela );
        }

        /// <summary>
        /// Calcula o total de altura de acordo com definições em um peso
        /// </summary>
        /// <param name="pAlturaEntrada"></param>
        /// <param name="pTotalComparacao"></param>
        private double CalcularTotalAltura( double pAltura1, double pAltura2, double pPesoTabela )
        {
            double nPeso = 0;

            double nTotal = Math.Abs( pAltura1 - pAltura2 );

            if( nTotal == 0 )
                nPeso = 1;
            else if( nTotal > 0 && nTotal <= 5 )
                nPeso = 0.8;
            else if( nTotal > 5 && nTotal <= 10 )
                nPeso = 0.6;
            else if( nTotal > 10 && nTotal <= 20 )
                nPeso = 0.4;
            else if( nTotal > 20 )
                nPeso = 0.2;

            sbCalculo.Append( " | " + nPeso + "*" + pPesoTabela + "| " );

            nSomadorPeso += pPesoTabela;

            return ( nPeso * pPesoTabela );
            
        }


        /// <summary>
        /// Calcula buscando o peso de acordo com a posição na tabela va
        /// </summary>
        /// <param name="nValorCalculadoTabela"></param>
        /// <param name="nPesoAtributo"></param>
        private double CalcularTotalPosicao( double nValorCalculadoTabela, double nPesoAtributo )
        {
            nSomadorPeso += nPesoAtributo;

            return nValorCalculadoTabela * nPesoAtributo;
        }

        /// <summary>
        /// Faz a busca do peso na tabela similaridade_jogadores
        /// </summary>
        /// <param name="pPosicaoEntrada"></param>
        /// <param name="pPosicaoComparada"></param>
        private double BuscarSimilaridadePosicao( string pPosicaoEntrada, string pPosicaoComparada )
        {
            return Convert.ToDouble( dtbSimilaridadeJogadores.AsEnumerable().Where( item => item["posicao"].Equals( pPosicaoEntrada ) ).FirstOrDefault()[pPosicaoComparada] );
        }

        /// <summary>
        /// Faz a busca do peso na tabela de similaridade de lesão
        /// </summary>
        /// <param name="pLesaoEntrada"></param>
        /// <param name="pLesaoComparada"></param>
        private double BuscarSimilaridadeLesao(string pLesaoEntrada, string pLesaoComparada )
        {
            return Convert.ToDouble( dtbSimilaridadeLesao.AsEnumerable().Where( item => item["lesao"].Equals( pLesaoEntrada ) ).FirstOrDefault()[pLesaoComparada] );
        }

        /// <summary>
        /// Calcula o salário baseado em uma tabela de análise
        /// </summary>
        /// <param name="pSalario1"></param>
        /// <param name="pSalario2"></param>
        /// <param name="pPesoTabela"></param>
        private double CalcularTotalSalario( double pSalario1, double pSalario2, double pPesoTabela )
        {
            double nTotal = Math.Abs( pSalario1 - pSalario2);
            double nPeso = 0;

            if( nTotal <= 1000 )
                nPeso = 1;
            else if( nTotal > 1000 && nTotal <= 3000  )
                nPeso = 0.8;
            else if( nTotal > 3000 && nTotal <= 5000 )
                nPeso = 0.6;
            else if( nTotal > 5000 && nTotal <= 7000 )
                nPeso = 0.5;
            else if( nTotal > 7000 && nTotal <= 10000 )
                nPeso = 0.4;
            else if( nTotal > 10000 && nTotal <= 20000 )
                nPeso = 0.2;
            else if( nTotal > 20000)
                nPeso = 0.1;

            sbCalculo.Append( " | " + nPeso + "*" + pPesoTabela + "| " );

            nSomadorPeso += pPesoTabela;

            return ( nPeso * pPesoTabela );
        }

        /// <summary>
        /// Calcula a idade baseada em uma tabela de análise
        /// </summary>
        /// <param name="pIdade1"></param>
        /// <param name="pIdade2"></param>
        private double CalcularTotalIdade( int pIdade1, int pIdade2, double pPesoTabela )
        {
            double nTotal = Math.Abs( pIdade1 - pIdade2 );
            double nPeso = 0;

            if( nTotal <= 2 )
                nPeso = 1;
            else if( nTotal >= 2 && nTotal <= 4 )
                nPeso = 0.8;
            else if( nTotal >= 4 && nTotal <= 6 )
                nPeso = 0.6;
            else if( nTotal >= 6 && nTotal <= 10 )
                nPeso = 0.4;
            else if( nTotal > 10 )
                nPeso = 0.2;

            sbCalculo.Append( " | " + nPeso + "*" + pPesoTabela + "| " );

            nSomadorPeso += pPesoTabela;

            return ( nPeso * pPesoTabela );
        }

        /// <summary>
        /// Retorna o valor do peso de um atributo
        /// </summary>
        /// <param name="pPosicao"></param>
        /// <param name="pAtributo"></param>
        /// <returns></returns>
        public double BuscarPesoPosicao( string pPosicao, string pAtributo )
        {
            string sColuna = SelecionarTabelaJogador( pPosicao );

            return Convert.ToDouble( dtbPesoPosicao.AsEnumerable().Where( item => item["atributo"].ToString().Trim().Equals( pAtributo.Trim() ) ).FirstOrDefault()[sColuna] );
        }

        /// <summary>
        /// Retorna a coluna de acordo com a posição
        /// </summary>
        /// <param name="pPosicao"></param>
        /// <returns></returns>
        private string SelecionarTabelaJogador(string pPosicao )
        {
            string sNomeColuna = "";
            switch( pPosicao.ToUpper() )
            {
                case "CENTROAVANTE":
                sNomeColuna = "centroavante";
                break;

                case "ATACANTE":
                sNomeColuna = "atacante";
                break;

                case "MEIA ATACANTE":
                sNomeColuna = "meia_atacante";
                break;

                case "MEIO CAMPO LATERAL":
                sNomeColuna = "meio_campo_lateral";
                break;

                case "MEIO CAMPO CENTRAL":
                sNomeColuna = "meio_campo_central";
                break;

                case "VOLANTE":
                sNomeColuna = "volante";
                break;

                case "ZAGUEIRO":
                sNomeColuna = "zagueiro";
                break;

                case "LATERAL DIREITO":
                sNomeColuna = "lateral_direito";
                break;

                case "LATERAL ESQUERDO":
                sNomeColuna = "lateral_esquerdo";
                break;

                case "GOLEIRO":
                sNomeColuna = "goleiro";
                break;
            }

            return sNomeColuna;
        }

    }
}
