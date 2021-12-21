using System;
using builder;

namespace Фабричный_метод
{
    class Program
    {
        static void Main(string[] args)
        {
            firm f1 = new jeep("Внедорожник","JEEP");
            f1.make();
            f1 = new mercedes("Легковушка","S");
            f1.make();

            Console.ReadKey(true);
        }
    }
}
