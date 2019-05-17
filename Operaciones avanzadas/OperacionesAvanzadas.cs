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
            Inicio formInicio = new Inicio();
            formInicio.Show();
            formInicio.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            ComplejoBinomica complejoBinomica;
            ComplejoPolar complejoPolar = null;
            try
            {
                if (Parser.EstaEnBinomica(textBoxComplejo.Text) || Parser.EstaEnPolar(textBoxComplejo.Text) || textBoxComplejo.Text == "")
                {
                    complejoBinomica = Parser.Parsear(textBoxComplejo.Text);
                    if (complejoBinomica != null)
                        complejoPolar = complejoBinomica.PasarAPolar();
                }
                else
                {
                    throw new FormatoComplejoInvalidoException();
                }

                if (comboBoxOperacion.Text == "Raíces primitivas")
                {
                    complejoBinomica = Parser.Parsear(textBoxComplejo.Text);

                    if (complejoBinomica != null)
                        complejoPolar = complejoBinomica.PasarAPolar();

                }
                if (comboBoxOperacion.Text == "Potenciación")
                {
                    ComplejoPolar resultado = Potenciacion.Calcular(complejoPolar, Convert.ToInt16(textBoxExpOrden.Text));
                    labelResultado.Visible = true;
                    textBoxResBin.Text = Parser.BinAStringBin(resultado.PasarABinomica());
                    textBoxResPol.Text = Parser.BinAStringPol(resultado.PasarABinomica());
                    return;
                }

                if (comboBoxOperacion.Text == "Radicación")
                {
                    resultado = 0;
                    resultados = Radicacion.Calcular(complejoPolar, Convert.ToInt16(textBoxExpOrden.Text));
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
                    resultados = RaicesPrimitivas.Calcular(Convert.ToInt16(textBoxExpOrden.Text));
                    labelResultado.Visible = true;
                    buttonAnterior.Visible = true;
                    buttonSiguiente.Visible = true;
                    textBoxResBin.Text = Parser.BinAStringBin(resultados[resultado].PasarABinomica());
                    textBoxResPol.Text = Parser.BinAStringPol(resultados[resultado].PasarABinomica());
                    return;
                }

            }
            catch (FormatoComplejoInvalidoException)
            {
                MessageBox.Show("Introduzca los números complejos con el siguiente formato: \n" +
                    "En forma binómica: (a,b) - 'a' parte Real, 'b' parte imaginaria \n" +
                    "En forma polar: [a;b] - 'a' módulo, 'b' argumento",
                    "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato del valor introducido en el campo de 'exponente o raíz' no es válido. " +
                    "Debe ser un número natural.",
    "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("El valor introducido en el campo de 'exponente o raíz' debe ser un número positivo.",
    "Valor fuera del dominio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Los valores intducidos no son válidos",
    "Valor no pertenece al dominio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
