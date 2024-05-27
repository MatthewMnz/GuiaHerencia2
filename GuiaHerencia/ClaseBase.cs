public class Vehiculo
{
    public virtual void RealizarMantenimiento()
    {
        Console.WriteLine("Realizando mantenimiento general del vehiculo.");
    }

    public virtual double ObtenerCostoMantenimiento()
    {
        return 50.0; 
    }

    public void Lavar()
    {
        Console.WriteLine("Lavando el vehiculo.");
    }
    
    public virtual double CalcularTiempoMantenimiento()
    {
        return 1.0;
    }
}