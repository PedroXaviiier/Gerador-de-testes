﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_testes._1_apresentação.Questões
{
    public partial class TelaCadastroQuestões : Form
    {
        public TelaCadastroQuestões()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
