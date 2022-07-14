using System;
namespace ExDivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Primeiro número:");
                var n1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Segundo número:");
                var n2 = Convert.ToDecimal(Console.ReadLine());

                var r = (n1 / n2);
                Console.WriteLine(r);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Valor não númerico");
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine("Divisão por zero");
            }
        }
    }
}
