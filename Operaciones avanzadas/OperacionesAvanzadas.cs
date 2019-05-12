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
        private Inicio inicio;
        public OperacionesAvanzadas(Inicio _inicio)
        {
            InitializeComponent();
            inicio = _inicio;
        }

        private void OperacionesAvanzadas_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            inicio.Show();
            Close();
        }
    }
}
