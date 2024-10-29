using Microsoft.AspNetCore.Routing.Constraints;

namespace VelaAngel_ExamenProgreso.Models
{
    public class AVela
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Altura { get; set; }
        public bool Hincha { get; set; }
        public DateTime Nacimiento { get; set; }
    }
}
