namespace ExLoja
{
    public class Livro : Produto
    {
        private string autor;
        public Livro(string descricao, string autor)
        {
            this.autor = autor;
            this.descricao = descricao;
        }
        public override string getDescricao()
        {
            return base.getDescricao() + " " + autor;
        }
    }
}
