using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOM.Operaciones_avanzadas
{
    public partial class OperacionesAvanzadas : Form
    {
        private Inicio Inicio;
        ComplejoPolar[] resultados;
        int resultado;
        public OperacionesAvanzadas(Inicio _inicio)
        {
            InitializeComponent();
            Inicio = _inicio;
        }

        private void OperacionesAvanzadas_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            Inicio.Show();
            Close();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            ComplejoBinomica complejoBinomica;
            ComplejoPolar complejoPolar = null;

            if (comboBoxOperacion.Text == "Raíces primitivas")
            {
                complejoBinomica = Parser.Parsear(textBoxComplejo.Text);

                if (complejoBinomica != null)
                    complejoPolar = complejoBinomica.PasarAPolar();
            }

            if (Parser.EstaEnBinomica(textBoxComplejo.Text) || Parser.EstaEnPolar(textBoxComplejo.Text) || textBoxComplejo.Text == "")
            {
                complejoBinomica = Parser.Parsear(textBoxComplejo.Text);
                if (complejoBinomica != null)
                    complejoPolar = complejoBinomica.PasarAPolar();
            }
            else
            {
                throw new Exception("El formato del texto ingresado no es válido.");
            }

            if (comboBoxOperacion.Text == "Potenciación")
            {
                ComplejoPolar resultado = Potenciacion.Calcular(complejoPolar, Convert.ToDouble(textBoxExpOrden.Text));
                labelResultado.Visible = true;
                textBoxResBin.Text = Parser.BinAStringBin(resultado.PasarABinomica());
                textBoxResPol.Text = Parser.BinAStringPol(resultado.PasarABinomica());
                return;
            }

            if (comboBoxOperacion.Text == "Radicación")
            {
                resultado = 0;
                resultados = Radicacion.Calcular(complejoPolar, Convert.ToDouble(textBoxExpOrden.Text));
                labelResultado.Visible = true;
                buttonAnterior.Visible = true;
                buttonSiguiente.Visible = true;
                textBoxResBin.Text = Parser.BinAStringBin(resultados[resultado].PasarABinomica());
                textBoxResPol.Text = Parser.BinAStringPol(resultados[resultado].PasarABinomica());
                return;
            }
            
            if (comboBoxOperacion.Text == "Raíces primitivas")
            {
                resultado = 0;
                labelExpOrden.Text = "Introduzca el orden de las raíces primitivas";
                resultados = RaicesPrimitivas.Calcular(Convert.ToInt32(textBoxExpOrden.Text));
                labelResultado.Visible = true;
                buttonAnterior.Visible = true;
                buttonSiguiente.Visible = true;
                textBoxResBin.Text = Parser.BinAStringBin(resultados[resultado].PasarABinomica());
                textBoxResPol.Text = Parser.BinAStringPol(resultados[resultado].PasarABinomica());
                return;
            }

            // Lanzar excepciones si faltan campos por llenar 
        }

        private void ButtonAnterior_Click(object sender, EventArgs e)
        {
            if (resultado > 0)
                resultado--;

            textBoxResBin.Text = Parser.BinAStringBin(resultados[resultado].PasarABinomica());
            textBoxResPol.Text = Parser.BinAStringPol(resultados[resultado].PasarABinomica());
        }

        private void ButtonSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                resultado++;

                textBoxResBin.Text = Parser.BinAStringBin(resultados[resultado].PasarABinomica());
                textBoxResPol.Text = Parser.BinAStringPol(resultados[resultado].PasarABinomica());
            }
            catch
            {
                MessageBox.Show("No hay más raíces.");
            }
        }
    }
}
