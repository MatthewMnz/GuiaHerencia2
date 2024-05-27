{
    Vehiculo miCoche = new Coche();
    miCoche.RealizarMantenimiento();
    Console.WriteLine("Costo del mantenimiento del coche: $" + miCoche.ObtenerCostoMantenimiento());
    Console.WriteLine("Tiempo de mantenimiento del coche: " + miCoche.CalcularTiempoMantenimiento());

    Vehiculo miMoto = new Moto();
    miMoto.RealizarMantenimiento();
    Console.WriteLine("Costo del mantenimiento de la moto: $" + miMoto.ObtenerCostoMantenimiento());
    Console.WriteLine("Tiempo de mantenimiento de la moto: " + miMoto.CalcularTiempoMantenimiento());

    miCoche.Lavar();

    Coche miCocheReal = new Coche();
    miCocheReal.Lavar();

    Servicio.servicioAceite = new CambioAceite();
    Servicio.servicioAceite.RealizarServicio();
    Console.WriteLine("Costo del canbio de aceite: $" + Servicio.servicioAceite.CalcularCosto());

    Servicio.servicioFrenos = new ReparacionFrenos();
    Servicio.servicioFrenos.RealizarServicio();
    Console.WriteLine("Costo de la reparacion de frenos: $" + Servicio.servicioFrenos.CalcularCosto());
}
