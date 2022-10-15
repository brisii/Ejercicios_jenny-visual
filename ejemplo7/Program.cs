using System;

namespace ejemplo7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, impares, n, pares, un_numero;
            impares = 0;
            pares = 0;
            Console.Write("Ingresa el valor de n: ");
            n = int.Parse(Console.ReadLine());
            for (i=1; i<=n; i++)
            {
                Console.WriteLine("PROCESO " + i);
                Console.Write("Ingresa el valor de un numero: ");
                un_numero = int.Parse(Console.ReadLine());
                if(un_numero%2==0)
                    pares=pares+1;
                else
                    impares=impares+1;
                Console.WriteLine();
            }
            Console.WriteLine("Valor de impares: " + impares);
            Console.WriteLine("Valor de pares: " + pares);
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
