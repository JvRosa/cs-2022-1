using System.Collections.Generic;
using System.Linq;

namespace Exagenda{
    public class Agenda{
        private List<Contato> Contatos {get;} = new();

        public void AdicionaContato(Contato contato){
            Contatos.Add(contato);
        }
        public Contato BuscaNome(string nome){
            return Contatos.FirstOrDefault(x => x.Nome.ToUpper() == nome.ToUpper());
        }
        public Contato BuscaEmail(string email){
            return Contatos.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper());
        }
        public void RemoveContato(string nome){
        }
        public List<Contato> ListarContatos(){
            return Contatos;
        }
    }
}
