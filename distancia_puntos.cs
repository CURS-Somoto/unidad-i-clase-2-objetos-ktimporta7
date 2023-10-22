using System;

class Punto
{
    public decimal X { get; set; }
    public decimal Y { get; set; }

    public Punto(decimal x, decimal y)
    {
        X = x;
        Y = y;
    }

    public double MedirDistancia(Punto puntoDestino)
    {
        double distancia = Math.Sqrt(Math.Pow((double)(puntoDestino.X - this.X), 2) + Math.Pow((double)(puntoDestino.Y - this.Y), 2));
        return distancia;
    }
}

class Program
{
    static void Main()
    {
        Punto puntoOrigen = new Punto(90, 58);
        Punto puntoDestino = new Punto(120, 47);

        double distancia = puntoOrigen.MedirDistancia(puntoDestino);

        Console.WriteLine($"La distancia que hay entre los dos puntos es: {distancia}");
    }
}
