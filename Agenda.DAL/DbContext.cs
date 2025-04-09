using System.Data.Entity;
using EL;

namespace DAL
{
    public class AgendaDbContext : DbContext
    {
        // Aquí el nombre debe coincidir con la cadena de conexión definida en App.config
        public AgendaDbContext() : base("conexionAgenda")
        {
        }

        public DbSet<Contacto> Contactos { get; set; }  // Asegúrate que "Contacto" existe en EL
    }
}
