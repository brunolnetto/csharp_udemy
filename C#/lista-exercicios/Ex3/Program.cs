using System;
using System.Globalization;

namespace Ex1{
    class Program{
        static Boolean eh_positivo(double valor){
            return valor > 0;
        }

        static Boolean validarDimensao(double valor){
            return eh_positivo(valor); // && eh_menor_que(MAX_DIM);, e.g.
        }

        static double[] ParaDouble(String[] array_str){
            double[] array_db = new double[array_str.Length];

            for(int i = 0; i < array_str.Length; i++){
                array_db[i] = double.Parse(array_str[i], CultureInfo.InvariantCulture);
            }

            return array_db;
        }
        static Boolean saoValidas(double[] dimensoes){
            Boolean valido = true;
            
            for(int i = 0; i < dimensoes.Length; i++){
                valido &= validarDimensao(dimensoes[i]);
            }

            return valido;
        }

        static Boolean cabe(double[] foto_dims, double[] porta_retrato_dims){
            return ((foto_dims[0] <= porta_retrato_dims[0]) && 
                   (foto_dims[1] <= porta_retrato_dims[1])) || 
                   ((foto_dims[1] <= porta_retrato_dims[0]) && 
                   (foto_dims[0] <= porta_retrato_dims[1]));
        }

        static int Main(string[] args){

            Console.Write("Insira as dimensoes da foto: ");
            String[] dimensoes = Console.ReadLine().Split(" ");
            double[] foto_dims = ParaDouble(dimensoes);
            
            if(saoValidas(foto_dims)){
                Console.WriteLine("Dimensoes validas!");
            } else {
                Console.WriteLine("Dimensoes invalidas!");
                return 1;
            }

            Console.Write("Insira as dimensoes do porta-retrato: ");
            dimensoes = Console.ReadLine().Split(" ");
            double[] porta_retrato_dims = ParaDouble(dimensoes);

            if(saoValidas(porta_retrato_dims)){
                Console.WriteLine("Dimensoes validas!");
            } else {
                Console.WriteLine("Dimensoes invalidas!");
                return 1;
            }

            if(cabe(foto_dims, porta_retrato_dims)){
                Console.WriteLine("Foto coube, yeah!");
            } else {
                Console.WriteLine("Meh, nao coube :'(");
            }
            
            return 0;
        }
        
    }
}

