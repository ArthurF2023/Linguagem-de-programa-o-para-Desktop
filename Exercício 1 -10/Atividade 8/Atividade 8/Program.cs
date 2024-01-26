using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita a entrada de dados
            Console.Write("Informe o raio da lata de óleo: ");
            int raio = int.Parse(Console.ReadLine());

            Console.Write("Informe a altura da lata de óleo: ");
            int altura = int.Parse(Console.ReadLine());

            // Calcula o volume da lata de óleo
            double volume = 3.14159 * raio * raio * altura;

            // Exibe o resultado
            Console.WriteLine($"\nO volume da lata de óleo é: {volume:F2} unidades cúbicas");

            Console.ReadLine(); // Aguarda o usuário pressionar Enter para encerrar
        }
    }
}
