using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelaAngel_ExamenProgreso.Models
{
    public class AVela
    {
        [ForeignKey("Celular")]
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
