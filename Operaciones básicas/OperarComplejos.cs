using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOM.Operaciones_básicas
{
    public partial class OperarComplejos : Form
    {
       
        public OperarComplejos()
        {
            InitializeComponent();
            comboBoxOperacion.SelectedIndex = 0;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void OperarComplejos_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void LabelContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                labelResultado.Visible = true;
                labelResBin.Visible = true;
                labelResPol.Visible = true;
                textResultadoBin.Visible = true;
                textResultadoPol.Visible = true;

                string textoPrimerComplejo = textComplejo1.Text;
                string textoSegundoComplejo = textComplejo2.Text;

                ComplejoBinomica primerComplejo = Parser.parsear(textoPrimerComplejo);
                ComplejoBinomica segundoComplejo = Parser.parsear(textoSegundoComplejo);

                ComplejoBinomica resultadoSuma = OperacionesBasicas.Sumar(primerComplejo, segundoComplejo);
                ComplejoBinomica resultadoResta = OperacionesBasicas.Sumar(primerComplejo, segundoComplejo);

                switch (comboBoxOperacion.SelectedItem.ToString())
                {
                    case "Suma":
                        textResultadoBin.Text = Parser.BinAStringBin(resultadoSuma);
                        textResultadoPol.Text = Parser.BinAStringPol(resultadoSuma);
                        break;

                    case "Resta":
                        textResultadoBin.Text = Parser.BinAStringBin(resultadoResta);
                        textResultadoPol.Text = Parser.BinAStringPol(resultadoResta);
                        break;

                    case "Multiplicación":
                        MessageBox.Show("Multiplicacion seleccionada");
                        break;

                    case "Division":
                        MessageBox.Show("Division seleccionada");
                        break;

                    default:
                        MessageBox.Show("Por favor eliga la operacion a realizar");
                        break;
                }
            }
            catch 
            {
                MessageBox.Show("Introduzca los números con el siguiente formato: \n" +
                    "En forma binómica: (a,b) - 'a' parte Real, 'b' parte imaginaria \n" +
                    "En forma polar: [a;b] - 'a' módulo, 'b' argumento", 
                    "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureAtras_Click(object sender, EventArgs e)
        {
            LabelAtras_Click(sender, e);
        }

        private void LabelAtras_Click(object sender, EventArgs e)
        {
            Inicio formInicio = new Inicio();
            formInicio.Show();
            formInicio.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void PictureContinuar_Click(object sender, EventArgs e)
        {
            LabelContinuar_Click(sender, e);
        }

        private void LabelResPol_Click(object sender, EventArgs e)
        {

        }
    }
}
