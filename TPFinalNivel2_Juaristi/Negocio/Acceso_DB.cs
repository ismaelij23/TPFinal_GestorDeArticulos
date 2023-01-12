using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class Acceso_DB
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        // Propiedad para poder acceder al lector:
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        // Constructor:
        public Acceso_DB()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            comando = new SqlCommand();
        }

        // Método que realiza la consulta a la DB:
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        // Método que realiza consultas SELECT a la DB:
        public void ejecutarLectura()
        {
            comando.Connection= conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // Método que realiza cambios en los datos de la DB:
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // Método para setear los parametros y agregarlos a la consulta:
        public void setearParametros(string nombre, object value)
        {
            comando.Parameters.AddWithValue(nombre, value);
        }
        
        // Método para cerrar la conexión hacia la DB:
        public void cerrarConexion()
        {
            if(lector != null)
                lector.Close();
            
            conexion.Close();
        }    
    }
}
