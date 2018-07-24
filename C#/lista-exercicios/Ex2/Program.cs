using System;
using System.Globalization;

namespace Ex1{
    class Program{
        static void Main(string[] args){
            
            const int NUM_NOTAS = 3;
            const double NOTA_MINIMA = 60.0;

            double[] notas = new double[NUM_NOTAS];
            double media = 0, soma = 0;
            
            for(int i = 0; i < args.Length; i = i + 1){
                notas[i] = double.Parse(args[i]);
                soma += notas[i];
            }

            media = (double) soma/NUM_NOTAS;
            Console.WriteLine(media.ToString());
            
            // Resultado
            if(media >= NOTA_MINIMA){
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("DEPENDENCIA");
            }
        }
    }
}
