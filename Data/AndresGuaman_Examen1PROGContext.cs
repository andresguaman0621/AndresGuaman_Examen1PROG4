using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AndresGuaman_Examen1PROG.Models;

namespace AndresGuaman_Examen1PROG.Data
{
    public class AndresGuaman_Examen1PROGContext : DbContext
    {
        public AndresGuaman_Examen1PROGContext (DbContextOptions<AndresGuaman_Examen1PROGContext> options)
            : base(options)
        {
        }

        public DbSet<AndresGuaman_Examen1PROG.Models.AndresGuaman_tabla> AndresGuaman_tabla { get; set; } = default!;
    }
}
