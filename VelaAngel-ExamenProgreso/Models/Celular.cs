using System.ComponentModel.DataAnnotations;

namespace VelaAngel_ExamenProgreso.Models
{
    public class Celular
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        public required string Modelo { get; set; }
        [Range(1900, 2024)]
        public required string Year { get; set; }

        public float Precio { get; set; }
    }
}
