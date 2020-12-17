using System;
using Classes;

namespace objetos_como_argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Read dead Redemption 2", 200f);
            Produto p2 = new Produto(2,"GTA 5", 80.99f);
            Produto p3 = new Produto(3,"Detroit Become Huuman", 120.50f);
            Produto p4 = new Produto(4,"Rainbow six siege", 22.99f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);


            carrinho.RemoverProduto(p2);// Remover produto

            carrinho.MostrarProduto();
        }
    }
}
