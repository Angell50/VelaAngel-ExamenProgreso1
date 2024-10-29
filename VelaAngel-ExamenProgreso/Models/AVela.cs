using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace VelaAngel_ExamenProgreso.Models
{
    public class AVela
    {

        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        public float Altura { get; set; }
        public bool Hincha { get; set; }
        public DateTime Nacimiento { get; set; }
    }
}
