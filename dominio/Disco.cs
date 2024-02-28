using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace dominio
{
    public class Disco
    {
        public int Id { get; set; } 
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Cantidad de canciones")]
        public int CantidadCanciones { get; set; }
        // url tapa imagen estaria hidden en la tabla
        public string UrlTapa { get; set; }
        [DisplayName("Género")]
        public Estilo Genero { get; set; }
        [DisplayName("Edición")]
        public TipoEdicion Edicion { get; set; }
    }
}
