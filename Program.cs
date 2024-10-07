using System;
using trabajo3;

class Program
{
    static void Main(string[] args)
    {

        string modelo;
        int precio;
        double porcentajeDescuento;
        int dias;


        Console.WriteLine("Ingrese el modelo del vehículo:");
        modelo = Console.ReadLine();


        Console.WriteLine("Ingrese el precio del vehículo :");
        precio = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Ingrese el porcentaje de descuento :");
        porcentajeDescuento = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Ingrese el número de días de la reserva:");
        dias = Convert.ToInt32(Console.ReadLine());


        Vehiculo vehiculo = new Vehiculo(modelo, precio);


        double precioConDescuento = Vehiculo.Descuento.AplicarDescuento(vehiculo.Precio, porcentajeDescuento);


        vehiculo.MostrarInformacion();
        Console.WriteLine($"Precio con descuento: {precioConDescuento}");


        double costoReserva = CalcularReserva.CalcularCosto(vehiculo, dias);
        Console.WriteLine($"Costo total de la reserva por {dias} días: {costoReserva}");
    }
}
