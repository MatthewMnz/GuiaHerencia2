public class ReparacionFrenos : Servicio
{
    public override void RealizarServicio()
    {
        Console.WriteLine("Realizando reparacion de frenos.");
    }

    public override double CalcularCosto()
    {
        return 100.0;
    }
}