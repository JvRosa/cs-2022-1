using System;
using System.Collections.Generic;

namespace ExZoologico
{
    public abstract class Animal
    {
        public string Nome {get;set;}

        public DateTime Idade {get;set;}

        public abstract string Som();

        public abstract string Movimento();

    }
}