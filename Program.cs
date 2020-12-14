using System;

namespace Projeto_POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor que deseja converter: ");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());

            //Converter Dolar para Real/Real para Dolar
            Console.WriteLine(Conversor.ConverterDolarParaReal());
            Console.WriteLine(Conversor.ConverterRealParaDolar());

            //Converter Euro para Real/Real para Euro
            Console.WriteLine(Conversor.ConverterEuroParaReal());
            Console.WriteLine(Conversor.ConverterRealParaEuro());
            
        }
    }
}
