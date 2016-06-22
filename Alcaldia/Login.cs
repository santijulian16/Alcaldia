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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void ingresar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Usuarios usuario = new Usuarios();
            usuario.Cedula = int.Parse(txtDocumento.Text);
            usuario.Clave = txtClave.Text;
            ds = usuario.login();
            if (ds.Tables[0].Rows.Count > 0)
            {
                
                Sesiones.id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                Sesiones.nombre = ds.Tables[0].Rows[0][1].ToString();
                MessageBox.Show("Bienvenido " + Sesiones.nombre);
                menu menu = new menu();
                menu.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Usuario o Clave Incorrectos");
            }
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            registrarse registro = new registrarse();
            registro.ShowDialog();
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            graficas grafica = new graficas();
            grafica.ShowDialog();
        }
    }
}
