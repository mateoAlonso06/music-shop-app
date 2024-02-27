using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqueriaBussines
{
	public class EstiloBussines
    {
        public List<Estilo> Listar()
        {
			List<Estilo> lista = new List<Estilo>();
			AccesoDatos consultar = new AccesoDatos();
			try
			{
				consultar.SetQuery("SELECT Id, Descripcion FROM ESTILOS");
				consultar.LaunchReader();
				
				while(consultar.Lector.Read())
				{
					Estilo aux = new Estilo();
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
