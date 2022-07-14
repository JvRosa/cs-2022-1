using System;

namespace ExLogin
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usuário:");
            var user = Console.ReadLine();
            Console.WriteLine("Senha:");
            var passw = Console.ReadLine();
            var login = new Login()
            {
                user = user,
                passw = passw
            };
            try
            {
                login.FazerLogin();
                Console.WriteLine("Login afetuado");
            }
            catch (LoginInvalidoException exception)
            {
                Console.WriteLine("Usuário ou senha incorretos");
            }
        }
    }
}
