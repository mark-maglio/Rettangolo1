using System;

namespace Rettangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci i lati");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci l'altezza");
            int h = int.Parse(Console.ReadLine());
            double area =  l*h/2;
            double perimetro = (l + h) * 2;
            Console.WriteLine($"L'area è {area} il perimetro è {perimetro}");
        }
    }
}
