using System;

public class Telefono
{
    public string Tipo { get; set; } // Ej. Móvil, Fijo, etc.
    public string Numero { get; set; }

    public Telefono(string tipo, string numero)
    {
        Tipo = tipo;
        Numero = numero;
    }

    public void MostrarTelefono()
    {
        Console.WriteLine($"{Tipo}: {Numero}");
    }
}
