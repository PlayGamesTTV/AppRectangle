using System;

namespace AppRettangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Il programma è capace di calcolare l'area e il perimetro");
            Console.WriteLine("");
            Console.WriteLine("Immettere la base del rettangolo");
            decimal base1 = decimal.Parse(Console.ReadLine()); 
            Console.WriteLine("Immettere l'altezza del rettangolo");
            Decimal altezza = decimal.parse(Console.ReadLine());
            decimal Area = base1 * altezza;
            decimal Perimetro = (base1 + altezza ) * 2;
            Console.WriteLine("L'area equivale a " + Area );
            Console.WriteLine("");
            Console.WriteLine("Il perimetro equivale a " + Perimetro);


        }
    }
}