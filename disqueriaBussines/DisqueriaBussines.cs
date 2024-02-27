using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace disqueriaBussines
{
    public class DisqueriaBussines
    {
        public List<Disco> Listar()
        {
			List<Disco> lista = new List<Disco>();	
			AccesoDatos consultar = new AccesoDatos();	
			try
			{
				consultar.SetQuery("SELECT D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion AS Genero, T.Descripcion AS Edicion FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id;");
				consultar.LaunchReader();

				while (consultar.Lector.Read())
				{
					Disco aux = new Disco();
					aux.Titulo = (string)consultar.Lector["Titulo"];
					aux.FechaLanzamiento = (DateTime)consultar.Lector["FechaLanzamiento"];
					aux.CantidadCanciones = (int)consultar.Lector["CantidadCanciones"];
					if (!(consultar.Lector["UrlImagenTapa"] is DBNull))
					{
						aux.UrlTapa = (string)consultar.Lector["UrlImagenTapa"];
					}
					aux.Genero = new Estilo();
					aux.Genero.Descripcion = (string)consultar.Lector["Genero"];
					aux.Edicion = new TipoEdicion();
					aux.Edicion.Descripcion = (string)consultar.Lector["Edicion"];

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

		public void InsertQuery(Disco newDisco)
		{
			AccesoDatos consultar = new AccesoDatos();
			try
			{
				consultar.SetQuery("INSERT INTO DISCOS(Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) VALUES(@titulo, @fecha, @cantidad, @url, @idestilo, @idtipo);");
				consultar.setParameters("@titulo", newDisco.Titulo);
				consultar.setParameters("@fecha", newDisco.FechaLanzamiento);
				consultar.setParameters("@cantidad", newDisco.CantidadCanciones);
				consultar.setParameters("url", newDisco.UrlTapa);
				consultar.setParameters("@idestilo", newDisco.Genero.Id);
				consultar.setParameters("@idtipo", newDisco.Edicion.Id);

				consultar.ejecutarAccion();
			}
			catch (Exception exc)
			{
				throw exc;
			}
		}
    }
}
