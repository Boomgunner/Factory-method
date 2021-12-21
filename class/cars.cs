using System;

namespace cars
{
    abstract class car
    {}
    class Rubikon:car
    {
        public Rubikon(string type)
        {
            Console.WriteLine($"Джип построен {type}");
        }
    }
    class S:car
    {
        public S(string type)
        {
            Console.WriteLine($"S-класс сделан {type}");
        }
    }
}