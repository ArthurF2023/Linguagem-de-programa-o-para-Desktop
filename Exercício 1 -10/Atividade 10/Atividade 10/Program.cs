using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita a entrada de dados
            Console.Write("Digite o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Verifica e exibe os relacionamentos de ordem
            if (numero1 == numero2)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else
            {
                Console.WriteLine("Os números são diferentes.");

                if (numero1 > numero2)
                {
                    Console.WriteLine($"{numero1} é maior que {numero2}.");
                    Console.WriteLine($"{numero2} é menor que {numero1}.");
                }
                else
                {
                    Console.WriteLine($"{numero1} é menor que {numero2}.");
                    Console.WriteLine($"{numero2} é maior que {numero1}.");
                }
            }

            // Verifica e exibe os relacionamentos de ordem (maior ou igual, menor ou igual)
            if (numero1 >= numero2)
            {
                Console.WriteLine($"{numero1} é maior ou igual a {numero2}.");
            }
            if (numero1 <= numero2)
            {
                Console.WriteLine($"{numero1} é menor ou igual a {numero2}.");
            }

            Console.ReadLine(); // Aguarda o usuário pressionar Enter para encerrar
        }
    }
}
