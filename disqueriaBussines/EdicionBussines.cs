using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace disqueriaBussines
{
    public class EdicionBussines
    {
        public List<TipoEdicion> Listar()
        {
			List<TipoEdicion> lista = new List<TipoEdicion>();
			AccesoDatos consultar = new AccesoDatos();
			try
			{
				consultar.SetQuery("SELECT Id, Descripcion FROM TIPOSEDICION");
				consultar.LaunchReader();
				while(consultar.Lector.Read())
				{
					TipoEdicion aux = new TipoEdicion();
					aux.Id = (int)consultar.Lector["Id"];
					aux.Descripcion = (string)consultar.Lector["Descripcion"];

					lista.Add(aux);
				}
				return lista;
			}
			catch (Exception exc)
			{
				throw exc;
			}
			finally
			{
				consultar.CerrarConexion();
			}
        }
    }
}
