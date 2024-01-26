using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primeiro Defini a double com Dolar
            const double taxaDeCambio = 0.20;

            // Solicitar ao usuário o valor em reais  criando variveis  
            Console.Write("inserir valor que vai ser convertido: ");
            double valorEmReais = Convert.ToDouble(Console.ReadLine());

            // Calcular o valor em dólares depois de ser convertido
            double valorEmDolares = ConverteParaDolar(valorEmReais, taxaDeCambio);

            // Mostra o resultado
            Console.WriteLine($"{valorEmReais} Reais equivalem a {valorEmDolares} Dólares.");

            Console.ReadLine();
        }
        //Criando outra classe para retorna os valores 
        static double ConverteParaDolar(double valorEmReais, double taxaDeCambio)
        {
            return valorEmReais * taxaDeCambio;
        }

    }
    
}
