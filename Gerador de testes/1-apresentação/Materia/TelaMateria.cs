using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_testes._1_apresentação.Materia
{
    public partial class TelaMaterias : Form
    {
        public TelaMaterias()
        {
            InitializeComponent();
        }

        private void TelaMateria_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
