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
            Inicio formInicio = new Inicio();
            formInicio.Show();
            formInicio.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                TipoDeOnda tipo1, tipo2;

                tipo1 = (comboBoxTipo1.Text == "Seno") ? TipoDeOnda.SENO : TipoDeOnda.COSENO;
                tipo2 = (comboBoxTipo2.Text == "Seno") ? TipoDeOnda.SENO : TipoDeOnda.COSENO;

                List<string> textos = new List<string> {
                    textBoxAmplitud1.Text,
                    textBoxFrecuencia1.Text,
                    textBoxFase1.Text,
                    textBoxAmplitud2.Text,
                    textBoxFrecuencia2.Text,
                    textBoxFase2.Text};

                if(textos.Any(texto => texto.Contains(".")))
                {
                    throw new InvalidOperationException();
                }
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

                string tipoResultado = Convert.ToString(ondaResultado.Tipo);

                if (tipoResultado == "SENO")
                {
                    //Llena los campos de arriba con SENO
                    textBoxAmplitud3.Text = Convert.ToString(ondaResultado.Amplitud);
                    textBoxFrecuencia3.Text = Convert.ToString(ondaResultado.Frecuencia);
                    textBoxFase3.Text = Convert.ToString(ondaResultado.FaseInicial);
                    textBoxTipo3.Text = "Seno";

                    //Llena los campos de abajo con COSENO
                    textBoxAmplitudCos.Text = Convert.ToString(ondaResultado.Amplitud);
                    textFrecuenciaCos.Text = Convert.ToString(ondaResultado.Frecuencia);
                    textFaseCos.Text = Convert.ToString(ondaResultado.FaseInicial + Math.PI / 2); //cos(x) = sen(wx + pi/2)
                    textBoxTipoCos.Text = "Coseno";

                }
                else
                {
                    //Llena los campos de arriba con SENO
                    textBoxAmplitud3.Text = Convert.ToString(ondaResultado.Amplitud);
                    textBoxFrecuencia3.Text = Convert.ToString(ondaResultado.Frecuencia);
                    textBoxFase3.Text = Convert.ToString(ondaResultado.FaseInicial - Math.PI / 2); //sen(x) = cos(wx - pi/2)
                    textBoxTipo3.Text = "Seno";

                    //Llena los campos de abajo con COSENO
                    textBoxAmplitudCos.Text = Convert.ToString(ondaResultado.Amplitud);
                    textFrecuenciaCos.Text = Convert.ToString(ondaResultado.Frecuencia);
                    textFaseCos.Text = Convert.ToString(ondaResultado.FaseInicial);
                    textBoxTipoCos.Text = "Coseno";
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("El caracter que indica los decimales es ','\nPor favor no usar '.'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Las funciones no pueden sumarse utlizando fasores dado que sus frecuencias son diferentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
