using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace disqueriaBussines
{
    internal class AccesoDatos
    {
        //crear las propiedades a utilizar en la conexión con la BD
        public SqlConnection conexion;
        public SqlCommand comando;
        public SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        // instancio los objetos | conecto a la base de datos
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
            comando = new SqlCommand();
        }

        // recibimos la consulta por parametro
        public void SetQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void LaunchReader()
        {
            comando.Connection = conexion;
            try
            {
                // abro la conexion con la DB
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                // abro la conexion con la DB
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void setParameters(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void CerrarConexion()
        {
            if (lector != null)
            {
               lector.Close();
            }
            conexion.Close();
        }
    }
}
