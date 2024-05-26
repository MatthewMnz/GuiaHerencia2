public class Coche : Vehiculo
{
    public override void RealizarMantenimiento()
    {
        Console.WriteLine("Realizando mantenimiento del coche: Cambio de aceite y revision de frenos");
    }

    public override double ObtenerCostoMantenimiento()
    {
        return 150.00;
    }

    public new void Lavar()
    {
        Console.WriteLine("Lavando el coche con cera y shampoo especial.");
    }
}