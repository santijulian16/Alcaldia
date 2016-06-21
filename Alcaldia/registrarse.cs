using Logica;
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
    public partial class registrarse : Form
    {
        public registrarse()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Cedula = int.Parse(txtCedula.Text);
            usuario.Nombres = txtNombres.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.TipoDocumento = txtTipoDocumento.Text;
            usuario.TelefonoFijo = txtTelefonoFijo.Text;
            usuario.TelefonoCelular = txtTelefonoCelular.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Barrio = txtBarrio.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.Clave = txtClave.Text;
            usuario.registrarUsuario();
        }
    }
}
