using System;

namespace ejemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Ingresa el valor de x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de y: ");
            y = int.Parse(Console.ReadLine());
            if(x==0&&y==0)
                Console.WriteLine("Origen");
            if(x==0)
                Console.WriteLine("Eje Y");
            if(y==0)
                Console.WriteLine("Eje X");
            if(x>0&&y>0)
                Console.WriteLine("Cuadrante 1");
            if(x<0&&y>0)
                Console.WriteLine("Cuadrante 2");
            if(x<0&&y<0)
                Console.WriteLine("Cuadrante 3");
            if(x>0&&y<0)
                Console.WriteLine("Cuadrante 4");
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
