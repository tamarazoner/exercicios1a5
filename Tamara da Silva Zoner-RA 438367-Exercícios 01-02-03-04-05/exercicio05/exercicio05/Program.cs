using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Nome: Tamara da Silva Zoner  RA: 43836-7
 * 5) Arquivo “produtos_estoque” mostrar o valor total de itens em estoque e o valor total em $.
 */
namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader texto = new StreamReader("produtos_estoque.txt");
            String linha = texto.ReadLine();
            int inicio, estoque, item;
            string resultado, pegaEstoque, resultado3, resultado4;     
            float total, valor, outro, porcem, valor2;
          
            while (linha != null)
            {
                Console.Write("valor total de itens em estoque: ");
                estoque = (linha.IndexOf("|") + 1);
                pegaEstoque = linha.Substring(estoque);
                Console.WriteLine(pegaEstoque);
                //Console.WriteLine(estoque);

                Console.Write("valor total em $:");
                inicio = (linha.IndexOf("$") + 1);
                //    Console.WriteLine(inicio);

                //int valor = Convert.ToInt32("<sua string>");
                //Int32.Parse
                resultado = linha.Substring(inicio, 5);
                resultado3 = linha.Substring(inicio, 2);
                resultado4 = linha.Substring((inicio+3), 2);
                outro = Convert.ToSingle(resultado4);
                porcem = (outro/100);
                item = Convert.ToInt32(pegaEstoque);
                
                valor = Convert.ToSingle(resultado3);
                valor2 = (valor + porcem);

                total = (valor)*(item);
               // string.Format("{0:0.00}", 123.0);
                Console.WriteLine(" $"+ string.Format("{0:0.00}", total));


                linha = texto.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
