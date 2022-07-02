namespace ExLoja
{
    public class Mouse : Produto
    {
        private string tipo;
        public Mouse(string descricao, string tipo)
        {
            this.tipo = tipo;
            this.descricao = descricao;
        }
        public override string getDescricao()
        {
            return base.getDescricao() + " " + tipo;
        }
    }
}
