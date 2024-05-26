public abstract class Servicio
{
    public static Servicio servicioAceite; 
    public static Servicio servicioFrenos;
    public abstract void RealizarServicio();
    public abstract double CalcularCosto();

}