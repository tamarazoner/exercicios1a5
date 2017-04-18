using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Nome: Tamara da Silva Zoner  RA: 43836-7
 * 1) Arquivo "nomes_telefones" para cada número de telefone, retirar os parenteses e traços e apresentar no console
*/
namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader texto = new StreamReader("nomes_telefones.txt");
            String linha = texto.ReadLine();

            while(linha != null)
            {
                var resultado1 = linha.Replace("(", "").Replace(")", "").Replace("-", "");
                Console.WriteLine(resultado1);
                linha = texto.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
