using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VelaAngel_ExamenProgreso.Models
{
    public class AVela
    {
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Range(0, 5)]
        public float Altura { get; set; }
        [DisplayName("Hincha de LDU?")]
        public bool Hincha { get; set; }
        public DateTime Nacimiento { get; set; }
    }
}
