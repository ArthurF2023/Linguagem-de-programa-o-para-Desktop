using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Exercício_1
{   
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 1
            Console.WriteLine("Mostrando na tela EXECICIO 1");
            int idadeJoao = 10;
            int idadeMaria = 25;
            int idadeCarlos = 30;

            Console.WriteLine($"idade Joao: {idadeJoao}");
            Console.WriteLine($"idade Maria: {idadeMaria}");
            Console.WriteLine($"idade Carlos: {idadeCarlos}");

            double mediaIdades = (idadeJoao + idadeMaria + idadeCarlos) / 4.0;

            Console.WriteLine($"MEDIA DAS IDADES: {mediaIdades}");

            Console.ReadLine();


            //EXERCICIO 2
            double pi = 3.14;
            Console.WriteLine($"Mostrando na tela EXERCICIO 2 ");
            Console.WriteLine(pi);
            Console.ReadLine();

            //EXERCICIO 3
            //int pi = 3.14;
            //double piQuebrado = (int)pi;
            //Console.WriteLine("piQuebrado = " + piQuebrado);
            //Console.ReadLine() ;


            //EXERCICIO 4
            Console.WriteLine("Mostrando na tela EXECICIO 4");
            int a = 1;
            int b = -3;
            int c = -4;
            // Calculando delta, a1 e a2 com a fórmula de Bhaskara.
            double delta = -b + b * b - 4 * a * c;
            double a1 = (-b + (delta)) / (2 * a);
            double a2 = (-b - (delta)) / (2 * a);
            // Imprima a1 e a2 em um MessageBox.
            Console.WriteLine("a1 = " + a1 + "\na2 = " + a2);
            Console.ReadKey();
            // Lembre-se de tratar casos onde delta é negativo para evitar calcular raiz qu


        }
    }
}


