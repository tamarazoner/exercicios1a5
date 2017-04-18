using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Nome: Tamara da Silva Zoner  RA: 43836-7
 * 4) Arquivo "marcas_carros" extrair somente as marcas e apresentar no console
 */
namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {

            TextReader texto = new StreamReader("marcas_carros.txt");
            String linha = texto.ReadLine();
            int marcas;
            string resultado;

            while (linha != null)
            {
                marcas = (linha.IndexOf("@")-1);
                resultado = linha.Substring(0, marcas);
                Console.WriteLine(resultado);
                linha = texto.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
