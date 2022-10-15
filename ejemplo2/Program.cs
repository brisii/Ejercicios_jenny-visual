using System;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor del articulo seleccionado:");
            linea = Console.ReadLine();
            PrecioArticulo = float.Parse(linea);
            Console.Write("Ingrese la cantidad de articulos que ha seleccionado:");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);
            ValorVenta = PrecioArticulo * cantidad;
            Console.Write("El precio de la venta es:");
            Console.WriteLine(ValorVenta);
            Console.ReadKey();
        }
    }
}
