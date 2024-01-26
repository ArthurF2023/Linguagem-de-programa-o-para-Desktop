using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inserir a identificação do vendedor 
            Console.Write("Informe a identificação do vendedor: ");
            int idVendedor = int.Parse(Console.ReadLine());

            // inserir o codigo da peça
            Console.Write("Informe o código da peça: ");
            int codigoPeca = int.Parse(Console.ReadLine());

            // inserir o preço da peça
            Console.Write("Informe o preço unitário da peça: ");
            double precoUnitario = double.Parse(Console.ReadLine());

            // inserir quantidade vendida
            Console.Write("Informe a quantidade vendida: ");
            int quantidadeVendida = int.Parse(Console.ReadLine());

            // Calcula o total da venda e a comissão
            double totalVenda = precoUnitario * quantidadeVendida;
            double comissao = totalVenda * 0.05;

            // Exibe os resultados separado em linhas
            Console.WriteLine("\n=== Resultados ===");
            Console.WriteLine($"Identificação do vendedor: {idVendedor}");
            Console.WriteLine($"Código da peça: {codigoPeca}");
            Console.WriteLine($"Preço unitário da peça: R${precoUnitario:F2}");
            Console.WriteLine($"Quantidade vendida: {quantidadeVendida}");
            Console.WriteLine($"Total da venda: R${totalVenda:F2}");
            Console.WriteLine($"Comissão do vendedor: R${comissao:F2}");

            Console.ReadLine();
        }
    }
}
