namespace endereco.Classes
{
    public class PessoaFisica
    {
        public string Nome {get;set;}
        public string Sexo {get;set;}
        public DateTime dataNascimento {get;set;}
        public List<endereco> enderecos {get;set;}
    }
}
