using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int numero = 5; // Número para o qual você deseja calcular a tabuada
        int teste = 4; // Número para o qual você deseja calcular a tabuada

        Console.WriteLine($"Tabuada do {numero}:");
        Console.WriteLine($"Tabuada do {teste}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultadoMultiplicacao = numero * i;
            int resultadoSoma = numero + i;
            int resultadoSubtracao = numero - i;

            int x = teste * i;
            int mais =  teste + i;
            int menos = teste - i;

            Console.WriteLine($"{numero} x {i} = {resultadoMultiplicacao} | {numero} + {i} = {resultadoSoma} | {numero} - {i} = {resultadoSubtracao}");
            Console.WriteLine($"{teste} x {i} = {x} | {x} + {i} = {mais} | {teste} - {i} = {menos}");
        }

            Console.ReadKey();
    }
}
