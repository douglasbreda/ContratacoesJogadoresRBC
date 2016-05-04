using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseJogadoresRBC
{
    public class Atributos
    {
        #region [Atributos]

        private int iIdade = 0;
        private double nSalario = 0;
        private string sPosicao = "";
        private double nAltura = 0;
        private double nPesoKg = 0;
        private int iGols = 0;
        private int iAssistencias = 0;
        private int iCartoes = 0;
        private int iDesarmes = 0;
        private int iDefesas = 0;
        private string sLesao = "";
        private bool bPe = false;
        private int iDribles = 0;
        private double nContrato = 0;

        #endregion Fim [Atributos]

        #region [Propriedades]

        /// <summary>
        /// Idade de jogador
        /// </summary>
        public int Idade
        {
            get { return iIdade; }
            set { iIdade = value; }
        }

        /// <summary>
        /// Salário do jogador
        /// </summary>
        public double Salario
        {
            get { return nSalario; }
            set { nSalario = value; }
        }

        /// <summary>
        /// Posição do jogador
        /// </summary>
        public string Posicao
        {
            get { return sPosicao; }
            set { sPosicao = value; }
        }

        /// <summary>
        /// Altura do jogador
        /// </summary>
        public double Altura
        {
            get { return nAltura; }
            set { nAltura = value; }
        }

        /// <summary>
        /// Peso do jogador
        /// </summary>
        public double PesoKg
        {
            get { return nPesoKg; }
            set { nPesoKg = value; }
        }

        /// <summary>
        /// Número de gols
        /// </summary>
        public int Gols
        {
            get { return iGols; }
            set { iGols = value; }
        }

        /// <summary>
        /// Número de assistências
        /// </summary>
        public int Assistencias
        {
            get { return iAssistencias; }
            set { iAssistencias = value; }
        }

        /// <summary>
        /// Número de cartões
        /// </summary>
        public int Cartoes
        {
            get { return iCartoes; }
            set { iCartoes = value; }
        }

        /// <summary>
        /// Número de desarmes
        /// </summary>
        public int Desarmes
        {
            get { return iDesarmes; }
            set { iDesarmes = value; }
        }

        /// <summary>
        /// Número de defesas
        /// </summary>
        public int Defesas
        {
            get { return iDefesas; }
            set { iDefesas = value; }
        }

        /// <summary>
        /// Probabilidade de lesão
        /// </summary>
        public string Lesao
        {
            get { return sLesao; }
            set { sLesao = value; }
        }

        /// <summary>
        /// Pé preferencial
        /// </summary>
        public bool PePreferencial
        {
            get { return bPe; }
            set { bPe = value; }
        }

        /// <summary>
        /// Número de dribles
        /// </summary>
        public int Dribles
        {
            get { return iDribles; }
            set { iDribles = value; }
        }

        /// <summary>
        /// Duração do contrato
        /// </summary>
        public double Contrato
        {
            get { return nContrato; }
            set { nContrato = value; }
        }

        #endregion Fim [Propriedades]


        public Atributos()
        {

        }


    }
}
