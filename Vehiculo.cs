using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo3
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public int Precio { get; set; }

        public Vehiculo(string modelo, int precio)
        {
            Modelo = modelo;
            Precio = precio;
        }

        // Clase interna para gestionar descuentos
        public class Descuento
        {
            public static double AplicarDescuento(double precio, double porcentajeDescuento)
            {
                double descuento = precio * (porcentajeDescuento / 100);
                return precio - descuento;
            }
        }
    }

    // Método de extensión para formatear y mostrar información del vehículo
    public static class VehiculoExtensions
    {
        public static void MostrarInformacion(this Vehiculo vehiculo)
        {
            Console.WriteLine($"Modelo: {vehiculo.Modelo}, Precio: {vehiculo.Precio}");
        }
    }

    // Clase estática para calcular el costo de la reserva
    public static class CalcularReserva
    {
        public static double CalcularCosto(Vehiculo vehiculo, int dias)
        {
            return vehiculo.Precio * dias;
        }
    }
}




