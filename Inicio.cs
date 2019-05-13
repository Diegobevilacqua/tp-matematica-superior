using NCOM.Operaciones_básicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCOM.Operaciones_avanzadas;
using NCOM.Suma_de_fasores;

namespace NCOM
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void PictureOpBasicas_Click(object sender, EventArgs e)
        {
            OperarComplejos formSuma = new OperarComplejos();
            formSuma.Show();
            formSuma.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void PictureSFasores_Click(object sender, EventArgs e)
        {
            SumaFasores sumaFasores = new SumaFasores(this);
            sumaFasores.Show();
            Hide();
        }


        private void PicturePot_Click(object sender, EventArgs e)
        {
            OperacionesAvanzadas operacionesAvanzadas = new OperacionesAvanzadas(this);
            operacionesAvanzadas.Show();
            Hide();
        }
        private void PictureRadic_Click(object sender, EventArgs e)
        {
            OperacionesAvanzadas operacionesAvanzadas = new OperacionesAvanzadas(this);
            operacionesAvanzadas.Show();
            Hide();
        }



        private void LaberRad_Click(object sender, EventArgs e)
        {
            PictureRadic_Click(sender, e);
        }

        private void LabelPot_Click(object sender, EventArgs e)
        {
            PicturePot_Click(sender, e);
        }

        private void LabelOpBasicas_Click(object sender, EventArgs e)
        {
            PictureOpBasicas_Click(sender, e);
        }

        private void LabelSFasores_Click(object sender, EventArgs e)
        {
            PictureSFasores_Click(sender, e);
        }
    }
}
