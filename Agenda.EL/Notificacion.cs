using System;

namespace Agenda.EL
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string Tipo { get; set; } // ejemplo: Email, SMS
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
    }
}
