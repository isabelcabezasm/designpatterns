﻿using System;
using System.Runtime.InteropServices;

namespace SimpleFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            // we need to instantiate the factory because it's not static
            CostumeFactory factory = new CostumeFactory();

            // we have 2 shops using the same factory
            CostumeShop shop1 = new CostumeShop(factory);
            CostumeShop shop2 = new CostumeShop(factory);

            Console.WriteLine("\n---- Shop1 ----");
            Console.WriteLine(shop1.ViewCostume("Ironman"));
            Console.WriteLine(shop1.ViewCostume("Thor"));

            Console.WriteLine("\n---- Shop2 ----");
            Console.WriteLine(shop2.ViewCostume("CaptainAmerica"));
            Console.WriteLine(shop2.ViewCostume("Thor"));
            Console.WriteLine(shop2.ViewCostume("BlackWidow"));

        }
    }
}
