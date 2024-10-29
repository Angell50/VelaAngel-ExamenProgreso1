using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VelaAngel_ExamenProgreso.Models;

namespace VelaAngel_ExamenProgreso.Data
{
    public class VelaAngel_ExamenProgresoContext : DbContext
    {
        public VelaAngel_ExamenProgresoContext (DbContextOptions<VelaAngel_ExamenProgresoContext> options)
            : base(options)
        {
        }

        public DbSet<VelaAngel_ExamenProgreso.Models.AVela> AVela { get; set; } = default!;
        public DbSet<VelaAngel_ExamenProgreso.Models.Celular> Celular { get; set; } = default!;
    }
}
