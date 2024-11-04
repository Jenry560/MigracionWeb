

using System.ComponentModel.DataAnnotations;

namespace MigracionWeb.Models
{
    public class Detencion
    {
        public int Id { get; set; }
        [Required]
        public DateTime FechaDetencion { get; set; } = DateTime.Now;
        [Required]
        public string? NombreCompleto { get; set; }
        [Required]
        public string? NumeroPasaporte { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        [Required]
        public double Latitud { get; set; }
        [Required]
        public double Longitud { get; set; }
    }
}