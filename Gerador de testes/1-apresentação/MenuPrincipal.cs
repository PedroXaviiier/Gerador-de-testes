using Gerador_de_testes._1_apresentação.Materia;
using Gerador_de_testes._1_apresentação.Questões;
using System;
using System.Windows.Forms;

namespace Gerador_de_testes
{
    public partial class MenuPrincipal : Form
    {
        TelaMaterias telaMaterias;
        TelaQuestoes telaQuestoes;


        public MenuPrincipal()
        {
            InitializeComponent();
            
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnTelaQuestoes_Click(object sender, EventArgs e)
        {
            telaQuestoes = new TelaQuestoes();
            telaQuestoes.Show();
        }

        private void BtnTelaMaterias_Click(object sender, EventArgs e)
        {
            telaMaterias = new TelaMaterias();
            telaMaterias.Show();
        }
    }
}
