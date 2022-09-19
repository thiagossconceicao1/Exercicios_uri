using System;
using System.Globalization;
namespace uri_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int autonomia = 12;
            float horaspercorridas, VelocidadeMedia, gastoCombustivel;


            horaspercorridas = float.Parse(Console.ReadLine());
            VelocidadeMedia = float.Parse(Console.ReadLine());

            gastoCombustivel = (VelocidadeMedia / autonomia) * horaspercorridas;

            Console.WriteLine(gastoCombustivel.ToString("F3", CultureInfo.InvariantCulture));





        }
    }
}
