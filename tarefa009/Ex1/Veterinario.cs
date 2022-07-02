using System;

namespace ExZoologico
{
    public class Veterinario
    {
        public void Examinar(Animal animal)
        {
            Console.WriteLine(animal.Som());
        }
    }
}