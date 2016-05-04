﻿using System;
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
    public partial class formInicial : Form
    {
        public formInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click( object sender, EventArgs e )
        {
            formJogadores oFormJogadores = new formJogadores();
            oFormJogadores.Show();
        }

        private void btnAnalisar_Click( object sender, EventArgs e )
        {
            formAnalise oFormAnalise = new formAnalise();
            oFormAnalise.Show();
        }

        private void btnPesquisar_Click( object sender, EventArgs e )
        {
            formPesquisa oFormPesquisa = new formPesquisa();
            oFormPesquisa.Show();
        }
    }
}
