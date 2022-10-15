using System;

namespace ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1
            string linea;
            Console.WriteLine("Ingrese un numero que tenga la cantidad de 2 dijitos");
            linea = Console.ReadLine();
            n1 = int.Parse(linea);
            if (n1<10)
                {

                    Console.WriteLine("El numero tiene un digito");
               
                }
            else
                {

                Console.WriteLine("El numero tiene dos digitos");

                }
             
                    Console.ReadKey();
        
        }
    }
}
