using endereco.Enum;
namespace endereco.Classes
{
    public class endereco
    {
        public Bairro Bairro {get;set;}

        public Logradouro Logradouro {get;set;}

        public TipoenderecoEnum Tipo {get;set;}

        public int Numero {get;set;}

        public string Complemento {get;set;}

        public int CEP {get;set;}
    }
}
