using System.Collections.Generic;
using System;

public class Usuario
{
    public string Nombre { get; set; }
    public string UsuarioID { get; set; }
    public List<Agenda> Agendas { get; set; }

    public Usuario(string nombre, string usuarioID)
    {
        Nombre = nombre;
        UsuarioID = usuarioID;
        Agendas = new List<Agenda>();
    }

    public void AgregarAgenda(Agenda agenda)
    {
        Agendas.Add(agenda);
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Usuario: {Nombre}, ID: {UsuarioID}");
        foreach (var agenda in Agendas)
        {
            Console.WriteLine("Agenda:");
            agenda.MostrarAgenda();
        }
    }
}
