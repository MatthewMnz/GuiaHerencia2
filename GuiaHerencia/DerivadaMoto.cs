public class Moto : Vehiculo
{
    public override void RealizarMantenimiento()
    {
        Console.WriteLine("Realizando mantenimiento de la moto: Lubricacion de cadena y revision de neumaticos.");
    }

    public override double ObtenerCostoMantenimiento()
    {
        return 100.00;
    }
}