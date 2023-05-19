using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2class
{
    class Program
    {
        static void Main(string[] args)
        {
            produto p;
            p = new produto();

            Console.WriteLine("entre os dados do produto:");
            Console.Write("nome do produto: ");
            p.nome = Console.ReadLine();
            Console.Write("preço do produto: ");
            p.preco = double.Parse(Console.ReadLine());
            Console.Write("quantidade do produto: ");
            p.qtd = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("dados do produto: "+p);

            Console.WriteLine("digite o numero de  de produtos a ser adicionado ao estoque: ");
            int qtdA = int.Parse(Console.ReadLine());
            p.adicionar(qtdA);
            Console.WriteLine("Dados atualizados: "+p);

            Console.WriteLine("digite o numero de  de produtos a ser retirado do estoque: ");
            qtdA = int.Parse(Console.ReadLine());
            p.remover(qtdA);
            Console.WriteLine("Dados atualizados: " + p);



        }
    }
}
