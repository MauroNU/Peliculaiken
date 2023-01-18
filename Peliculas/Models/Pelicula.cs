using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Models
{
    public class Pelicula
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        
        public Pelicula(string nombre, string descripcion) {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
