using System;

namespace ejemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
             double antiguedad, aumento, sueldo, sueldo_a_pagar;
            Console.Write("Ingresa el tiempo de antiguedad: ");
            antiguedad = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el de sueldo a persivir: ");
            sueldo = double.Parse(Console.ReadLine());
            aumento=0;
            if(sueldo<500&&antiguedad>=10)
                aumento=sueldo*0.2;
            if(sueldo<500&&antiguedad<10)
                aumento=sueldo*0.05;
            sueldo_a_pagar=sueldo+aumento;
            Console.WriteLine("ingrese la cantidad de aumento: " + aumento);
            Console.WriteLine("ingrese la cantidad de sueldo a pagar: " + sueldo_a_pagar);
            Console.WriteLine();
            Console.Write("Presiona una tecla para finalizar . . . ");
            Console.ReadKey();
        }
    }
}
