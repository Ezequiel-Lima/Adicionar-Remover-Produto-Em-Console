using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidadeNoEstoque { get; set; }

        public Produto(string nome, double preco, int quantidadeNoEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeNoEstoque = quantidadeNoEstoque;
        }

        public double valorTotalEmEstoque()
        {
            return quantidadeNoEstoque;
        }

        public void adicionarProdutos(int quantidade)
        {
            quantidadeNoEstoque = quantidadeNoEstoque + quantidade;
        }

        public void removerProdutos(int quantidade)
        {
            quantidadeNoEstoque = quantidadeNoEstoque - quantidade;
        }

        public override string ToString()
        {
            return nome +
               ", $" +
               preco +
               ", quantidade:" +
               quantidadeNoEstoque +
               ", Total: $" +
               preco * quantidadeNoEstoque;
        }
    }
}
