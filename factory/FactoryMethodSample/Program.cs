using System;

namespace FactoryMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // we have 2 different shops
            CostumeShop shop1 = new HumanHeroesCostumeShop();
            CostumeShop shop2 = new NotHumanHeroesCostumeShop();

            Console.WriteLine("\n---- Shop1: HumanHeroes ----");
            Console.WriteLine(shop1.ExhibitCostume("Ironman"));
            Console.WriteLine(shop1.ExhibitCostume("BlackWidow"));

            Console.WriteLine("\n---- Shop2: NotHumanHeroes ----");
            Console.WriteLine(shop2.ExhibitCostume("Gamora"));
            Console.WriteLine(shop2.ExhibitCostume("Thor"));
            // this costume is not available in the NotHumanHeroesCostumeShop
            Console.WriteLine(shop2.ExhibitCostume("CaptainAmerica"));

        }
    }
}
