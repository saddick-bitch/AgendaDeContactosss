using System.Collections.Generic;

public class Agenda
{
    private List<Contacto> contactos;

    public Agenda()
    {
        contactos = new List<Contacto>();
    }

    public void AgregarContacto(Contacto contacto)
    {
        contactos.Add(contacto);
    }

    public void EliminarContacto(string nombre)
    {
        var contacto = contactos.FirstOrDefault(c => c.Nombre == nombre);
        if (contacto != null)
        {
            contactos.Remove(contacto);
        }
    }

    public List<Contacto> ObtenerContactos()
    {
        return contactos;
    }

    public void MostrarAgenda()
    {
        foreach (var contacto in contactos)
        {
            contacto.MostrarContacto();
        }
    }
}
