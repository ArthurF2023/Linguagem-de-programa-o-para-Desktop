using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita a entrada de dados para mostra na tela guardando informação 
            Console.Write("Informe o tempo gasto na viagem (em horas): ");
            double tempoViagem = double.Parse(Console.ReadLine());

            Console.Write("Informe a velocidade média durante a viagem (em Km/h): ");
            double velocidadeMedia = double.Parse(Console.ReadLine());

            // Calcula a distância percorrida e a quantidade de litros de combustível utilizada
            double distanciaPercorrida = tempoViagem * velocidadeMedia;
            double litrosUsados = distanciaPercorrida / 12;

            // Exibe os resultados na tela com $ lendo que ta dentro de chaves
            Console.WriteLine("\n=== Resultados da Viagem ===");
            Console.WriteLine($"Velocidade média: {velocidadeMedia} Km/h");
            Console.WriteLine($"Tempo gasto na viagem: {tempoViagem} horas");
            Console.WriteLine($"Distância percorrida: {distanciaPercorrida} Km");
            Console.WriteLine($"Quantidade de litros utilizada: {litrosUsados:F2} litros");

            Console.ReadLine();
        }
    }
}
