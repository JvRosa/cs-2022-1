using System;

namespace Exagenda{
    internal class Teste{
        static void Main(string[] args){
            var agenda = new Agenda();
            var contato = new Contato(){
                Nome = "João",
                Email = "joao@email.com"
            };
            agenda.AdicionaContato(contato);
            BuscaNome(agenda);
            BuscaEmail(agenda);
            ListarContatos(agenda);
            RemoverContato(agenda);
        }
        private static void RemoverContato(Agenda agenda){
            agenda.Remove("João");
        }
        private static void ListarContatos(Agenda agenda){
            var contatos = agenda.ListarContatos();

            foreach (var contato in contatos){
                Listar(contato);
            }
        }
        private static void BuscaNome(Agenda agenda){
            var contato = agenda.BuscaNome("João");
            Listar(contato);
        }
        private static void Listar(Contato contato){
            Console.WriteLine($"{contato.Nome} - {contato.Email}");
        }
        private static void BuscaEmail(Agenda agenda){
            var contato = agenda.BuscaEmail("joao@email.com");
            Listar(contato);
        }
    }
}
