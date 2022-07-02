using System;

namespace ExZoologico
{
    public class AnimalTeste
    {
        public static void Testar()
        {
            var cachorro = new Cachorro();
            var cavalo = new Cavalo();
            var preguica = new Preguica();
            Som(cachorro);
            Som(cavalo);
            Som(preguica);

            var veterinario = new Veterinario();
            veterinario.Examinar(cachorro);
            veterinario.Examinar(cavalo);
            veterinario.Examinar(preguica);

            var zoologico = new Zoologico();
            
            zoologico.Jaulas = new List<Jaula>()
            {
                new Jaula(cavalo),
                new Jaula(preguica),
                new Jaula(cachorro),
                new Jaula(preguica),
                new Jaula(cavalo),
                new Jaula(preguica),
                new Jaula(cachorro),
                new Jaula(cavalo),
                new Jaula(cachorro),
                new Jaula(preguica)
            };

            foreach (var jaula in zoologico.Jaulas)
            {
                Console.WriteLine(jaula.Animal.Som());
                if (jaula.Animal is Cachorro || jaula.Animal is Cavalo)
                {
                    Console.WriteLine(jaula.Animal.Movimento());
                }
            }
        }
        private static void Som(Animal animal)
        {
            Console.WriteLine(animal.Som());
        }
    }
}