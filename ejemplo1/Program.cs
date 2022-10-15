using System;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
             double area, lado, perimetro;
            Console.Write("Ingresa el valor del lado: ");
            lado = double.Parse(Console.ReadLine());
            area=lado*lado;
            perimetro=lado*4;
            Console.WriteLine("Valor de area: " + area);
            Console.WriteLine("Valor de perimetro: " + perimetro);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
