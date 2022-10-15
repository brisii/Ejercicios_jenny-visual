using System;

namespace ejemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
             double porcentaje, preguntas_correctas, total_de_preguntas;
            Console.Write("Ingresa el valor de preguntas correctas: ");
            preguntas_correctas = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de total de preguntas: ");
            total_de_preguntas = double.Parse(Console.ReadLine());
            porcentaje=100.0*preguntas_correctas/total_de_preguntas;
            if(porcentaje>=90)
                Console.WriteLine("Nivel m\u00E1ximo");
            if(porcentaje>=75&&porcentaje<90)
                Console.WriteLine("Nivel medio");
            if(porcentaje>=50&&porcentaje<75)
                Console.WriteLine("Nivel regular");
            if(porcentaje<50)
                Console.WriteLine("Fuera de nivel");
            Console.WriteLine("Valor de porcentaje: " + porcentaje);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
