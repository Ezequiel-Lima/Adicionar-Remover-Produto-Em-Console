using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();

            Console.Write("Preço:");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque:");
            int estoque = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, estoque);

            Console.WriteLine($"\nDados do produto: {produto}");

            Console.Write($"\nDigite o número de produtos a ser adicionado no estoque:");
            estoque = int.Parse(Console.ReadLine());
            produto.adicionarProdutos(estoque);

            Console.WriteLine($"\nDados do produto atualizado: {produto}");

            Console.Write($"\nDigite o número de produtos a ser removido no estoque:");
            estoque = int.Parse(Console.ReadLine());
            produto.removerProdutos(estoque);

            Console.WriteLine($"\nDados do produto atualizado: {produto}");

            Console.Write($"\nPressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
