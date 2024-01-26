using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita a entrada de dados
            Console.Write("Informe o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            //Mostra na tela com varivel int de numero inteiro
            Console.Write("Informe o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de C: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de D: ");
            int D = int.Parse(Console.ReadLine());

            // Realiza as operações de adição
            int resultadoSoma1 = A + B;
            int resultadoSoma2 = A + C;
            int resultadoSoma3 = A + D;
            int resultadoSoma4 = B + C;
            int resultadoSoma5 = B + D;
            int resultadoSoma6 = C + D;

            // Realiza as operações de Multiplicação
            int resultadoMultiplicacao1 = A * B;
            int resultadoMultiplicacao2 = A * C;
            int resultadoMultiplicacao3 = A * D;
            int resultadoMultiplicacao4 = B * C;
            int resultadoMultiplicacao5 = B * D;
            int resultadoMultiplicacao6 = C * D;

            // Exibe os resultados em linhas separados em adições
            Console.WriteLine("\n=== Resultados das Adições ===");
            Console.WriteLine($"A + B = {resultadoSoma1}");
            Console.WriteLine($"A + C = {resultadoSoma2}");
            Console.WriteLine($"A + D = {resultadoSoma3}");
            Console.WriteLine($"B + C = {resultadoSoma4}");
            Console.WriteLine($"B + D = {resultadoSoma5}");
            Console.WriteLine($"C + D = {resultadoSoma6}");

            // Exibe os resultados em linhas separados em multiplicação
            Console.WriteLine("\n=== Resultados das Multiplicações ===");
            Console.WriteLine($"A * B = {resultadoMultiplicacao1}");
            Console.WriteLine($"A * C = {resultadoMultiplicacao2}");
            Console.WriteLine($"A * D = {resultadoMultiplicacao3}");
            Console.WriteLine($"B * C = {resultadoMultiplicacao4}");
            Console.WriteLine($"B * D = {resultadoMultiplicacao5}");
            Console.WriteLine($"C * D = {resultadoMultiplicacao6}");

            Console.ReadLine(); 
        }
    }
}
