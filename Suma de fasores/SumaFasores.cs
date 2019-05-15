using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCOM.Operaciones_básicas;

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
            if (textBoxFrecuencia1.Text != textBoxFrecuencia2.Text)
            {
                MessageBox.Show("Las funciones no pueden sumarse utlizando fasores dado que sus frecuencias son diferentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TipoDeOnda tipo1, tipo2;

            tipo1 = (comboBoxTipo1.Text == "SENO") ? TipoDeOnda.SENO : TipoDeOnda.COSENO;
            tipo2 = (comboBoxTipo2.Text == "SENO") ? TipoDeOnda.SENO : TipoDeOnda.COSENO;

            Onda onda1 = new Onda(Convert.ToDouble(textBoxAmplitud1.Text),
                                  Convert.ToDouble(textBoxFrecuencia1.Text),
                                  Convert.ToDouble(textBoxFase1.Text),
                                  tipo1);

            Onda onda2 = new Onda(Convert.ToDouble(textBoxAmplitud2.Text),
                                  Convert.ToDouble(textBoxFrecuencia2.Text),
                                  Convert.ToDouble(textBoxFase2.Text),
                                  tipo2);

            SumaDeFasores suma = new SumaDeFasores(onda1, onda2);
            Onda ondaResultado = suma.SumarOndas();

            textBoxAmplitud3.Text = Convert.ToString(ondaResultado.Amplitud);
            textBoxFrecuencia3.Text = Convert.ToString(ondaResultado.Frecuencia);
            textBoxFase3.Text = Convert.ToString(ondaResultado.FaseInicial);
            textBoxTipo3.Text = Convert.ToString(ondaResultado.Tipo);
        }
    }
}
