using System;

namespace AbstractFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- On Planet Earth -----\n");
            ICostumeFactory factoryOnEarth = new HumanHeroesCostumeFactory();
            CostumeShop shop1 = new CostumeShop(factoryOnEarth);

            Console.WriteLine(shop1.SetUpShopWindow());       

            Console.WriteLine("\n----- Somewhere in Space -----\n");
            ICostumeFactory factoryInSpace = new NotHumanHeroesCostumeFactory();
            CostumeShop shop2 = new CostumeShop(factoryInSpace);

            Console.WriteLine(shop2.SetUpShopWindow());
        }
    }
}
