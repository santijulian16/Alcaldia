using Percistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Entidades
    {
        private int idEntidad = 0;
        private string nombre = "";
        private string direccion = "";
        private string telefono = "";
        private string tipo = "";



        public void registrarEntidad()
        {
            claseConexion con = new claseConexion();
            string cmd = "INSERT entidades VALUES(" + idEntidad + ",'" + nombre + "','" + direccion + "','" + telefono + "','" + tipo + "')";
            if (con.ejecutar(cmd))
            {
                MessageBox.Show("Entidad registrada correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo registrar la entidad");
            }
        }

        public void actualizarEntidad()
        {
            claseConexion objConexion = new claseConexion();
            if (objConexion.ejecutar("update  entidades set nombre, direccion, telefono, tipo = '" + nombre + "', '" + direccion + "', '" + telefono + "', '" + tipo + "' where idEntidad=" + idEntidad))
            {
                MessageBox.Show("Entidad actualizada con éxito");
            }
            else
            {
                MessageBox.Show("No se pudó actualizar la entidad");
            }


        }


        public DataSet consultarTodos()
        {
            DataSet ds = new DataSet();
            claseConexion objConexion = new claseConexion();
            ds = objConexion.consultar("select * from entidades");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No existen registros");
            }

            return ds;
        }


        public void eliminarEntidad()
        {
            claseConexion objConexion = new claseConexion();
            if (objConexion.ejecutar("delete from entidades where idEntidad =" + idEntidad))
            {
                MessageBox.Show("Entidad eliminada con éxito");
            }
            else
            {
                MessageBox.Show("No se puedo eliminar la entidad");
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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
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

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}
