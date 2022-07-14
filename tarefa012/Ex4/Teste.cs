using System;

namespace ExBanco
{
    internal class Test
    {
        static void Main(string[] args)
        {
            var account = new account();
            try
            {
                account.Give(2);
                account.Take(10);
            }
            catch (SaldoInsuficienteException exception)
            {
                Console.Write("Saldo insuficiente");
            }
        }
    }
}
