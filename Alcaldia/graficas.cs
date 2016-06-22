using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alcaldia
{
    public partial class graficas : Form
    {
        public graficas()
        {
            InitializeComponent();
        }

        private void graficas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alcaldiaDataSet1.graficaClificacion' table. You can move, or remove it, as needed.
            this.graficaClificacionTableAdapter.Fill(this.alcaldiaDataSet1.graficaClificacion);
            // TODO: This line of code loads data into the 'alcaldiaDataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.alcaldiaDataSet.usuarios);

        }
    }
}
