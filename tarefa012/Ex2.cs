using System;

namespace ExVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var array = new int[10];
                var nzero = false;

                for (int i = 0; !nzero; i++)
                {
                    var num = Convert.ToInt32(Console.ReadLine());
                    nzero = num == 0;

                    array[i] = num;
                }
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Valor não númerico");
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("Número de elementos excedido");
            }
        }
    }
}
