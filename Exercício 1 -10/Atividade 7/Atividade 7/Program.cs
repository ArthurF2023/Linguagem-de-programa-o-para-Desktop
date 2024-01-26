using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita a entrada de dados
            Console.Write("Informe a temperatura em graus Fahrenheit: ");
            double temperaturaFahrenheit = double.Parse(Console.ReadLine());

            // Calcula a temperatura em graus Celsius
            double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

            // Exibe o resultado
            Console.WriteLine($"\nA temperatura em graus Celsius é: {temperaturaCelsius:F2} °C");

            Console.ReadLine(); // Aguarda o usuário pressionar Enter para encerrar
        }
    }
}
