using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Nome: Tamara da Silva Zoner RA: 43836-7
 * 2) Arquivo "nomes_telefones" para cada nome de pessoa, 
 * verificar os maiores de 12 caracteres e apresentar na tela os mesmos em UpperCase
 */
namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader texto = new StreamReader("nomes_telefones.txt");
            String linha = texto.ReadLine();
            String maiuscula, nome;
          

            while (linha != null)
            {
                int posicao = (linha.IndexOf("(")-2);
                if (posicao>12)
                {
                    nome = linha.Substring(0, posicao+1);
                    maiuscula = nome.ToUpper();
                    Console.WriteLine(maiuscula);
                }
                linha = texto.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
