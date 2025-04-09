using DAL;
using EL;
using System.Runtime.Remoting.Contexts;

namespace BLL
{
    public class ContactoBLL
    {
        public void Insertar(Contacto contacto)
        {
            using (var db = new Contexto())
            {
                db.Contactos.Add(contacto);
                db.SaveChanges();
            }
        }
    }
}


