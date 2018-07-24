using System;
using System.Globalization;

namespace Ex1{
    class Program{
        static int Main(string[] args){
            double nivel_glicose;

            Console.Write("Insira o valor de glicose: ");
            nivel_glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if(nivel_glicose < 0){
                Console.WriteLine("Valor Invalido!");
            } else if(nivel_glicose > 0 && nivel_glicose <= 100) {
                Console.WriteLine("Normal");
            } else if(nivel_glicose > 100 && nivel_glicose <= 140) {
                Console.WriteLine("Elevado");
            } else if(nivel_glicose > 140) {
                Console.WriteLine("Diabetes!");
            }
            return 0;
        }
    }
}

