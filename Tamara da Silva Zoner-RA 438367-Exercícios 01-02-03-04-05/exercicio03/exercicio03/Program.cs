using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Nome: Tamara da Silva Zoner RA: 43836-7
 * 3) Arquivo "datas" extrair somente o ano e mostrar no console
*/
namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader texto = new StreamReader("datas.txt");
            String linha = texto.ReadLine();
            String a;


            while (linha != null)
            {
                a = linha.Substring(6);
                Console.WriteLine(a);
                linha = texto.ReadLine();
            }
            Console.ReadKey();

        }
    }
}
