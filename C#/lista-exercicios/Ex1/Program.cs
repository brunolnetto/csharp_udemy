using System;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double volumeInicial, volumeFinal, vazao, intervaloDeTempo;
            
            Console.Write("Insira o volume inicial do frasco [mL]: ");
            volumeInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Insira a vazao [mL/s]: ");
            vazao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o intervalo de tempo [s]: ");
            intervaloDeTempo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            volumeFinal = volumeInicial - vazao*intervaloDeTempo;

            Console.WriteLine("Volume final [mL]: " + volumeFinal.ToString());
        }
    }
}
