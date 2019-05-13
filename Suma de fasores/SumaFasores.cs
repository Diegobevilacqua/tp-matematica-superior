using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOM.Suma_de_fasores
{
    public partial class SumaFasores : Form
    {
        private Inicio Inicio;
        public SumaFasores(Inicio inicio)
        {
            InitializeComponent();
            Inicio = inicio;
        }

        private void SumaFasores_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            Inicio.Show();
            Close();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
