using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3
{
    internal class Program
    {
        static void Main()
        {
            //Para mostra na tela 
            Console.WriteLine("Coloque numero para fala por extenso:");
            string input = Console.ReadLine();
            //Para mostra no console cmd/ e definido como texto "string" 

            if (int.TryParse(input, out int Numero))
            {
                string NumeroExtenso = ConvertNumberToWords(Numero);
                Console.WriteLine($"O número por extenso é: {NumeroExtenso}");
                //Mosta na tela $ server para identificar e separar oque ta dentro chaves {}
            }
            else
            {
                Console.WriteLine("Não e numero! Por favor inserir um numero!");
            }

            Console.ReadKey();
        }
        //Aqui esta definido que sera int numero inteiro 
        static string ConvertNumberToWords(int Numero)
        {
            if (Numero == 0)
            {
                return "zero";
            }

            if (Numero < 0)
            {
                return "menos " + ConvertNumberToWords(Math.Abs(Numero));
            }

            string words = "";

            if ((Numero / 100) > 0)
            {
                words += ConvertNumberToWords(Numero / 100) + "cem";
                Numero %= 100;
            }
            
            if (Numero > 0)
            {
                //esse strinh texto esta defindo Unidade,Dezena 
                string[] Unidade = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
                string[] Dezena = { "dez", "onze", "doze", "treze", "catorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
                string[] Dezena2 = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };

                if (Numero < 10)
                {
                    words += Unidade[Numero];
                }
                else if (Numero < 20)
                {
                    words += Dezena[Numero - 10];
                }
                
            }

            return words.Trim();
        }
    }
}

