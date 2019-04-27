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

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            OperarComplejos formSuma = new OperarComplejos();
            formSuma.Show();
            formSuma.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void LaberRadCom_Click(object sender, EventArgs e)
        {
            PictureRadic_Click(sender, e);
        }

        private void PictureRadic_Click(object sender, EventArgs e)
        {

        }
    }
}
