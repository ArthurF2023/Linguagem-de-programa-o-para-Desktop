using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita a entrada de dados
            Console.Write("Informe a temperatura em graus Celsius: ");
            double temperaturaCelsius = double.Parse(Console.ReadLine());

            // Calcula a temperatura em graus Fahrenheit
            double temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

            // Exibe o resultado
            Console.WriteLine($"\nA temperatura em graus Fahrenheit é: {temperaturaFahrenheit:F2} °F");

            Console.ReadLine(); // Aguarda o usuário pressionar Enter para encerrar
        }
    }
}
