using System;
using System.Globalization;
namespace uri_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ponto2 = Console.ReadLine().Split();



            doublex1 = double.Parse(ponto1[0], CultureInfo.InvariantCulture);

            doublex2 = double.Parse(ponto1[1], CultureInfo.InvariantCulture);



            doubley1 = double.Parse(ponto2[0], CultureInfo.InvariantCulture);

            doubley2 = double.Parse(ponto2[1], CultureInfo.InvariantCulture);



            doubledistancia = Math.Sqrt(Math.Pow(x1 - y1, 2.00) + Math.Pow(x2 - y2, 2.00));



            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
