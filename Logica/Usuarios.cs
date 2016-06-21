using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Percistencia;
using System.Windows.Forms;
using System.Data;

namespace Logica
{
    public class Usuarios
    {
        private int cedula = 0;
        private string nombres = "";
        private string apellidos = "";
        private string tipoDocumento = "";
        private string telefonoFijo = "";
        private string telefonoCelular = "";
        private string direccion = "";
        private string barrio = "";
        private string correo = "";
        private string estado = "Habilitado";
        private string clave = "";
        private int idEntidad = 0;



        public void registrarUsuario()
        {
            claseConexion con = new claseConexion();
            string cmd = "INSERT usuarios VALUES(" + cedula + ",'" + nombres + "','" + apellidos + "','" + tipoDocumento + "','" + telefonoFijo + "','" + telefonoCelular + "','" + direccion + "','" + barrio + "','" + correo + "','"+estado+"','" + clave + "', null)";
            if (con.ejecutar(cmd))
            {
                MessageBox.Show("Usuario registrado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo registrar");
            }
        }


        public DataSet login()
        {
            claseConexion con = new claseConexion();
            DataSet ds = new DataSet();
            string cmd = "exec ingresar " + cedula + ",'" + clave + "'";
            ds = con.consultar(cmd);
            return ds;
        }

        public int Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string TipoDocumento
        {
            get
            {
                return tipoDocumento;
            }

            set
            {
                tipoDocumento = value;
            }
        }

        public string TelefonoFijo
        {
            get
            {
                return telefonoFijo;
            }

            set
            {
                telefonoFijo = value;
            }
        }

        public string TelefonoCelular
        {
            get
            {
                return telefonoCelular;
            }

            set
            {
                telefonoCelular = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Barrio
        {
            get
            {
                return barrio;
            }

            set
            {
                barrio = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public int IdEntidad
        {
            get
            {
                return idEntidad;
            }

            set
            {
                idEntidad = value;
            }
        }


    }
}
