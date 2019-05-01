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

        }


        private void PicturePot_Click(object sender, EventArgs e)
        {

        }
        private void PictureRadic_Click(object sender, EventArgs e)
        {

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
