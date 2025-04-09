using System;

public class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }

    public Contacto(string nombre, string telefono, string direccion, string email)
    {
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
    }

    public void MostrarContacto()
    {
        Console.WriteLine($"Nombre: {Nombre}, Teléfono: {Telefono}, Dirección: {Direccion}, Email: {Email}");
    }
}
