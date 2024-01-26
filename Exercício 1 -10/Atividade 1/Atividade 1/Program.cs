using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostra na tela 
            Console.WriteLine("Atividade 1");

            //Definido sua variavel
            int quantidadeMini = 20;
            int quantidadeMax = 50;

            //Double esta pegando as duas variaveis e dividindo em 2
            double EstoqueMe = (quantidadeMini + quantidadeMax ) / 2.0;

            //Mostrando na tela Media que foi definida no DOUBLE
            Console.WriteLine($"MEDIA DO ESTOQUE: {EstoqueMe}");

            Console.ReadLine();

        }
    }
}
