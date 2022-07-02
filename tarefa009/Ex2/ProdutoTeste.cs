using System;
using System.Collections.Generic;

namespace ExLoja
{
    public class ProdutoTeste
    {
        public static void Testar()
        {
            var carrinho = new List<Produto>()
            {
                new Mouse("Ótico", "Mouse ótico, Saída USB, 1.600 dpi"),
                new Livro("H. P. Lovecraft", "Nas Montanhas da Loucura")
            };
            foreach (var produto in carrinho)
            {
                Console.WriteLine(produto.getDescricao());
            }
        }
    }
}
