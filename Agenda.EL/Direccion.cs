using System;

public class Direccion
{
    public string Calle { get; set; }
    public string Ciudad { get; set; }
    public string CodigoPostal { get; set; }

    public Direccion(string calle, string ciudad, string codigoPostal)
    {
        Calle = calle;
        Ciudad = ciudad;
        CodigoPostal = codigoPostal;
    }

    public void MostrarDireccion()
    {
        Console.WriteLine($"{Calle}, {Ciudad}, {CodigoPostal}");
    }
}
