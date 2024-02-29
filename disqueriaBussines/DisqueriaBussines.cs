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
				consultar.SetQuery("SELECT D.Id, D.ALTA, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion AS Genero, T.Descripcion AS Edicion, E.Id AS Ies, T.Id AS Itipo FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id AND ALTA = 1;");
				consultar.LaunchReader();

				while (consultar.Lector.Read())
				{
					Disco aux = new Disco();
					aux.Id = (int)consultar.Lector["Id"];
					aux.Titulo = (string)consultar.Lector["Titulo"];
					aux.FechaLanzamiento = (DateTime)consultar.Lector["FechaLanzamiento"];
					aux.CantidadCanciones = (int)consultar.Lector["CantidadCanciones"];
					if (!(consultar.Lector["UrlImagenTapa"] is DBNull))
					{
						aux.UrlTapa = (string)consultar.Lector["UrlImagenTapa"];
					}
					aux.Genero = new Estilo();
					aux.Genero.Descripcion = (string)consultar.Lector["Genero"];
					aux.Genero.Id = (int)consultar.Lector["Ies"];
					aux.Alta = (bool)consultar.Lector["ALTA"];
					aux.Edicion = new TipoEdicion();
					aux.Edicion.Descripcion = (string)consultar.Lector["Edicion"];
					aux.Edicion.Id = (int)consultar.Lector["Itipo"];

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

        public void updateQuery(Disco nuevo)
        {
			AccesoDatos consultar = new AccesoDatos();	
			try
			{
				consultar.SetQuery("UPDATE DISCOS SET Titulo = @titulo, FechaLanzamiento = @fecha, CantidadCanciones = @cantidad, UrlImagenTapa = @tapa, IdEstilo = @idEstilo, IdTipoEdicion = @idTipo WHERE Id = @id;");
				consultar.setParameters("@titulo", nuevo.Titulo);
				consultar.setParameters("@fecha", nuevo.FechaLanzamiento);
				consultar.setParameters("@cantidad", nuevo.CantidadCanciones);
				consultar.setParameters("@tapa", nuevo.UrlTapa);
				consultar.setParameters("@idEstilo", nuevo.Genero.Id);
				consultar.setParameters("@idTipo", nuevo.Edicion.Id);
				consultar.setParameters("id", nuevo.Id);
				consultar.ejecutarAccion();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				consultar.CerrarConexion();
			}
        }

        public void EliminarLogico(int id)
        {
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.SetQuery("UPDATE DISCOS SET ALTA = 0 WHERE ID = @Id;");
				datos.setParameters("@Id", id);
				datos.ejecutarAccion();
			}
			catch (Exception exc)
			{
				throw exc;
			}
			finally
			{
				datos.CerrarConexion();
			}
        }

		public void Eliminar(int id)
		{
            AccesoDatos consulta = new AccesoDatos();
            try
            {
                consulta.SetQuery("DELETE FROM DISCOS WHERE Id = @Id");
				consulta.setParameters("@Id", id);
				consulta.ejecutarAccion();
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                consulta.CerrarConexion();
            }
        }

		public List<Disco> Filtrar(string campo, string criterio, string clave)
		{
			AccesoDatos consultar = new AccesoDatos();
			List<Disco> lista = new List<Disco>();
			try
			{
				string enviarConsulta = "SELECT D.Id, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion AS Genero, T.Descripcion AS Edicion, E.Id AS Ies, T.Id AS Itipo FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id AND ";
				if(campo == "Titulo")
				{
					switch(criterio)
					{
						case "Empieza con":
							enviarConsulta += "D.Titulo LIKE '" + clave + "%'";
							break;
						case "Termina con":
							enviarConsulta += "D.Titulo LIKE '%" + clave + "'";
							break;
						default:
							enviarConsulta += "D.Titulo LIKE '%" + clave + "%'";
							break;
					}
				}
				else if(campo == "Genero")
				{
                    switch (criterio)
                    {
                        case "Empieza con":
                            enviarConsulta += "E.Descripcion LIKE '" + clave + "%'";
                            break;
                        case "Termina con":
                            enviarConsulta += "E.Descripcion LIKE '%" + clave + "'";
                            break;
                        default:
                            enviarConsulta += "E.Descripcion LIKE '%" + clave + "%'";
                            break;
                    }
                }
				else
				{
                    switch (criterio)
                    {
                        case "Empieza con":
                            enviarConsulta += "T.Descripcion LIKE '" + clave + "%'";
                            break;
                        case "Termina con":
                            enviarConsulta += "T.Descripcion LIKE '%" + clave + "'";
                            break;
                        default:
                            enviarConsulta += "T.Descripcion '%" + clave + "%'";
                            break;
                    }
                }

				consultar.SetQuery(enviarConsulta);
				consultar.LaunchReader();
				while(consultar.Lector.Read())
				{
                    Disco aux = new Disco();
                    aux.Id = (int)consultar.Lector["Id"];
                    aux.Titulo = (string)consultar.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)consultar.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)consultar.Lector["CantidadCanciones"];
                    if (!(consultar.Lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.UrlTapa = (string)consultar.Lector["UrlImagenTapa"];
                    }
                    aux.Genero = new Estilo();
                    aux.Genero.Descripcion = (string)consultar.Lector["Genero"];
                    aux.Genero.Id = (int)consultar.Lector["Ies"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Descripcion = (string)consultar.Lector["Edicion"];
                    aux.Edicion.Id = (int)consultar.Lector["Itipo"];

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

        public List<Disco> TraerBajas()
        {

            List<Disco> lista = new List<Disco>();
            AccesoDatos consultar = new AccesoDatos();
            try
            {
                consultar.SetQuery("SELECT D.Id, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion AS Genero, T.Descripcion AS Edicion, E.Id AS Ies, T.Id AS Itipo FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id AND ALTA = 0;");
                consultar.LaunchReader();

                while (consultar.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)consultar.Lector["Id"];
                    aux.Titulo = (string)consultar.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)consultar.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)consultar.Lector["CantidadCanciones"];
                    if (!(consultar.Lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.UrlTapa = (string)consultar.Lector["UrlImagenTapa"];
                    }
                    aux.Genero = new Estilo();
                    aux.Genero.Descripcion = (string)consultar.Lector["Genero"];
                    aux.Genero.Id = (int)consultar.Lector["Ies"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Descripcion = (string)consultar.Lector["Edicion"];
                    aux.Edicion.Id = (int)consultar.Lector["Itipo"];

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
        public void Alta(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetQuery("UPDATE DISCOS SET ALTA = 1 WHERE ID = @Id;");
                datos.setParameters("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
