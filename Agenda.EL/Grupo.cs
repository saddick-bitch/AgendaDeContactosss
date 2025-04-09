using System.Collections.Generic;
using System;

public class Grupo
{
    public string Nombre { get; set; }
    public List<Contacto> Contactos { get; set; }

    public Grupo(string nombre)
    {
        Nombre = nombre;
        Contactos = new List<Contacto>();
    }

    public void AgregarContacto(Contacto contacto)
    {
        Contactos.Add(contacto);
    }

    public void MostrarGrupo()
    {
        Console.WriteLine($"Grupo: {Nombre}");
        foreach (var contacto in Contactos)
        {
            contacto.MostrarContacto();
        }
    }
}
