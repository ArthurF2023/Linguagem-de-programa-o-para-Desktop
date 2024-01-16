using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //String seria um em texto piloto seria a variavel
          string[] pilotos = new string[4]
          {"Ayrton Senna", "Michael Schumacher", "Lewis Hamilton", "Alain Prost" };
          
          //Pilotos [2] vai mostra na tela WriteLine sequencia que foi definida no pilotos[2]
          Console.WriteLine(pilotos[2]);
          Console.WriteLine();
          pilotos[3] = "Rubens Barrichello";

          //FORACH esta juntando string que texto junto 
          foreach (string piloto in pilotos) 
          Console.WriteLine(piloto);
          Console.ReadLine();

         //Esse codigo esta realizando de mostra na tela so Corredores de forma F1, quando vc altera no piloto[] muda ordem
         //que vai mosta na tela 
          

        }
    }
}
