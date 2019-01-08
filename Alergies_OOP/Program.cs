using System;

namespace Alergies_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Alergy alergy = new Alergy("Andreea",90);
            Console.WriteLine(alergy.ListAlergy());
            Console.WriteLine(alergy.TestAlergy(Alergy.Alergies.Peanuts));
            alergy.AddAlergy(Alergy.Alergies.Strawberries);
            Console.WriteLine(alergy.ListAlergy());
        }
    }
}
